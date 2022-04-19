using AirBase.Classes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBase.Classes.SQL
{
    class clsSQLConnection
    {
        public static SqlConnection myConnectionDatabaseSQL = new SqlConnection("Server=DESKTOP-62SAK36\\SQLDEV1;Integrated security=SSPI;database=master");
        public static SqlConnection myConnectionTableSQL = new SqlConnection("Data Source = DESKTOP-62SAK36\\SQLDEV1;Initial Catalog = AirDataBase;Integrated security=SSPI");

        // выполнение запросов к базе данных
        static void executeQueryDB(SqlCommand myCommand)
        {
            try
            {
                myConnectionDatabaseSQL.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConnectionDatabaseSQL.State == ConnectionState.Open)
                {
                    myConnectionDatabaseSQL.Close();
                }
            }
        }

        // выполнение запросов к схеме базы данных
        static void executeQueryTable(SqlCommand myCommand)
        {
            try
            {
                myConnectionTableSQL.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
               // Console.WriteLine(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConnectionTableSQL.State == ConnectionState.Open)
                {
                    myConnectionTableSQL.Close();
                }
            }
        }

        // создание базы данных
        static void createDatabase()
        {
            SqlCommand myCommand = new SqlCommand(clsSQLDataQuery.queryCreateDataBase, myConnectionDatabaseSQL);
            executeQueryDB(myCommand);
        }
        
        // удаление базы данных
        public static void dropDatabase()
        {
            SqlCommand myCommand = new SqlCommand(clsSQLDataQuery.queryDropDataBase, myConnectionDatabaseSQL);
            executeQueryDB(myCommand);
        }

        /** работа со схемой  
         * схема состоит из 7 таблиц 
         * activeAircraft - действующий самолет
         * informationAircraft - информация о действующем самоелете
         * airport - аэропорт
         * runway - взлетная полоса в аэропорту
         * aircompany - авиакомпания
         * passenger - пассажир
         * clientAircompany - пассажир авиакомпаниии
         * **/
        
        // создание схемы
        static void createSchema()
        {
            for (int i = 0; i < clsSQLDataQuery.queryCreateTables.Length; i++)
            {
                SqlCommand myCommand = new SqlCommand(clsSQLDataQuery.queryCreateTables[i], myConnectionTableSQL);
                executeQueryTable(myCommand);
            }
        }
        
        // очистка содержимого таблиц
        static void clearSchema()
        {
            for (int i = 0; i < clsSQLDataQuery.queryDeleteTables.Length; i++)
            {
                SqlCommand myCommand = new SqlCommand(clsSQLDataQuery.queryDeleteTables[i], myConnectionTableSQL);
                try
                {
                    myConnectionTableSQL.Open();
                    myCommand.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (myConnectionTableSQL.State == ConnectionState.Open)
                    {
                        myConnectionTableSQL.Close();
                    }
                }
            }
        }
       
        // удаление схемы
        public static void dropSchema()
        {
            for (int i = 0; i < clsSQLDataQuery.queryDropTables.Length; i++)
            {
                SqlCommand myCommand = new SqlCommand(clsSQLDataQuery.queryDropTables[i], myConnectionTableSQL);
                try
                {
                    myConnectionTableSQL.Open();
                    myCommand.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (myConnectionTableSQL.State == ConnectionState.Open)
                    {
                        myConnectionTableSQL.Close();
                    }
                }
            }
        }
        
        // вставка подготовленных данных
        static void insertDataInTable()
        {
            for (int i = 0; i < clsSQLDataQuery.queryInsertTables.Length; i++)
            {
                SqlCommand myCommand = new SqlCommand(clsSQLDataQuery.queryInsertTables[i], myConnectionTableSQL);
                executeQueryTable(myCommand);
            }
        }
        
        // вставка сгенерированных данных
        static void insertGenDataInTable()
        {
            int count_start = 1000000;
            for (int i = 0; i < clsSQLDataQuery.queryInsertGenerateTables.Length; i++)
            {
                Random random = new Random();

                for (int j = 0; j < count_start; j++)
                {
                    SqlCommand myCommand = new SqlCommand(clsSQLDataQuery.queryInsertGenerateTables[i], myConnectionTableSQL);
                    int id = j + 1;
                    switch (i) {
                        case 0:
                        {
                            clsAircraft aircraft = clsAircraft.randomAircraft(id, random);
                                //id_activeAircraft
                            myCommand.Parameters.AddWithValue("@id_activeAircraft", aircraft.Id_activeAircraft.ToString());
                            myCommand.Parameters.AddWithValue("@active_label", aircraft.Active_label.ToString());
                            myCommand.Parameters.AddWithValue("@departure_airport", aircraft.Departure_airport.ToString());
                            myCommand.Parameters.AddWithValue("@arrival_airport", aircraft.Arrival_airport.ToString());
                            Console.WriteLine("aircraft #"+j);
                        };
                            break;
                        case 1:
                            {
                                if (j % 1000 == 0)
                                {
                                    clsInfoAircraft infoAircraft = clsInfoAircraft.randomInfoAicraft(id, random);
                                    myCommand.Parameters.AddWithValue("@id_informationAircraft", infoAircraft.Id_info.ToString());
                                    myCommand.Parameters.AddWithValue("@company_aircraft", infoAircraft.Company_aircraft.ToString());
                                    myCommand.Parameters.AddWithValue("@model_aircraft", infoAircraft.Model_aircraft.ToString());
                                    myCommand.Parameters.AddWithValue("@count_seats", infoAircraft.Count_seats.ToString());
                                    myCommand.Parameters.AddWithValue("@class_aircraft", infoAircraft.Class_aircraft.ToString());
                                    myCommand.Parameters.AddWithValue("@start_operation", infoAircraft.Start_operation.ToString());
                                    myCommand.Parameters.AddWithValue("@end_operation", infoAircraft.End_operation.ToString());
                                    Console.WriteLine("infoAircraft #" + j);
                                }
                            };
                            break;
                        case 2:
                        {
                            clsAirport airport = clsAirport.randomAirport(id, random);
                            myCommand.Parameters.AddWithValue("@id_airport", airport.Id_airport.ToString());
                            myCommand.Parameters.AddWithValue("@dislocation", airport.Dislocation.ToString());
                            myCommand.Parameters.AddWithValue("@name_airport", airport.Name_airport.ToString());
                            myCommand.Parameters.AddWithValue("@count_runway", airport.Count_runway.ToString());
                            Console.WriteLine("airport #" + j);
                            };
                            break;
                        case 3:
                            {
                                if (j % 1000 == 0)
                                {
                                    clsRunway runway = clsRunway.randomRunway(id, random, count_start);
                                    myCommand.Parameters.AddWithValue("@id_runway", runway.Id_run.ToString());
                                    myCommand.Parameters.AddWithValue("@length_runway", runway.Length_runway.ToString());
                                    myCommand.Parameters.AddWithValue("@width_runway", runway.Width_runway.ToString());
                                    myCommand.Parameters.AddWithValue("@active_label", runway.Active_label.ToString());
                                    myCommand.Parameters.AddWithValue("@class_runway", runway.Class_runway.ToString());
                                    myCommand.Parameters.AddWithValue("@id_airport", runway.Id_airport.ToString());
                                    Console.WriteLine("runway #" + j);
                                }
                            };
                            break;
                        case 4:
                        {
                            clsAircompany aircompany = clsAircompany.randomAircompany(id, random);
                            myCommand.Parameters.AddWithValue("@id_aircompany", aircompany.Id_aircompany.ToString());
                            myCommand.Parameters.AddWithValue("@name_aircompany", aircompany.Name_aircompany.ToString());
                            myCommand.Parameters.AddWithValue("@count_aircraft", aircompany.Count_aircraft.ToString());
                            myCommand.Parameters.AddWithValue("@mean_count_passenger", aircompany.Mean_count_passenger.ToString());
                            myCommand.Parameters.AddWithValue("@city_dislocation", aircompany.City_dislocation.ToString());
                            Console.WriteLine("aircompany #" + j);
                            };
                            break;
                        case 5:
                        {
                            clsPassenger passenger = clsPassenger.randomPassenger(random, id);                                
                            myCommand.Parameters.AddWithValue("@id_passenger", passenger.Id_pass.ToString());
                            myCommand.Parameters.AddWithValue("@name_passenger", passenger.Name_passenger.ToString());
                            myCommand.Parameters.AddWithValue("@second_name_passenger", passenger.Second_name_passenger.ToString());
                            myCommand.Parameters.AddWithValue("@number_pasport", passenger.Number_pasport.ToString());
                            myCommand.Parameters.AddWithValue("@weight_baggage", passenger.Weight_baggage.ToString());
                            myCommand.Parameters.AddWithValue("@id_tickets", passenger.Id_tickets.ToString());
                            Console.WriteLine("passenger #" + j);
                            };
                            break;
                        case 6:
                            {
                                if (j % 1000 == 0)
                                {
                                    clsAirPass airpass = clsAirPass.randomAirPass(random, count_start);
                                    myCommand.Parameters.AddWithValue("@id_aircompany", airpass.Id_company.ToString());
                                    myCommand.Parameters.AddWithValue("@id_passenger", airpass.Id_pass.ToString());
                                    Console.WriteLine("airpass #" + j);
                                }
                            };
                            break;
                    }
                    executeQueryTable(myCommand);
                }
                Console.WriteLine("Table "+i+" is ready to work");
            }
        }

        // создание схемы с дефолтными данными
        public static void createWorkingScheme()
        {
            createDatabase();
            createSchema();
            insertDataInTable();
            Console.WriteLine("Database is ready to work");
        }

        // создание схемы со сгенерированными данными
        public static void generateWorkingScheme()
        {
            dropSchema();
            createDatabase();
            createSchema();
            insertGenDataInTable();
            Console.WriteLine("Database is ready to work");
        }
    }
}
