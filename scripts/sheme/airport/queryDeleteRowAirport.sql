--Полное удаление всех строк
delete from air_base.dbo.airport
--id_airport 
declare @id int = 6;
delete from air_base.dbo.airport where air_base.dbo.airport.id_airport = @id
delete from air_base.dbo.airport where air_base.dbo.airport.id_airport > @id
delete from air_base.dbo.airport where air_base.dbo.airport.id_airport < @id
delete from air_base.dbo.airport where air_base.dbo.airport.id_airport <= @id
delete from air_base.dbo.airport where air_base.dbo.airport.id_airport >= @id
--dislocation
declare @dislocation varchar = '';
delete from air_base.dbo.airport where air_base.dbo.airport.dislocation like @dislocation;
delete from air_base.dbo.airport where air_base.dbo.airport.dislocation not like @dislocation;
--name_airport 
declare @name_airport varchar = '';
delete from air_base.dbo.airport where air_base.dbo.airport.name_airport like @name_airport;
delete from air_base.dbo.airport where air_base.dbo.airport.name_airport not like @name_airport;
--count_runway
declare @count_runway int = 6;
delete from air_base.dbo.airport where air_base.dbo.airport.count_runway = @count_runway
delete from air_base.dbo.airport where air_base.dbo.airport.count_runway > @count_runway
delete from air_base.dbo.airport where air_base.dbo.airport.count_runway < @count_runway
delete from air_base.dbo.airport where air_base.dbo.airport.count_runway <= @count_runway
delete from air_base.dbo.airport where air_base.dbo.airport.count_runway >= @count_runway
--class_airport 
declare @class_airport varchar = '';
delete from air_base.dbo.airport where air_base.dbo.airport.class_airport like @class_airport;
delete from air_base.dbo.airport where air_base.dbo.airport.class_airport not like @class_airport;