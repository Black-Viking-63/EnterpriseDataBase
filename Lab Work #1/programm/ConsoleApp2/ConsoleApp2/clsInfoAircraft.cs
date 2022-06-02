using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBase.Classes.Models
{
    class clsInfoAircraft
    {
        private int id_info;
        private string company_aircraft;
        private string model_aircraft;
        private int count_seats;
        private string class_aircraft;
        private DateTime start_operation;
        private DateTime end_operation;

        public int Id_info { get => id_info; set => id_info = value; }
        public string Company_aircraft { get => company_aircraft; set => company_aircraft = value; }
        public string Model_aircraft { get => model_aircraft; set => model_aircraft = value; }
        public int Count_seats { get => count_seats; set => count_seats = value; }
        public string Class_aircraft { get => class_aircraft; set => class_aircraft = value; }
        public DateTime Start_operation { get => start_operation; set => start_operation = value; }
        public DateTime End_operation { get => end_operation; set => end_operation = value; }

        public clsInfoAircraft(int id_info, string company_aircraft, string model_aircraft, int count_seats, string class_aircraft, DateTime start_operation, DateTime end_operation)
        {
            this.id_info = id_info;
            this.company_aircraft = company_aircraft;
            this.model_aircraft = model_aircraft;
            this.count_seats = count_seats;
            this.class_aircraft = class_aircraft;
            this.start_operation = start_operation;
            this.end_operation = end_operation;
        }

        static DateTime RandomDay()
        {
            Random random = new Random();
            DateTime start = new DateTime(1970, 1, 1);
            DateTime end = new DateTime(2070, 1, 1);
            int range = (end - start).Days;
            return start.AddDays(random.Next(range));
        }

        public static clsInfoAircraft randomInfoAicraft(int id, Random random)
        {
            string company = clsData.companies[random.Next(0, clsData.companies.Length)];
            string model = clsData.models[random.Next(0, clsData.models.Length)];
            int count = random.Next(10, 800);
            string classy = clsData.classes_aircraft[random.Next(0, clsData.classes_aircraft.Length)];
            DateTime start_operation = RandomDay();
            DateTime end_operation = RandomDay();
            while (start_operation >= end_operation)
            {
                start_operation = RandomDay();
                end_operation = RandomDay();
            }
            return new clsInfoAircraft(id, company, model, count, classy, start_operation, end_operation);
        }

        public String toString()
        {
            return Id_info.ToString() +
                " " + Company_aircraft.ToString() +
                " " + Model_aircraft.ToString() +
                " " + Count_seats.ToString() +
                " " + Class_aircraft.ToString() +
                " " + Start_operation.ToShortDateString() +
                " " + End_operation.ToShortDateString();
        }

    }
}
