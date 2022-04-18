--Полное удаление всех строк
delete from air_base.dbo.aircompany 
--[id_aircompany]
declare @id int = 0;
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.id_aircompany = @id
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.id_aircompany > @id
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.id_aircompany < @id
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.id_aircompany <= @id
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.id_aircompany >= @id
--[name_aircompany]
declare @name_aircompany varchar(50) = '';
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.name_aircompany like @name_aircompany;
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.name_aircompany not like @name_aircompany;
--[count_aircraft]
declare @count_aircraft int = 0;
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.count_aircraft = @count_aircraft
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.count_aircraft > @count_aircraft
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.count_aircraft < @count_aircraft
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.count_aircraft <= @count_aircraft
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.count_aircraft >= @count_aircraft
--[mean_count_passenger]
declare @mean_count_passenger int = 0;
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.mean_count_passenger = @mean_count_passenger
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.mean_count_passenger > @mean_count_passenger
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.mean_count_passenger < @mean_count_passenger
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.mean_count_passenger <= @mean_count_passenger
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.mean_count_passenger >= @mean_count_passenger
--[city_dislocation]
declare @city_dislocation varchar(50) = '';
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.city_dislocation like @city_dislocation;
delete from air_base.dbo.aircompany where air_base.dbo.aircompany.city_dislocation not like @city_dislocation;