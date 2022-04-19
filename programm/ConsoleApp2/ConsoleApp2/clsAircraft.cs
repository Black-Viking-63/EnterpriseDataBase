using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBase.Classes.Models
{
    class clsAircraft
    {
        private int id_activeAircraft;
        private bool active_label;
        private string departure_airport;
        private string arrival_airport;

        public clsAircraft(int id_activeAircraft, bool active_label, string departure_airport, string arrival_airport)
        {
            this.id_activeAircraft = id_activeAircraft;
            this.active_label = active_label;
            this.departure_airport = departure_airport;
            this.arrival_airport = arrival_airport;
        }

        public int Id_activeAircraft { get => id_activeAircraft; set => id_activeAircraft = value; }
        public bool Active_label { get => active_label; set => active_label = value; }
        public string Departure_airport { get => departure_airport; set => departure_airport = value; }
        public string Arrival_airport { get => arrival_airport; set => arrival_airport = value; }

        public static clsAircraft randomAircraft(int id, Random random)
        {
            bool label = clsData.labels[random.Next(0, clsData.labels.Length)];
            if (label == true)
            {
                string d_airport = clsData.airports[random.Next(0, clsData.airports.Length)];
                string a_airport = clsData.airports[random.Next(0, clsData.airports.Length)];
                while (a_airport.Equals(d_airport))
                {
                    a_airport = clsData.airports[random.Next(0, clsData.airports.Length)];
                }
                return new clsAircraft(id, label, d_airport, a_airport);
            }
            else
            {
                string d_airport = "NULL";
                string a_airport = "NULL";
                return new clsAircraft(id, label, d_airport, a_airport);
            }
        }

        public String toString()
        {
            return Id_activeAircraft.ToString() +
                " " + Active_label.ToString() +
                " " + Departure_airport.ToString() +
                " " + Arrival_airport.ToString();
        }
    }
}
