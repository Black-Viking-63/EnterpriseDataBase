using AirBase.childForms.fourthLevel;
using AirBase.Classes.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBase.Classes
{
    public static class clsManage
    {

        private static int mode;                            // show or edit database
        private static int numbertable;

        public static Form currentChildFormFirstLevel;
        public static Form currentChildFormSecondLevel;
        public static Form currentChildFormThirdLevel;
        public static Form currentChildFormFourthLevel;

        public static int Mode { get => mode; set => mode = value; }
        public static int NumberTable { get => numbertable; set => numbertable = value; }

        //  для выбора режима работы (просмотр бд, редактирование, стресс тест)
        public static void openChildFormFirstLevel(Form childForm, Panel panel)
        {
            if (currentChildFormFirstLevel != null)
            {
                currentChildFormFirstLevel.Close();
            }
            currentChildFormFirstLevel = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            childForm.Show();
        }

        // для выбора таблицы
        public static void openChildFormSecondLevel(Form childForm, Panel panel)
        {
            if (currentChildFormSecondLevel != null)
            {
                currentChildFormSecondLevel.Close();
            }
            currentChildFormSecondLevel = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            childForm.Show();
        }      
       
        // для редактирования        
        public static void openEditForm(Panel panel2)
        {
            switch (NumberTable)
            {
                case 0: openChildFormSecondLevel(new fEditAircraft(), panel2); break;
                case 1: openChildFormSecondLevel(new fEditInfoAircraft(), panel2); break;
                case 2: openChildFormSecondLevel(new fEditAirport(), panel2); break;
                case 3: openChildFormSecondLevel(new fEditRunway(), panel2); break;
                case 4: openChildFormSecondLevel(new fEditAircompany(), panel2); break;
                case 5: openChildFormSecondLevel(new fEditPassenger(), panel2); break;
                case 6: openChildFormSecondLevel(new fEditAirPass(), panel2); break;
            };
        }

        // для корректного отображения данных 
        public static void resize(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public static void selectNumberTable(int i, ComboBox comboBox, DataGridView dataGridView) 
        {
            switch (i)
            {
                case 0: 
                    {
                        NumberTable = 0;
                        clsSQLNavigation.loadDataInView(comboBox, dataGridView);
                    }; break;
                case 1:
                    {
                        NumberTable = 1;
                        clsSQLNavigation.loadDataInView(comboBox, dataGridView);
                    }; break;
                case 2:
                    {
                        NumberTable = 2;
                        clsSQLNavigation.loadDataInView(comboBox, dataGridView);
                    }; break;
                case 3:
                    {
                        NumberTable = 3;
                        clsSQLNavigation.loadDataInView(comboBox, dataGridView);
                    }; break;
                case 4:
                    {
                        NumberTable = 4;
                        clsSQLNavigation.loadDataInView(comboBox, dataGridView);
                    }; break;
                case 5:
                    {
                        NumberTable = 5;
                        clsSQLNavigation.loadDataInView(comboBox, dataGridView);
                    }; break;
                case 6:
                    {
                        NumberTable = 6;
                        clsSQLNavigation.loadDataInView(comboBox, dataGridView);
                    }; break;
            }
        }
    
    }
}
