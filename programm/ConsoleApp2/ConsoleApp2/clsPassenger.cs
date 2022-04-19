using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBase.Classes.Models
{
    class clsPassenger
    {
        //name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets
        private int id_pass;
        private string name_passenger;
        private string second_name_passenger;
        private int number_pasport;
        private int weight_baggage;
        private int id_tickets;

        public int Id_pass { get => id_pass; set => id_pass = value; }
        public string Name_passenger { get => name_passenger; set => name_passenger = value; }
        public string Second_name_passenger { get => second_name_passenger; set => second_name_passenger = value; }
        public int Number_pasport { get => number_pasport; set => number_pasport = value; }
        public int Weight_baggage { get => weight_baggage; set => weight_baggage = value; }
        public int Id_tickets { get => id_tickets; set => id_tickets = value; }

        public clsPassenger(int id, string name_passenger, string second_name_passenger, int number_pasport, int weight_baggage, int id_tickets)
        {
            this.id_pass = id; 
            this.name_passenger = name_passenger;
            this.second_name_passenger = second_name_passenger;
            this.number_pasport = number_pasport;
            this.weight_baggage = weight_baggage;
            this.id_tickets = id_tickets;            
        }

        public clsPassenger()
        {
            
        }


        public static clsPassenger randomPassenger(Random random, int countStart)
        {
            string name = clsData.names_passengers[random.Next(0, clsData.names_passengers.Length)];
            string second_name = clsData.second_names_passengers[random.Next(0, clsData.second_names_passengers.Length)];
            int numberPassport = 1000000 + countStart;
            int weight = random.Next(1, 25);
            int numberTickets = 10000000 + countStart;
            return new clsPassenger(countStart, name, second_name, numberPassport, weight, numberTickets);
        }

        public String toString()
        {
            return Id_pass.ToString() +
                " " + Name_passenger.ToString() +
                " " + Second_name_passenger.ToString() +
                " " + Number_pasport.ToString() +
                " " + Weight_baggage.ToString() +
                " " + Id_tickets.ToString();
        }
    }
}
