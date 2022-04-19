using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBase.Classes.SQL
{
    public static class clsSQLDataQuery
    {
        // для работа с базой данных
        public static string queryCreateDataBase = "if not exists(select * from sys.databases where name= 'AirDataBase') create database AirDataBase";
        public static string queryDropDataBase = "ALTER DATABASE AirDataBase SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE AirDataBase";
        public static string queryCheckExistsDataBase = "SELECT database_id FROM sys.databases WHERE Name = AirDataBase";


        // для работы с таблицами
        // запросы создания таблиц
        public static String[] queryCreateTables = {
            "if not exists(select * from sysobjects where name='activeAircraft' and xtype = 'U')" +
                " begin" +
                    " create table activeAircraft( " +
                        "id_activeAircraft int primary key," +
                        " active_label varchar(5) not null," +
                        " departure_airport varchar(50)," +
                        " arrival_airport varchar(50)" +
                    "); " +
                "end",
           
            "if not exists(select * from sysobjects where name='informationAircraft' and xtype = 'U')" +
                " begin" +
                    " create table informationAircraft(" +
                        " id_informationAircraft int primary key," +
                        " company_aircraft varchar(50) not null," +
                        " model_aircraft varchar(50) not null," +
                        " count_seats int check(count_seats > 0 and count_seats < 880) not null," +
                        " class_aircraft varchar(20) not null," +
                        " start_operation Date," +
                        " end_operation Date," +
                        " constraint fk_aircraft_num foreign key (id_informationAircraft) references activeAircraft(id_activeAircraft) on delete cascade on update cascade" +
                    ");" +
                " end",
           
            "if not exists(select * from sysobjects where name='airport' and xtype = 'U')" +
                " begin" +
                    " create table airport(" +
                        " id_airport int  primary key," +
                        " dislocation varchar(30) not null," +
                        " name_airport varchar(50) not null," +
                        " count_runway int check(count_runway>0 and count_runway<=10) not null" +
                    ");" +
                " end",
           
            "if not exists(select * from sysobjects where name='runway' and xtype = 'U')" +
                " begin" +
                    " create table runway(" +
                        " id_runway int  primary key," +
                        " length_runway int check(length_runway>=300 and length_runway<=5500) not null," +
                        " width_runway int check(width_runway>=10 and width_runway<=105) not null," +
                        " active_label varchar(5) not null," +
                        " class_runway int check(class_runway>0 and class_runway<7) not null," +
                        " id_airport int foreign key references airport(id_airport) on delete cascade on update cascade" +
                    ");" +
                " end",
            
            "if not exists(select * from sysobjects where name='aircompany' and xtype = 'U')" +
                " begin" +
                    " create table aircompany(" +
                        " id_aircompany int  primary key," +
                        " name_aircompany varchar(50) not null," +
                        " count_aircraft int check(count_aircraft>0 and count_aircraft<=1000) not null," +
                        " mean_count_passenger int check(mean_count_passenger>0) not null," +
                        " city_dislocation varchar(50) not null" +
                    ");" +
                " end",
            
            "if not exists(select * from sysobjects where name='passenger' and xtype = 'U')" +
                " begin" +
                " create table passenger(" +
                " id_passenger int  primary key," +
                " second_name_passenger varchar(30) not null," +
                " name_passenger varchar(30) not null," +
                " number_pasport int unique check(number_pasport>=1000000 and number_pasport<=9999999) not null," +
                " weight_baggage int check(weight_baggage>0 and weight_baggage<=25) not null," +
                " id_tickets int unique check(id_tickets >= 10000000 and id_tickets <= 99999999)); end",
            
            "if not exists(select * from sysobjects where name='clientAircompany' and xtype = 'U')" +
                " begin" +
                    " create table clientAircompany(" +
                        " id_aircompany int foreign key references aircompany(id_aircompany) on delete cascade on update cascade, " +
                        " id_passenger int foreign key references passenger(id_passenger) on delete cascade on update cascade, " +
                        " primary key(id_aircompany, id_passenger)" +
                    ");" +
                " end"
        };
        // запрос очистки таблиц
        public static String[] queryDeleteTables = {
            "delete from informationAircraft",
            "delete from activeAircraft",
            "delete from runway",
            "delete from airport",
            "delete from clientAircompany",
            "delete from aircompany",
            "delete from passenger"
        };
        // полное удаление таблиц
        public static String[] queryDropTables = {
            "drop table if exists informationAircraft",
            "drop table if exists activeAircraft",
            "drop table if exists runway",
            "drop table if exists airport",
            "drop table if exists clientAircompany",
            "drop table if exists aircompany",
            "drop table if exists passenger"
        };
        // запрос показа таблиц
        public static String[] querySelectTables =
        {
            "select" +
                " id_activeAircraft as id_номер_самолета," +
                " active_label as метка," +
                " departure_airport as аэропорт_отлета," +
                " arrival_airport as аэропорт_прилета" +
            " from AirDataBase.dbo.activeAircraft",

            "select" +
                " id_informationAircraft as id_номер_самолета," +
                " company_aircraft as производитель_самолета," +
                " model_aircraft as модель_самолета," +
                " count_seats as количество_мест," +
                " class_aircraft as класс_самолета," +
                " start_operation as начало_эксплуатации," +
                " end_operation as окончание_эксплуатации" +
            " from AirDataBase.dbo.informationAircraft",


            "select" +
                " id_airport as id_номер_аэропорта," +
                " dislocation as место_дислокации," +
                " name_airport as название_аэропорта," +
                " count_runway as число_взлетных_полос" +
            " from AirDataBase.dbo.airport",
            
            "select" +
                " id_runway as id_номер_полосы," +
                " length_runway as длина_полосы," +
                " width_runway as ширина_полосы," +
                " active_label as метка," +
                " class_runway as класс_полосы," +
                " id_airport as номер_аэропорта" +
            " from AirDataBase.dbo.runway",
           
            "select" +
                " id_aircompany as id_номер_авиакомпании," +
                " name_aircompany as имя_авиакомпании," +
                " count_aircraft as число_самолетов," +
                " mean_count_passenger as среднее_число_пассажиров," +
                " city_dislocation as город_дислокации" +
            " from AirDataBase.dbo.aircompany",
            
            "select" +
                " id_passenger as id_номер_пассажира," +
                " name_passenger as имя," +
                " second_name_passenger as фамилия," +
                " number_pasport as номер_паспорта," +
                " weight_baggage as вес_багажа," +
                " id_tickets as номер_билета" +
            " from AirDataBase.dbo.passenger",
            
            "select" +
                " id_aircompany as id_номер_авиакомпании," +
                " id_passenger as id_номер_пассажира" +
            " from AirDataBase.dbo.clientAircompany"
         };
        // запрос вставки информации
        public static String[] queryInsertTables =
        {
                // действующий самолет
            "insert into AirDataBase.dbo.activeAircraft(id_activeAircraft, active_label, departure_airport, arrival_airport) values(1, 'True', 'Москва','Самара')",
            "insert into AirDataBase.dbo.activeAircraft(id_activeAircraft, active_label, departure_airport, arrival_airport) values(2, 'True', 'Калининград','Владивосток')",
            "insert into AirDataBase.dbo.activeAircraft(id_activeAircraft, active_label, departure_airport, arrival_airport) values(3, 'False', null, null)",
            "insert into AirDataBase.dbo.activeAircraft(id_activeAircraft, active_label, departure_airport, arrival_airport) values(4, 'True', 'Санкт-Петербург','Новосибирск')",
            "insert into AirDataBase.dbo.activeAircraft(id_activeAircraft, active_label, departure_airport, arrival_airport) values(5, 'False', null, null)",
                // информация о самолете
            "insert into AirDataBase.dbo.informationAircraft(id_informationAircraft, company_aircraft, model_aircraft, count_seats, class_aircraft, start_operation, end_operation) values (1, 'Boeing', '717', 200, 'Ближнемагистральный', '1995-05-01', '2030-05-01')" ,
            "insert into AirDataBase.dbo.informationAircraft(id_informationAircraft, company_aircraft, model_aircraft, count_seats, class_aircraft, start_operation, end_operation) values (2, 'Airbus', 'А380', 520, 'Дальнемагистральный', '2000-10-01', '2025-10-01')",
            "insert into AirDataBase.dbo.informationAircraft(id_informationAircraft, company_aircraft, model_aircraft, count_seats, class_aircraft, start_operation, end_operation) values (3, 'Ил', '86', 320, 'Дальнемагистральный', '1960-12-11', '1999-12-11')",
            "insert into AirDataBase.dbo.informationAircraft(id_informationAircraft, company_aircraft, model_aircraft, count_seats, class_aircraft, start_operation, end_operation) values (4, 'Airbus', 'А340', 420, 'Среднемагистральный', '2000-12-01', '2023-12-01')",
            "insert into AirDataBase.dbo.informationAircraft(id_informationAircraft, company_aircraft, model_aircraft, count_seats, class_aircraft, start_operation, end_operation) values (5, 'Туполев', '134', 520, 'Среднемагистральный', '1966-07-29', '1989-12-31')",
                //заполнение информации об аэропортах
            "insert into AirDataBase.dbo.airport(id_airport, dislocation, name_airport, count_runway) values(1, 'Москва', 'Шереметьево', 4)",
            "insert into AirDataBase.dbo.airport(id_airport, dislocation, name_airport, count_runway) values(2, 'Самара', 'Курумоч', 3)",
            "insert into AirDataBase.dbo.airport(id_airport, dislocation, name_airport, count_runway) values(3, 'Санкт-Петербург', 'Пулково', 4)",
            "insert into AirDataBase.dbo.airport(id_airport, dislocation, name_airport, count_runway) values(4, 'Грозный', 'Имени Кадырова', 2)",
            "insert into AirDataBase.dbo.airport(id_airport, dislocation, name_airport, count_runway) values(5, 'Краснодар', 'Пашковский', 3)",
                // заполенение информации о полосах в аэропортах
            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) values(1, 4500, 100, 'True', 1, 1)",
            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) values(2, 5500, 95, 'True', 1, 1)",
            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) values(3, 2500, 75, 'True', 2, 2)",
            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) values(4, 1500, 80, 'False', 2, 2)",
            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) values(5, 5000, 105, 'True', 1, 3)",
            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) values(6, 4000, 100, 'True', 1, 3)",
            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) values(7, 3000, 85, 'True', 3, 4)",
            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) values(8, 2000, 90, 'False', 3, 4)",
            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) values(9, 3500, 95, 'True', 2, 5)",
            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) values(10, 4500, 70, 'False', 2, 5)",
                // заполнение таблицы об авиакомпаниях 
            "insert into AirDataBase.dbo.aircompany(id_aircompany, name_aircompany, count_aircraft, mean_count_passenger, city_dislocation) values(1, 'Аэрофлот', 550, 30000000, 'Москва') ",
            "insert into AirDataBase.dbo.aircompany(id_aircompany, name_aircompany, count_aircraft, mean_count_passenger, city_dislocation) values(2, 'Победа', 250, 10000000, 'Санкт-Петербург') ",
            "insert into AirDataBase.dbo.aircompany(id_aircompany, name_aircompany, count_aircraft, mean_count_passenger, city_dislocation) values(3, 'S7', 450, 20000000, 'Новосибирск') ",
            "insert into AirDataBase.dbo.aircompany(id_aircompany, name_aircompany, count_aircraft, mean_count_passenger, city_dislocation) values(4, 'Utair', 500, 22000000, 'Сургут')",
                // заполнение таблицы о пассажирах
            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets) values(1, 'Джон', 'Прайс', 1000001, 15, 10000000) ",
            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets) values(2, 'Джон', 'Мактавиш', 1000002, 15, 10000001) ",
            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets) values(3, 'Юрий', 'Спецназовец', 1000003, 15, 10000002) ",
            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets) values(4, 'Владимир', 'Макаров', 1000004, 20, 10000003) ",
            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets) values(5, 'Генерал', 'Шепард', 1000005, 10, 10000004) ",
            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets) values(6, 'Имран', 'Захаев', 1000006, 20, 10000005) ",
            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets) values(7, 'Капитан', 'Макмиллан', 1000007, 10, 10000006) ",
            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets) values(8, 'Николай', 'Комаров', 1000008, 15, 10000007) ",
            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets) values(9, 'Андрей', 'Харков', 1000009, 5, 10000008) ",
            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger,number_pasport, weight_baggage, id_tickets) values(10, 'Дерек', 'Вестбрук', 1000010, 10, 10000009) ",
                // заполнение связей пассажиров и компаний
            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) values(1 , 1) ",
            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) values(1 , 2) ",
            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) values(2 , 2) ",
            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) values(2 , 1) ",
            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) values(3 , 5) ",
            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) values(3 , 4) ",
            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) values(4 , 10) ",
            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) values(4 , 7) ",
            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) values(3 , 7) ",
            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) values(1 , 10) "
        };
        // запрос вставки сгенерированной информации
        public static String[] queryInsertGenerateTables =
        {
            "insert into AirDataBase.dbo.activeAircraft(id_activeAircraft, active_label, departure_airport, arrival_airport) " +
                "values(@id_activeAircraft, @active_label, @departure_airport, @arrival_airport)",

            "insert into AirDataBase.dbo.informationAircraft(id_informationAircraft, company_aircraft, model_aircraft, count_seats, class_aircraft, start_operation, end_operation) " +
                "values (@id_informationAircraft, @company_aircraft, @model_aircraft, @count_seats, @class_aircraft, @start_operation, @end_operation)" ,

            "insert into AirDataBase.dbo.airport(id_airport, dislocation, name_airport, count_runway) " +
                "values(@id_airport, @dislocation, @name_airport, @count_runway)",

            "insert into AirDataBase.dbo.runway(id_runway, length_runway, width_runway, active_label, class_runway, id_airport) " +
                "values(@id_runway, @length_runway, @width_runway, @active_label, @class_runway, @id_airport)",

            "insert into AirDataBase.dbo.aircompany(id_aircompany, name_aircompany, count_aircraft, mean_count_passenger, city_dislocation) " +
                "values(@id_aircompany, @name_aircompany, @count_aircraft, @mean_count_passenger, @city_dislocation)",

            "insert into AirDataBase.dbo.passenger(id_passenger, name_passenger, second_name_passenger, number_pasport, weight_baggage, id_tickets) " +
                "values(@id_passenger, @name_passenger, @second_name_passenger, @number_pasport, @weight_baggage, @id_tickets) ",

            "insert into AirDataBase.dbo.clientAircompany(id_aircompany, id_passenger) " +
                "values(@id_aircompany, @id_passenger) ",

        };

    }
}
