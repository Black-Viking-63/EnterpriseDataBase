create procedure dbo.searchFreeIdAirport
@id int output
as
select @id = (
				select distinct top(1) air_base.dbo.airport.id_airport+1 from air_base.dbo.airport
				where air_base.dbo.airport.id_airport+1 NOT IN ( select distinct air_base.dbo.airport.id_airport
											from air_base.dbo.airport)
			 )
			 from air_base.dbo.airport;
return @id;