select COUNT(air_base.dbo.activeAircraft.active_label) 
from air_base.dbo.activeAircraft
where air_base.dbo.activeAircraft.active_label like 'True' -- True or False
select COUNT(air_base.dbo.activeAircraft.arrival_airport) 
from air_base.dbo.activeAircraft
where air_base.dbo.activeAircraft.arrival_airport like 'Самара' -- город отправления 
select COUNT(air_base.dbo.activeAircraft.departure_airport) 
from air_base.dbo.activeAircraft
where air_base.dbo.activeAircraft.departure_airport like 'Москва' -- город прибытия
