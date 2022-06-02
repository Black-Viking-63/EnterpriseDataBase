create procedure dbo.searchFreeIdRunway
@id int output
as
select @id = (
				select distinct top(1) air_base.dbo.runway.id_runway+1 from air_base.dbo.runway
				where air_base.dbo.runway.id_runway+1 NOT IN ( select distinct air_base.dbo.runway.id_runway
											from air_base.dbo.runway)
			 )
			 from air_base.dbo.runway;
return @id;