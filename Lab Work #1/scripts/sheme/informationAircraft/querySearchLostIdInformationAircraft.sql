create procedure dbo.searchFreeIdInformationAircraft
as declare @id int
select @id = (
				select distinct top(1) air_base.dbo.informationAircraft.id_informationAircraft+1 from air_base.dbo.informationAircraft
				where air_base.dbo.informationAircraft.id_informationAircraft+1 NOT IN (
													select distinct air_base.dbo.informationAircraft.id_informationAircraft
													from air_base.dbo.informationAircraft)
												  )
				from air_base.dbo.informationAircraft;
return @id;
