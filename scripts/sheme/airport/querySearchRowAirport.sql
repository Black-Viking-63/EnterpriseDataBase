declare 
  @StartRow int = 1, 
  @RowsPerPage int = 100000,
  @dislocation varchar = '',
  @name_airport varchar = '',
  @count_runway int = 0,
  @class_airport varchar = '';
-- поиск аэропорта по городу дислокации
while (select count(*) from air_base.dbo.airport) >= @StartRow  
begin
    select
		air_base.dbo.airport.id_airport,
		air_base.dbo.airport.dislocation,
		air_base.dbo.airport.name_airport,
		air_base.dbo.airport.class_airport,
		air_base.dbo.airport.count_runway
	from air_base.dbo.airport
	where air_base.dbo.airport.dislocation like @dislocation
	--where air_base.dbo.airport.dislocation not like @dislocation
    order by air_base.dbo.airport.id_airport
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- поиск аэропорта по имени
while (select count(*) from air_base.dbo.airport) >= @StartRow  
begin
    select
		air_base.dbo.airport.id_airport,
		air_base.dbo.airport.dislocation,
		air_base.dbo.airport.name_airport,
		air_base.dbo.airport.class_airport,
		air_base.dbo.airport.count_runway
	from air_base.dbo.airport
	where air_base.dbo.airport.name_airport like @name_airport
	--where air_base.dbo.airport.name_airport not like @name_airport
    order by air_base.dbo.airport.id_airport
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- поиск аэропорта по числу взлетных полос
while (select count(*) from air_base.dbo.airport) >= @StartRow  
begin
    select
		air_base.dbo.airport.id_airport,
		air_base.dbo.airport.dislocation,
		air_base.dbo.airport.name_airport,
		air_base.dbo.airport.class_airport,
		air_base.dbo.airport.count_runway
	from air_base.dbo.airport
	where air_base.dbo.airport.count_runway = @count_runway
	--where air_base.dbo.airport.count_runway > @count_runway
	--where air_base.dbo.airport.count_runway < @count_runway
	--where air_base.dbo.airport.count_runway >= @count_runway
	--where air_base.dbo.airport.count_runway <= @count_runway
    order by air_base.dbo.airport.id_airport
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- поиск аэропорта по классу
while (select count(*) from air_base.dbo.airport) >= @StartRow  
begin
    select
		air_base.dbo.airport.id_airport,
		air_base.dbo.airport.dislocation,
		air_base.dbo.airport.name_airport,
		air_base.dbo.airport.class_airport,
		air_base.dbo.airport.count_runway
	from air_base.dbo.airport
	where air_base.dbo.airport.class_airport like @class_airport
	--where air_base.dbo.airport.class_airport not like @class_airport
    order by air_base.dbo.airport.id_airport
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;