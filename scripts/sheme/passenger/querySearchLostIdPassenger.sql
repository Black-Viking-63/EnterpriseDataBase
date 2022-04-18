create procedure dbo.searchFreeIdPassenger
@id int output
as
select @id = (
				select distinct top(1) air_base.dbo.passenger.id_passenger+1 from air_base.dbo.passenger
				where air_base.dbo.passenger.id_passenger+1 NOT IN ( select distinct air_base.dbo.passenger.id_passenger
											from air_base.dbo.passenger)
			 )
			 from air_base.dbo.passenger;
return @id;