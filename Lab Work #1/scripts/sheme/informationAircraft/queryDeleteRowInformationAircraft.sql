--Полное удаление
delete from air_base.dbo.informationAircraft
--id_informationAircraft
declare @id int = 0;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.id_informationAircraft = @id;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.id_informationAircraft > @id;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.id_informationAircraft < @id;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.id_informationAircraft >= @id;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.id_informationAircraft <= @id;
--company_aircraft
declare @company_aircraft varchar(50) = '';
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.company_aircraft like @company_aircraft;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.company_aircraft not like @company_aircraft;
--count_seats
declare @count_seats int = 0;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.count_seats= @count_seats;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.count_seats > @count_seats;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.count_seats < @count_seats;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.count_seats >= @count_seats;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.count_seats <= @count_seats;
--class_aircraft
declare @class_aircraft varchar(50) = '';
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.class_aircraft like @class_aircraft;
delete from air_base.dbo.informationAircraft where air_base.dbo.informationAircraft.class_aircraft not like @class_aircraft;
--start_operation
declare @start_operation date = CONVERT (date, GETDATE());
declare @year_start int = 15;
delete from air_base.dbo.informationAircraft where datediff(year, air_base.dbo.informationAircraft.start_operation, @start_operation) = @year_start
delete from air_base.dbo.informationAircraft where datediff(year, air_base.dbo.informationAircraft.start_operation, @start_operation) > @year_start
delete from air_base.dbo.informationAircraft where datediff(year, air_base.dbo.informationAircraft.start_operation, @start_operation) < @year_start
delete from air_base.dbo.informationAircraft where datediff(year, air_base.dbo.informationAircraft.start_operation, @start_operation) >= @year_start
delete from air_base.dbo.informationAircraft where datediff(year, air_base.dbo.informationAircraft.start_operation, @start_operation) >= @year_start
--end_operation
declare @end_operation date = CONVERT (date, GETDATE());
declare @year_end int = 10;
delete from air_base.dbo.informationAircraft where datediff(year, @end_operation, air_base.dbo.informationAircraft.end_operation) = @year_end
delete from air_base.dbo.informationAircraft where datediff(year, @end_operation, air_base.dbo.informationAircraft.end_operation) < @year_end
delete from air_base.dbo.informationAircraft where datediff(year, @end_operation, air_base.dbo.informationAircraft.end_operation) > @year_end
delete from air_base.dbo.informationAircraft where datediff(year, @end_operation, air_base.dbo.informationAircraft.end_operation) <= @year_end
delete from air_base.dbo.informationAircraft where datediff(year, @end_operation, air_base.dbo.informationAircraft.end_operation) <= @year_end
--time_operation
declare @year_operation int = 40;
delete from air_base.dbo.informationAircraft where datediff(year, air_base.dbo.informationAircraft.start_operation, air_base.dbo.informationAircraft.end_operation) = @year_operation
delete from air_base.dbo.informationAircraft where datediff(year, air_base.dbo.informationAircraft.start_operation, air_base.dbo.informationAircraft.end_operation) < @year_operation
delete from air_base.dbo.informationAircraft where datediff(year, air_base.dbo.informationAircraft.start_operation, air_base.dbo.informationAircraft.end_operation) > @year_operation
delete from air_base.dbo.informationAircraft where datediff(year, air_base.dbo.informationAircraft.start_operation, air_base.dbo.informationAircraft.end_operation) <= @year_operation
delete from air_base.dbo.informationAircraft where datediff(year, air_base.dbo.informationAircraft.start_operation, air_base.dbo.informationAircraft.end_operation) >= @year_operation