declare 
  @StartRow int = 1, 
  @RowsPerPage int = 100000,
  @company int = 0,
  @passenger int = 0;
-- поиск записей по авиакомпании
while (select count(air_base.dbo.clientAircompany.id_aircompany) from air_base.dbo.clientAircompany
	where air_base.dbo.clientAircompany.id_aircompany = @company) >= @StartRow  
begin
    select
		air_base.dbo.clientAircompany.id_aircompany,
		air_base.dbo.clientAircompany.id_passenger
	from air_base.dbo.clientAircompany
	where air_base.dbo.clientAircompany.id_aircompany = @company
    order by air_base.dbo.clientAircompany.id_aircompany
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- найти все компании данного пассажира
while (select count(air_base.dbo.clientAircompany.id_aircompany) from air_base.dbo.clientAircompany 
	where air_base.dbo.clientAircompany.id_passenger = @passenger) >= @StartRow  
begin
    select
		air_base.dbo.clientAircompany.id_aircompany,
		air_base.dbo.clientAircompany.id_passenger
	from air_base.dbo.clientAircompany
	where air_base.dbo.clientAircompany.id_passenger = @passenger
    order by air_base.dbo.clientAircompany.id_aircompany
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;