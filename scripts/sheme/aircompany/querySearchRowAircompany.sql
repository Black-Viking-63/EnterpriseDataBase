declare 
  @StartRow int = 1, 
  @RowsPerPage int = 10000,
  @name_aircompany varchar(50) = '',
  @count_aircraft int = 0,
  @mean_count_passenger int = 0,
  @city_dislocation varchar(50) = 'Самара';
-- просмотр информации по имени компании
while (select count(air_base.dbo.aircompany.id_aircompany) from air_base.dbo.aircompany
	where air_base.dbo.aircompany.name_aircompany like @name_aircompany) >= @StartRow  
begin
    select
		air_base.dbo.aircompany.id_aircompany,
		air_base.dbo.aircompany.name_aircompany,
		air_base.dbo.aircompany.count_aircraft,
		air_base.dbo.aircompany.mean_count_passenger,
		air_base.dbo.aircompany.city_dislocation
	from air_base.dbo.aircompany
	where air_base.dbo.aircompany.name_aircompany like @name_aircompany
    order by air_base.dbo.aircompany.id_aircompany
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- просмотр компаний по количеству самолетов
while (select count(air_base.dbo.aircompany.id_aircompany) from air_base.dbo.aircompany
	where air_base.dbo.aircompany.count_aircraft = @count_aircraft) >= @StartRow  
begin
    select
		air_base.dbo.aircompany.id_aircompany,
		air_base.dbo.aircompany.name_aircompany,
		air_base.dbo.aircompany.count_aircraft,
		air_base.dbo.aircompany.mean_count_passenger,
		air_base.dbo.aircompany.city_dislocation
	from air_base.dbo.aircompany
	where air_base.dbo.aircompany.count_aircraft = @count_aircraft
    order by air_base.dbo.aircompany.id_aircompany
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- просмотр компаний по среднему количеству пассажиров
while (select count(air_base.dbo.aircompany.id_aircompany) from air_base.dbo.aircompany
	where air_base.dbo.aircompany.mean_count_passenger = @mean_count_passenger) >= @StartRow  
begin
    select
		air_base.dbo.aircompany.id_aircompany,
		air_base.dbo.aircompany.name_aircompany,
		air_base.dbo.aircompany.count_aircraft,
		air_base.dbo.aircompany.mean_count_passenger,
		air_base.dbo.aircompany.city_dislocation
	from air_base.dbo.aircompany
	where air_base.dbo.aircompany.mean_count_passenger = @mean_count_passenger
    order by air_base.dbo.aircompany.id_aircompany
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- просмотр компаний по городу дислокации
while (select count(air_base.dbo.aircompany.id_aircompany) from air_base.dbo.aircompany
	where air_base.dbo.aircompany.city_dislocation like @city_dislocation) >= @StartRow  
begin
    select
		air_base.dbo.aircompany.id_aircompany,
		air_base.dbo.aircompany.name_aircompany,
		air_base.dbo.aircompany.count_aircraft,
		air_base.dbo.aircompany.mean_count_passenger,
		air_base.dbo.aircompany.city_dislocation
	from air_base.dbo.aircompany
	where air_base.dbo.aircompany.city_dislocation like @city_dislocation
    order by air_base.dbo.aircompany.id_aircompany
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;