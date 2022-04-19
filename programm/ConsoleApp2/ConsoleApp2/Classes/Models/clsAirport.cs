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
        private int count_runway;

        public clsAirport(int id_airport, string dislocation, string name_airport, int count_runway)
        {
            this.id_airport = id_airport;
            this.dislocation = dislocation;
            this.name_airport = name_airport;
            this.count_runway = count_runway;
        }

        public int Id_airport { get => id_airport; set => id_airport = value; }
        public string Dislocation { get => dislocation; set => dislocation = value; }
        public string Name_airport { get => name_airport; set => name_airport = value; }
        public int Count_runway { get => count_runway; set => count_runway = value; }

        public static clsAirport randomAirport(int id, Random random)
        {
            string dislocation = clsData.dislocations[random.Next(0, clsData.dislocations.Length)];
            string name = clsData.names_airports[random.Next(0, clsData.names_airports.Length)];
            int count = random.Next(1, 10);
            return new clsAirport(id, dislocation, name, count);
        }

    }
}
