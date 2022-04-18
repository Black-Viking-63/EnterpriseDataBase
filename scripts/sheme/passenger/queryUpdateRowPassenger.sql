declare @name varchar(50) = '';
declare @second_name varchar(50) = '';
declare @id int = 0;
declare @weight int = 0;
-- обновление поля багажа по имени и фамили пассажира
update air_base.dbo.passenger
set air_base.dbo.passenger.weight_baggage = @weight
where air_base.dbo.passenger.name_passenger like @name and air_base.dbo.passenger.second_name_passenger like @second_name
-- обновление имени по id
update air_base.dbo.passenger
set air_base.dbo.passenger.name_passenger = @name
where air_base.dbo.passenger.id_passenger = @id
-- обновление фамилии по id
update air_base.dbo.passenger
set air_base.dbo.passenger.second_name_passenger = @second_name
where air_base.dbo.passenger.id_passenger = @id
-- обновление имени и фамилии по id
update air_base.dbo.passenger
set air_base.dbo.passenger.name_passenger = @name, air_base.dbo.passenger.second_name_passenger = @second_name
where air_base.dbo.passenger.id_passenger = @id