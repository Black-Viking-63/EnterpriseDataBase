declare @count_seats int = 300,
 @model_aircraft varchar(50) = '',
 @class_aircraft varchar(50) = 'Среднемагистральный',
 @date date = '',
 @end_operation date = CONVERT (date, GETDATE()),
 @year_end int = 10;
-- обновление числа мест в самолете по модели самолета
update air_base.dbo.informationAircraft
set air_base.dbo.informationAircraft.count_seats = @count_seats 
where air_base.dbo.informationAircraft.model_aircraft = @model_aircraft
-- обновление числа мест по классу самолета
update air_base.dbo.informationAircraft 
set air_base.dbo.informationAircraft.count_seats = @count_seats
where air_base.dbo.informationAircraft.class_aircraft = @class_aircraft
-- обновление класса самолета по количеству мест в самоелете
update air_base.dbo.informationAircraft
set air_base.dbo.informationAircraft.class_aircraft = @class_aircraft
where air_base.dbo.informationAircraft.count_seats = @count_seats
-- обновление даты вывода из эксплуатации
update air_base.dbo.informationAircraft
set air_base.dbo.informationAircraft.end_operation = @date
where datediff(year, @end_operation, air_base.dbo.informationAircraft.end_operation) < @year_end