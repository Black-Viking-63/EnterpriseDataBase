select *
from activeAircraft, informationAircraft
where id_activeAircraft = id_informationAircraft and class_aircraft = 'Дальнемагистральный'
