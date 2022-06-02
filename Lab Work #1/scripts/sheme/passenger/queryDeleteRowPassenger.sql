delete from air_base.dbo.passenger
--id_passenger
declare @id int = 0
delete from air_base.dbo.passenger where air_base.dbo.passenger.id_passenger = @id
delete from air_base.dbo.passenger where air_base.dbo.passenger.id_passenger > @id
delete from air_base.dbo.passenger where air_base.dbo.passenger.id_passenger < @id
delete from air_base.dbo.passenger where air_base.dbo.passenger.id_passenger <= @id
delete from air_base.dbo.passenger where air_base.dbo.passenger.id_passenger >= @id
--second_name_passenger
declare @second_name_passenger varchar(50) = '';
delete from air_base.dbo.passenger where air_base.dbo.passenger.second_name_passenger like @second_name_passenger
--name_passenger
declare @name_passenger varchar(50) = '';
delete from air_base.dbo.passenger where air_base.dbo.passenger.name_passenger like @name_passenger
--second_name_passenger and name_passenger
declare @second_name varchar(50) = '';
declare @name varchar(50) = '';
delete from air_base.dbo.passenger where (air_base.dbo.passenger.name_passenger like @name) and (air_base.dbo.passenger.second_name_passenger like @second_name)
delete from air_base.dbo.passenger where (air_base.dbo.passenger.name_passenger not like @name) and (air_base.dbo.passenger.second_name_passenger not like @second_name)
--number_pasport
declare @number_pasport int = 0
delete from air_base.dbo.passenger where air_base.dbo.passenger.number_pasport = @number_pasport
delete from air_base.dbo.passenger where air_base.dbo.passenger.number_pasport > @number_pasport
delete from air_base.dbo.passenger where air_base.dbo.passenger.number_pasport < @number_pasport
delete from air_base.dbo.passenger where air_base.dbo.passenger.number_pasport <= @number_pasport
delete from air_base.dbo.passenger where air_base.dbo.passenger.number_pasport >= @number_pasport
--weight_baggage
declare @weight_baggage int = 0
delete from air_base.dbo.passenger where air_base.dbo.passenger.weight_baggage = @weight_baggage
delete from air_base.dbo.passenger where air_base.dbo.passenger.weight_baggage > @weight_baggage
delete from air_base.dbo.passenger where air_base.dbo.passenger.weight_baggage < @weight_baggage
delete from air_base.dbo.passenger where air_base.dbo.passenger.weight_baggage <= @weight_baggage
delete from air_base.dbo.passenger where air_base.dbo.passenger.weight_baggage >= @weight_baggage
--id_tickets
declare @id_tickets int = 0
delete from air_base.dbo.passenger where air_base.dbo.passenger.id_tickets = @id_tickets
delete from air_base.dbo.passenger where air_base.dbo.passenger.id_tickets > @id_tickets
delete from air_base.dbo.passenger where air_base.dbo.passenger.id_tickets < @id_tickets
delete from air_base.dbo.passenger where air_base.dbo.passenger.id_tickets <= @id_tickets
delete from air_base.dbo.passenger where air_base.dbo.passenger.id_tickets >= @id_tickets