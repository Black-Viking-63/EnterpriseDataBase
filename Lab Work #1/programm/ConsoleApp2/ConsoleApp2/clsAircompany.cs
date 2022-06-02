using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBase.Classes.Models
{
    class clsAircompany
    {
        //name_aircompany, count_aircraft, mean_count_passenger, city_dislocation
        private int id_aircompany;
        private string name_aircompany;
        private int count_aircraft;
        private int mean_count_passenger;
        private string city_dislocation;

        public clsAircompany(int id_aircompany, string name_aircompany, int count_aircraft, int mean_count_passenger, string city_dislocation)
        {
            this.id_aircompany = id_aircompany;
            this.name_aircompany = name_aircompany;
            this.count_aircraft = count_aircraft;
            this.mean_count_passenger = mean_count_passenger;
            this.city_dislocation = city_dislocation;
        }

        public int Id_aircompany { get => id_aircompany; set => id_aircompany = value; }
        public string Name_aircompany { get => name_aircompany; set => name_aircompany = value; }
        public int Count_aircraft { get => count_aircraft; set => count_aircraft = value; }
        public int Mean_count_passenger { get => mean_count_passenger; set => mean_count_passenger = value; }
        public string City_dislocation { get => city_dislocation; set => city_dislocation = value; }

        public static clsAircompany randomAircompany(int id, Random random)
        {
            string name = clsData.names_aircompanies[random.Next(0, clsData.names_aircompanies.Length)];
            int count = random.Next(1,1000);
            int mean_count = random.Next(1, 1000000000); ;
            string city = clsData.dislocations[random.Next(0, clsData.dislocations.Length)];
            return new clsAircompany(id, name, count, mean_count, city);
        }

        public String toString()
        {
            return Id_aircompany.ToString() +
                " " + Name_aircompany.ToString() +
                " " + Count_aircraft.ToString() +
                " " + Mean_count_passenger.ToString() +
                " " + City_dislocation.ToString();
        }
    }
}
