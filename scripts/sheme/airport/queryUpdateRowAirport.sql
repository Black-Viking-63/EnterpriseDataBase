declare @count_runway  int = 0,
 @class_airport varchar(50) = 'Военный',
 @dislocation varchar(50) = '',
 @name varchar(50) = '',
 @id int = 0;
-- обновление числа полос по классу самолета
update air_base.dbo.airport
set air_base.dbo.airport.count_runway = @count_runway
where air_base.dbo.airport.class_airport like @class_airport
-- обновление класса самолета по имени и дислокации самоелета
update air_base.dbo.airport
set air_base.dbo.airport.class_airport = @class_airport
where air_base.dbo.airport.dislocation like @dislocation and air_base.dbo.airport.name_airport like @name
-- обновление класса самолета по id
update air_base.dbo.airport
set air_base.dbo.airport.class_airport = @class_airport
where air_base.dbo.airport.id_airport = @id
-- обновление имени аэропорта
update air_base.dbo.airport
set air_base.dbo.airport.name_airport = @name
where air_base.dbo.airport.id_airport = @id and air_base.dbo.airport.dislocation = @dislocation and air_base.dbo.airport.class_airport like @class_airport