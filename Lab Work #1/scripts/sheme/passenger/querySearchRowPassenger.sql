declare 
  @StartRow int = 1, 
  @RowsPerPage int = 10000,
  @name varchar(50) = '',
  @second_name varchar(50) = '',
  @id int = 0,
  @weight int = 15;
---- поиск пассажира по имени и фамилии
--while (select count(air_base.dbo.passenger.id_passenger) from air_base.dbo.passenger
--	where air_base.dbo.passenger.name_passenger like @name and air_base.dbo.passenger.second_name_passenger like @second_name) >= @StartRow  
--begin
--    select
--		air_base.dbo.passenger.id_passenger,
--		air_base.dbo.passenger.second_name_passenger,
--		air_base.dbo.passenger.name_passenger,
--		air_base.dbo.passenger.number_pasport,
--		air_base.dbo.passenger.weight_baggage,
--		air_base.dbo.passenger.id_tickets
--	from air_base.dbo.passenger
--	where air_base.dbo.passenger.name_passenger like @name and air_base.dbo.passenger.second_name_passenger like @second_name
--    order by air_base.dbo.passenger.id_passenger
--        offset @StartRow - 1 rows   
--        fetch next @RowsPerPage rows only;
--set @StartRow = @StartRow + @RowsPerPage;  
--continue
--end;
---- поиск пассажиров с определенным весом багажа 
while (select count(air_base.dbo.passenger.id_passenger) from air_base.dbo.passenger
	where air_base.dbo.passenger.weight_baggage = @weight) >= @StartRow  
begin
    select
		air_base.dbo.passenger.id_passenger,
		air_base.dbo.passenger.second_name_passenger,
		air_base.dbo.passenger.name_passenger,
		air_base.dbo.passenger.number_pasport,
		air_base.dbo.passenger.weight_baggage,
		air_base.dbo.passenger.id_tickets
	from air_base.dbo.passenger
	where air_base.dbo.passenger.weight_baggage = @weight
    order by air_base.dbo.passenger.id_passenger
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;