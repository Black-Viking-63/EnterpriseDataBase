using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBase.Classes.SQL
{
    public static class clsSQLNavigation
    {
        public static double countRowsInTable;
        public static int numberCurrentPage;
        public static int numberRow;
        private static int idRow;

        public static double sizeShowPage = 25;
        public static double sizeEditPage = 15;

        public static double CountRowsInTable { get => countRowsInTable; set => countRowsInTable = value; }
        public static int NumberCurrentPage { get => numberCurrentPage; set => numberCurrentPage = value; }
        public static int NumberRow { get => numberRow; set => numberRow = value; }
        public static int IdRow { get => idRow; set => idRow = value; }

        public static int countPage() 
        {
            switch (clsManage.Mode)
            {
                case 1: 
                    {
                        int intNum = (int)CountRowsInTable / (int)sizeShowPage;
                        double doubleNum = countRowsInTable / sizeShowPage;
                        if (intNum == 0 || doubleNum == 0) intNum = 1;
                        if(doubleNum > intNum)
                            return intNum+1;
                        else
                            return intNum;
                    }
                case 2:
                    {
                        int intNum = (int)countRowsInTable / (int)sizeEditPage;
                        double doubleNum = countRowsInTable / sizeEditPage;
                        if (intNum == 0 || doubleNum == 0) intNum = 1;
                        if (doubleNum > intNum)
                            return intNum + 1;
                        else
                            return intNum;
                    }
                default: return 0;
            }
        }

        public static void addlbl(FlowLayoutPanel flowLayoutPanel, EventHandler label3_Click)
        {
            Enumerable.Range(1, clsSQLNavigation.countPage()).ToList().ForEach((element) =>
            {
                Label lbl = new System.Windows.Forms.Label();
                lbl.AutoSize = true;
                lbl.Location = new System.Drawing.Point(3, 0);
                lbl.Name = "lbl" + element;
                lbl.Size = new System.Drawing.Size(61, 13);
                lbl.Text = element.ToString();
                lbl.Tag = element;
                if (element == clsSQLNavigation.numberCurrentPage + 1) lbl.ForeColor = Color.Red;
                lbl.Click += new EventHandler(label3_Click);
                flowLayoutPanel.Controls.Add(lbl);                
            });
        }

        public static void showPage()
        {
            if (clsManage.Mode == 1)
            {
                clsSQLConnection.gotoPage(NumberCurrentPage, (int)sizeShowPage);
            }
            if (clsManage.Mode == 2)
            {
                clsSQLConnection.gotoPage(numberCurrentPage, (int)sizeEditPage);
            }
        }

        public static void loadDataInView(ComboBox comboBox, DataGridView dataGridView)
        {
            comboBox.KeyPress += (sender, e) => e.Handled = true;
            clsSQLConnection.showData(dataGridView);
            CountRowsInTable = dataGridView.Rows.Count;
            clsManage.resize(dataGridView);
            if (clsManage.Mode == 1)
            {
                clsSQLConnection.gotoPage(NumberCurrentPage, (int)sizeShowPage);
            }
            if (clsManage.Mode == 2)
            {
                clsSQLConnection.gotoPage(NumberCurrentPage, (int)sizeEditPage);
            }
        }

        public static void showListPage(ComboBox comboBox, int load) 
        {
            comboBox.Items.Clear();
            Enumerable.Range(1, countPage()).ToList().ForEach((element) =>
            {
                comboBox.Items.Add(element);
            });
            if(load == 0) comboBox.SelectedIndex = 0;
            else comboBox.SelectedIndex = NumberCurrentPage;
        }

        public static void showFirstPage(ComboBox comboBox)
        {
            NumberCurrentPage = 0;
            comboBox.SelectedIndex = NumberCurrentPage;
            showPage();
        }
        
        public static void showEndPage(ComboBox comboBox)
        {
            NumberCurrentPage = countPage() - 1;
            comboBox.SelectedIndex = NumberCurrentPage;
            showPage();
        }

        public static void showPrevPage(ComboBox comboBox)
        {
            int check = NumberCurrentPage;
            NumberCurrentPage = (check - 1) > 0 ? (NumberCurrentPage - 1) : 0;
            comboBox.SelectedIndex = NumberCurrentPage;
            showPage();
        }

        public static void showNextPage(ComboBox comboBox)
        {
            int check = NumberCurrentPage;
            NumberCurrentPage = (check + 1) <= (countPage() - 1) ?
                (NumberCurrentPage + 1) : NumberCurrentPage;
            comboBox.SelectedIndex = NumberCurrentPage;
            showPage();
        }

        public static void showSelectedPage(ComboBox comboBox) 
        {
            NumberCurrentPage = comboBox.SelectedIndex;
            showPage();
        }
    }
}
