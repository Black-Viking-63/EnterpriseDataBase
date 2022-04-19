using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBase.Classes.Models
{
    class clsAirPass
    {
        private int id_company;
        private int id_pass;

        public clsAirPass(int id_company, int id_pass)
        {
            this.id_company = id_company;
            this.id_pass = id_pass;
        }

        public int Id_company { get => id_company; set => id_company = value; }
        public int Id_pass { get => id_pass; set => id_pass = value; }

        public static clsAirPass randomAirPass(Random random, int countStart) 
        {
            int company = random.Next(1, countStart);
            int pass = random.Next(1, countStart);
            return new clsAirPass(company, pass);
        }
        public String toString()
        {
            return Id_company.ToString() +
                " " + id_pass.ToString();
        }
    }
}
