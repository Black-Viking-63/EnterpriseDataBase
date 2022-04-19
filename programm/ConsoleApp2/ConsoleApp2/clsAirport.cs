using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBase.Classes.Models
{
    class clsAirport
    {
        private int id_airport;
        private string dislocation;
        private string name_airport;
        private string class_airport;
        private int count_runway;

        public clsAirport(int id_airport, string dislocation, string name_airport, string class_airport, int count_runway)
        {
            this.id_airport = id_airport;
            this.dislocation = dislocation;
            this.name_airport = name_airport;
            this.class_airport = class_airport;
            this.count_runway = count_runway;
        }

        public int Id_airport { get => id_airport; set => id_airport = value; }
        public string Dislocation { get => dislocation; set => dislocation = value; }
        public string Name_airport { get => name_airport; set => name_airport = value; }
        public string Class_airport { get => class_airport; set => class_airport = value; }
        public int Count_runway { get => count_runway; set => count_runway = value; }

        public static clsAirport randomAirport(int id, Random random)
        {
            string dislocation = clsData.dislocations[random.Next(0, clsData.dislocations.Length)];
            string name = clsData.names_airports[random.Next(0, clsData.names_airports.Length)];
            int count = random.Next(1, 10);
            string type = clsData.types_airport[random.Next(0, clsData.types_airport.Length)];
            return new clsAirport(id, dislocation, name, type, count);
        }
        public String toString()
        {
            return Id_airport.ToString() +
                " " + Dislocation.ToString() +
                " " + Name_airport.ToString() +
                " " + Class_airport.ToString() +
                " " + Count_runway.ToString();
        }
    }
}
