using AirBase.Classes.Models;
using AirBase.Classes.SQL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void generateData(int tv, int count_start)
        {
            List<clsAirPass> airPasses = new List<clsAirPass>();
            string path = "";
            for (int i = 0; i < 7; i++)
            {
                Random random = new Random();
                if(tv == 1)
                    path = "F:\\DATA\\small" + i + ".txt";
                if (tv == 2)
                    path = "F:\\DATA\\big" + i + ".txt";
                for (int j = 0; j < count_start; j++)
                {
                    int id = j + 1;
                    switch (i)
                    {
                        case 0:
                            {
                                clsAircraft aircraft = clsAircraft.randomAircraft(id, random);
                                try
                                {
                                    StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                                    writer.WriteLine(aircraft.toString());
                                    writer.Close();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Exception: " + e.Message);
                                }
                                Console.WriteLine("Row " + j + " is inserted");
                            };
                            break;
                        case 1:
                            {
                                if (tv == 2)
                                {
                                    if (j % 1000 == 0)
                                    {
                                        clsInfoAircraft info = clsInfoAircraft.randomInfoAicraft(id, random);
                                        try
                                        {
                                            StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                                            writer.WriteLine(info.toString());
                                            writer.Close();
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine("Exception: " + e.Message);
                                        }
                                        Console.WriteLine("Row " + j + " is inserted");
                                    }
                                }
                                else
                                {
                                    clsInfoAircraft info = clsInfoAircraft.randomInfoAicraft(id, random);
                                    try
                                    {
                                        StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                                        writer.WriteLine(info.toString());
                                        writer.Close();
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Exception: " + e.Message);
                                    }
                                    Console.WriteLine("Row " + j + " is inserted");
                                }
                            };
                            break;
                        case 2:
                            {
                                clsAirport airport = clsAirport.randomAirport(id, random);
                                try
                                {
                                    StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                                    writer.WriteLine(airport.toString());
                                    writer.Close();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Exception: " + e.Message);
                                }
                                Console.WriteLine("Row " + j + " is inserted");
                            };
                            break;
                        case 3:
                            {
                                if (tv == 2)
                                {
                                    if (j % 1000 == 0)
                                    {

                                        clsRunway runway = clsRunway.randomRunway(id, random, count_start);
                                        try
                                        {
                                            StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                                            writer.WriteLine(runway.toString());
                                            writer.Close();
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine("Exception: " + e.Message);
                                        }
                                        Console.WriteLine("Row " + j + " is inserted");
                                    }
                                }
                                else
                                {
                                    clsRunway runway = clsRunway.randomRunway(id, random, count_start);
                                    try
                                    {
                                        StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                                        writer.WriteLine(runway.toString());
                                        writer.Close();
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Exception: " + e.Message);
                                    }
                                    Console.WriteLine("Row " + j + " is inserted");
                                }
                            };
                            break;
                        case 4:
                            {
                                clsAircompany aircompany = clsAircompany.randomAircompany(id, random);
                                try
                                {
                                    StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                                    writer.WriteLine(aircompany.toString());
                                    writer.Close();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Exception: " + e.Message);
                                }
                                Console.WriteLine("Row " + j + " is inserted");
                            };
                            break;
                        case 5:
                            {
                                clsPassenger passenger = clsPassenger.randomPassenger(random, id);
                                try
                                {
                                    StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                                    writer.WriteLine(passenger.toString());
                                    writer.Close();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Exception: " + e.Message);
                                }
                                Console.WriteLine("Row " + j + " is inserted");
                            };
                            break;
                        case 6:
                            {
                                if (tv == 2)
                                {
                                    if (j % 1000 == 0)
                                    {
                                        clsAirPass airPass = clsAirPass.randomAirPass(random, count_start);
                                        while (airPasses.Contains(airPass))
                                        {
                                            airPass = clsAirPass.randomAirPass(random, count_start);
                                        }
                                        airPasses.Add(airPass);
                                        try
                                        {
                                            StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                                            writer.WriteLine(airPass.toString());
                                            writer.Close();
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine("Exception: " + e.Message);
                                        }
                                        Console.WriteLine("Row " + j + " is inserted");
                                    }
                                }
                                else
                                {
                                    clsAirPass airPass = clsAirPass.randomAirPass(random, count_start);
                                    airPasses.Add(airPass);
                                    while (airPasses.Contains(airPass))
                                    {
                                        airPass = clsAirPass.randomAirPass(random, count_start);
                                    }
                                    airPasses.Add(airPass);
                                    try
                                    {
                                        StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                                        writer.WriteLine(airPass.toString());
                                        writer.Close();
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Exception: " + e.Message);
                                    }
                                    Console.WriteLine("Row " + j + " is inserted");
                                }
                            };
                            break;
                    }

                }
                Console.WriteLine("Table " + i + " is inserted");
            }
        }

        static void Main(string[] args)
        {            
            int mode = -1;
            Console.WriteLine("Выберите режим работы:\n0 - выход из программы\n1 - малая генерация данных\n2 - большая генерация данных");            
            bool continues = true;
            while (continues) 
            {
                if (int.TryParse(Console.ReadLine(), out mode) && (mode == 0 || mode == 1 || mode == 2))
                {
                    if (mode == 0)
                    {
                        Environment.Exit(0); 
                    }
                    if (mode == 1)
                    {
                        generateData(1, 150);
                        continues = false;
                    }
                    if (mode == 2)
                    {
                        generateData(2, 1000000);
                        continues = false;
                    }
                }
                else
                {
                    Console.WriteLine("Выберите режим работы:\n1 - малая генерация данных\n2 - большая генерация данных");
                }
            }
            Console.WriteLine("Для выхода из программы нажмите на любую клавишу КЛАВИАТУРЫ...");
            Console.ReadLine(); 
        }
    }
}
