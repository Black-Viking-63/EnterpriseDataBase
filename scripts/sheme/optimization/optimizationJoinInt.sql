select *
from activeAircraft
join informationAircraft on id_activeAircraft = id_informationAircraft
where class_aircraft = 3
