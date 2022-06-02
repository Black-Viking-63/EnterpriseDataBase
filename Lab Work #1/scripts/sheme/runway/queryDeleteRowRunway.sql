delete from air_base.dbo.runway
--id
declare @id int = 0;
delete from air_base.dbo.runway where air_base.dbo.runway.id_runway = @id
delete from air_base.dbo.runway where air_base.dbo.runway.id_runway > @id
delete from air_base.dbo.runway where air_base.dbo.runway.id_runway < @id
delete from air_base.dbo.runway where air_base.dbo.runway.id_runway <= @id
delete from air_base.dbo.runway where air_base.dbo.runway.id_runway >= @id
--length_runway
declare @length_runway int = 0;
delete from air_base.dbo.runway where air_base.dbo.runway.length_runway = @length_runway
delete from air_base.dbo.runway where air_base.dbo.runway.length_runway > @length_runway
delete from air_base.dbo.runway where air_base.dbo.runway.length_runway < @length_runway
delete from air_base.dbo.runway where air_base.dbo.runway.length_runway <= @length_runway
delete from air_base.dbo.runway where air_base.dbo.runway.length_runway >= @length_runway
--width_runway
declare @width_runway int = 0;
delete from air_base.dbo.runway where air_base.dbo.runway.width_runway = @width_runway
delete from air_base.dbo.runway where air_base.dbo.runway.width_runway > @width_runway
delete from air_base.dbo.runway where air_base.dbo.runway.width_runway < @width_runway
delete from air_base.dbo.runway where air_base.dbo.runway.width_runway <= @width_runway
delete from air_base.dbo.runway where air_base.dbo.runway.width_runway >= @width_runway
--square
declare @square int = 0;
delete from air_base.dbo.runway where air_base.dbo.runway.width_runway*air_base.dbo.runway.length_runway = @square
delete from air_base.dbo.runway where air_base.dbo.runway.width_runway*air_base.dbo.runway.length_runway > @square
delete from air_base.dbo.runway where air_base.dbo.runway.width_runway*air_base.dbo.runway.length_runway < @square
delete from air_base.dbo.runway where air_base.dbo.runway.width_runway*air_base.dbo.runway.length_runway >= @square
delete from air_base.dbo.runway where air_base.dbo.runway.width_runway*air_base.dbo.runway.length_runway <= @square
--active_runway
declare @active_label varchar = '';
delete from air_base.dbo.runway where air_base.dbo.runway.active_label like @active_label;
delete from air_base.dbo.runway where air_base.dbo.runway.active_label not like @active_label;
--class
declare @class_runway int = 0;
delete from air_base.dbo.runway where air_base.dbo.runway.class_runway = @class_runway;
delete from air_base.dbo.runway where air_base.dbo.runway.class_runway > @class_runway;
delete from air_base.dbo.runway where air_base.dbo.runway.class_runway < @class_runway;
delete from air_base.dbo.runway where air_base.dbo.runway.class_runway >= @class_runway;
delete from air_base.dbo.runway where air_base.dbo.runway.class_runway <= @class_runway;
--id_airport
declare @id_airport int = 0;
delete from air_base.dbo.runway where air_base.dbo.runway.id_airport = @id_airport
delete from air_base.dbo.runway where air_base.dbo.runway.id_airport > @id_airport
delete from air_base.dbo.runway where air_base.dbo.runway.id_airport < @id_airport
delete from air_base.dbo.runway where air_base.dbo.runway.id_airport <= @id_airport
delete from air_base.dbo.runway where air_base.dbo.runway.id_airport >= @id_airport