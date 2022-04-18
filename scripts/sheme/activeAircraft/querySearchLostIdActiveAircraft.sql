create procedure dbo.searchFreeIdActiveAircraft 
@id int output
as
select @id = (
				select distinct top(1) air_base.dbo.activeAircraft.id_activeAircraft+1 from air_base.dbo.activeAircraft
				where air_base.dbo.activeAircraft.id_activeAircraft+1 NOT IN (
													select distinct air_base.dbo.activeAircraft.id_activeAircraft
													from air_base.dbo.activeAircraft)
												  )
				from air_base.dbo.activeAircraft;
return @id;