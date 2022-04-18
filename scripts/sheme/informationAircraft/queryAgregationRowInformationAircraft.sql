declare @company varchar(50) = '',
		@model varchar(50) = '';
select COUNT(distinct(air_base.dbo.informationAircraft.model_aircraft)) 
from air_base.dbo.informationAircraft
where air_base.dbo.informationAircraft.company_aircraft like @company
select max(air_base.dbo.informationAircraft.count_seats) 
from air_base.dbo.informationAircraft
where air_base.dbo.informationAircraft.company_aircraft like @company and air_base.dbo.informationAircraft.model_aircraft like @model
select min(air_base.dbo.informationAircraft.count_seats) 
from air_base.dbo.informationAircraft
where air_base.dbo.informationAircraft.company_aircraft like @company and air_base.dbo.informationAircraft.model_aircraft like @model
select avg(air_base.dbo.informationAircraft.count_seats) 
from air_base.dbo.informationAircraft
where air_base.dbo.informationAircraft.company_aircraft like @company and air_base.dbo.informationAircraft.model_aircraft like @model
select sum(air_base.dbo.informationAircraft.count_seats) 
from air_base.dbo.informationAircraft
where air_base.dbo.informationAircraft.company_aircraft like @company and air_base.dbo.informationAircraft.model_aircraft like @model