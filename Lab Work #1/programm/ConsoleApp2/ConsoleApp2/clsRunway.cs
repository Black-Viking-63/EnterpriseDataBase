using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBase.Classes.Models
{
    class clsRunway
    {
        private int id_run;
        private int length_runway;
        private int width_runway;
        private bool active_label;
        private int class_runway;
        private int id_airport;

        public clsRunway(int id_run, int length_runway, int width_runway, bool active_label, int class_runway, int id_airport)
        {
            this.id_run = id_run;
            this.length_runway = length_runway;
            this.width_runway = width_runway;
            this.active_label = active_label;
            this.class_runway = class_runway;
            this.id_airport = id_airport;
        }

        public int Id_run { get => id_run; set => id_run = value; }
        public int Length_runway { get => length_runway; set => length_runway = value; }
        public int Width_runway { get => width_runway; set => width_runway = value; }
        public bool Active_label { get => active_label; set => active_label = value; }
        public int Class_runway { get => class_runway; set => class_runway = value; }
        public int Id_airport { get => id_airport; set => id_airport = value; }

        public static clsRunway randomRunway(int id_runway, Random random, int countStart)
        {
            int length = clsData.lenghts[random.Next(0, clsData.lenghts.Length)];
            int width = clsData.widths[random.Next(0, clsData.widths.Length)]; ;
            bool active = clsData.labels[random.Next(0, clsData.labels.Length)];
            int classy = clsData.classes_airport[random.Next(0, clsData.classes_airport.Length)];
            int id = random.Next(1, countStart);
            return new clsRunway(id_runway, length, width, active, classy, id);
        }

        public String toString()
        {
            return Id_run.ToString() +
                " " + Length_runway.ToString() +
                " " + Width_runway.ToString() +
                " " + Active_label.ToString() +
                " " + Class_runway.ToString() +
                " " + Id_airport.ToString();
        }
    }
}
