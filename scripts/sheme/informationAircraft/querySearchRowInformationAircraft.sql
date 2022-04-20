declare 
  @StartRow int = 1, 
  @RowsPerPage int = 100000,
  @model varchar(50) = '',
  @company varchar(50) = '', 
  @count_seats int = 0,
  @class_aircraft varchar(50) = '',
  @start_operation date = CONVERT (date, GETDATE()),
  @year_start int = 45,
  @end_operation date = CONVERT (date, GETDATE()),
  @year_end int = 10,
  @year_operation int = 40;
--поиск записей по модели самолета
while (select count(air_base.dbo.informationAircraft.id_informationAircraft) from air_base.dbo.informationAircraft
	where air_base.dbo.informationAircraft.model_aircraft like @model) >= @StartRow  
begin
    select 
		air_base.dbo.informationAircraft.id_informationAircraft,
		air_base.dbo.informationAircraft.company_aircraft,
		air_base.dbo.informationAircraft.count_seats,
		air_base.dbo.informationAircraft.class_aircraft,
		air_base.dbo.informationAircraft.start_operation,
		air_base.dbo.informationAircraft.end_operation
	from air_base.dbo.informationAircraft
	where air_base.dbo.informationAircraft.model_aircraft like @model
    order by air_base.dbo.informationAircraft.id_informationAircraft   
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
--поиск записей по компании производителю самолета
while (select count(air_base.dbo.informationAircraft.id_informationAircraft) from air_base.dbo.informationAircraft
	where air_base.dbo.informationAircraft.company_aircraft like @company) >= @StartRow  
begin
    select 
		air_base.dbo.informationAircraft.id_informationAircraft,
		air_base.dbo.informationAircraft.company_aircraft,
		air_base.dbo.informationAircraft.count_seats,
		air_base.dbo.informationAircraft.class_aircraft,
		air_base.dbo.informationAircraft.start_operation,
		air_base.dbo.informationAircraft.end_operation
	from air_base.dbo.informationAircraft
	where air_base.dbo.informationAircraft.company_aircraft like @company
    order by air_base.dbo.informationAircraft.id_informationAircraft   
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
--поиск записей одновременно по модели и прозводителю самолета
while (select count(air_base.dbo.informationAircraft.id_informationAircraft) from air_base.dbo.informationAircraft
	where air_base.dbo.informationAircraft.company_aircraft like @company and air_base.dbo.informationAircraft.model_aircraft like @model) >= @StartRow  
begin
    select 
		air_base.dbo.informationAircraft.id_informationAircraft,
		air_base.dbo.informationAircraft.company_aircraft,
		air_base.dbo.informationAircraft.count_seats,
		air_base.dbo.informationAircraft.class_aircraft,
		air_base.dbo.informationAircraft.start_operation,
		air_base.dbo.informationAircraft.end_operation
	from air_base.dbo.informationAircraft
	where air_base.dbo.informationAircraft.company_aircraft like @company and air_base.dbo.informationAircraft.model_aircraft like @model
    order by air_base.dbo.informationAircraft.id_informationAircraft   
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
--поиск записей по количеству мест в самолете
while (select count(air_base.dbo.informationAircraft.id_informationAircraft) from air_base.dbo.informationAircraft
	where air_base.dbo.informationAircraft.count_seats = @count_seats) >= @StartRow  
begin
    select 
		air_base.dbo.informationAircraft.id_informationAircraft,
		air_base.dbo.informationAircraft.company_aircraft,
		air_base.dbo.informationAircraft.count_seats,
		air_base.dbo.informationAircraft.class_aircraft,
		air_base.dbo.informationAircraft.start_operation,
		air_base.dbo.informationAircraft.end_operation
	from air_base.dbo.informationAircraft
	where air_base.dbo.informationAircraft.count_seats = @count_seats
    order by air_base.dbo.informationAircraft.id_informationAircraft   
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
--поиск записей по классу самолета
while (select count(air_base.dbo.informationAircraft.id_informationAircraft) from air_base.dbo.informationAircraft
	where air_base.dbo.informationAircraft.class_aircraft like @class_aircraft) >= @StartRow  
begin
    select 
		air_base.dbo.informationAircraft.id_informationAircraft,
		air_base.dbo.informationAircraft.company_aircraft,
		air_base.dbo.informationAircraft.count_seats,
		air_base.dbo.informationAircraft.class_aircraft,
		air_base.dbo.informationAircraft.start_operation,
		air_base.dbo.informationAircraft.end_operation
	from air_base.dbo.informationAircraft
	where air_base.dbo.informationAircraft.class_aircraft like @class_aircraft
    order by air_base.dbo.informationAircraft.id_informationAircraft   
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
--поиск записей по количеству лет, которые отлетал самолет
while (select count(air_base.dbo.informationAircraft.id_informationAircraft) from air_base.dbo.informationAircraft
	where datediff(year, air_base.dbo.informationAircraft.start_operation, @start_operation) > @year_start) >= @StartRow  
begin
    select 
		air_base.dbo.informationAircraft.id_informationAircraft,
		air_base.dbo.informationAircraft.company_aircraft,
		air_base.dbo.informationAircraft.count_seats,
		air_base.dbo.informationAircraft.class_aircraft,
		air_base.dbo.informationAircraft.start_operation,
		air_base.dbo.informationAircraft.end_operation
	from air_base.dbo.informationAircraft
	where datediff(year, air_base.dbo.informationAircraft.start_operation, @start_operation) > @year_start
	order by air_base.dbo.informationAircraft.id_informationAircraft   
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
--поиск записей по количеству лет, которые самолет может летать
while (select count(air_base.dbo.informationAircraft.id_informationAircraft) from air_base.dbo.informationAircraft
	where datediff(year, @end_operation, air_base.dbo.informationAircraft.end_operation) = @year_end) >= @StartRow  
begin
    select 
		air_base.dbo.informationAircraft.id_informationAircraft,
		air_base.dbo.informationAircraft.company_aircraft,
		air_base.dbo.informationAircraft.count_seats,
		air_base.dbo.informationAircraft.class_aircraft,
		air_base.dbo.informationAircraft.start_operation,
		air_base.dbo.informationAircraft.end_operation
	from air_base.dbo.informationAircraft
	where datediff(year, @end_operation, air_base.dbo.informationAircraft.end_operation) = @year_end
	order by air_base.dbo.informationAircraft.id_informationAircraft   
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
--поиск записей по ресурсу самолета
while (select count(air_base.dbo.informationAircraft.id_informationAircraft) from air_base.dbo.informationAircraft
	where datediff(year, air_base.dbo.informationAircraft.start_operation, air_base.dbo.informationAircraft.end_operation) = @year_operation) >= @StartRow  
begin
    select 
		air_base.dbo.informationAircraft.id_informationAircraft,
		air_base.dbo.informationAircraft.company_aircraft,
		air_base.dbo.informationAircraft.count_seats,
		air_base.dbo.informationAircraft.class_aircraft,
		air_base.dbo.informationAircraft.start_operation,
		air_base.dbo.informationAircraft.end_operation
	from air_base.dbo.informationAircraft
	where datediff(year, air_base.dbo.informationAircraft.start_operation, air_base.dbo.informationAircraft.end_operation) = @year_operation
	order by air_base.dbo.informationAircraft.id_informationAircraft   
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;