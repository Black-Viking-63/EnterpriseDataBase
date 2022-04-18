declare @active_label varchar(50) = 'True';
declare @class_runway int = 1;
declare @square_runway int = 35000;
declare @id int = 0;
declare @lenght int = 0;
declare @width int = 0;
-- обновление поля активночти по классу полосы
update air_base.dbo.runway
set air_base.dbo.runway.active_label = @active_label
where air_base.dbo.runway.class_runway <= @class_runway
-- обновление поля класса полосы по площади полосы
update air_base.dbo.runway
set air_base.dbo.runway.class_runway = @class_runway
where air_base.dbo.runway.length_runway*air_base.dbo.runway.width_runway < @square_runway
--обновление длины полосы по id
update air_base.dbo.runway
set air_base.dbo.runway.length_runway = @lenght
where air_base.dbo.runway.id_runway = @id
--обновление ширины полосы по id
update air_base.dbo.runway
set air_base.dbo.runway.width_runway = @width
where air_base.dbo.runway.id_runway = @id