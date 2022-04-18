declare @id int = -1;
declare @departure_airport varchar(50) = '';
declare @arrival_airport varchar(50) = '';
declare @null_airport varchar(4) = 'NULL';
--обновление метки и аэропортов
update air_base.dbo.activeAircraft 
set air_base.dbo.activeAircraft.active_label = 'True',
	air_base.dbo.activeAircraft.departure_airport = @departure_airport,
	air_base.dbo.activeAircraft.arrival_airport = @arrival_airport
where id_activeAircraft = @id;
update air_base.dbo.activeAircraft 
set air_base.dbo.activeAircraft.active_label = 'False',
	air_base.dbo.activeAircraft.departure_airport = @null_airport,
	air_base.dbo.activeAircraft.arrival_airport = @null_airport
where air_base.dbo.activeAircraft.id_activeAircraft = @id;