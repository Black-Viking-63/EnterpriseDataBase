--Полная очистка
delete from air_base.dbo.activeAircraft;
--id_activeAircraft
declare @id int = 0;
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.id_activeAircraft = @id;
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.id_activeAircraft > @id;
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.id_activeAircraft < @id;
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.id_activeAircraft >= @id;
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.id_activeAircraft <= @id;
--active_label
declare @active_label varchar(50) = '';
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.active_label like @active_label;
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.active_label not like @active_label;
--departure_airport
declare @departure_airport varchar(50) = '';
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.departure_airport like @departure_airport;
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.departure_airport not like @departure_airport;
--arrival_airport
declare @arrival_airport varchar(50) = '';
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.arrival_airport like @arrival_airport;
delete from air_base.dbo.activeAircraft where air_base.dbo.activeAircraft.arrival_airport not like @arrival_airport;