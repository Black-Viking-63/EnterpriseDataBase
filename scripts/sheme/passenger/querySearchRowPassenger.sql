declare 
  @StartRow int = 1, 
  @RowsPerPage int = 100000,
  @name varchar(50) = '',
  @second_name varchar(50) = '',
  @id int = 0,
  @weight int = 0;
-- ����� ��������� �� ����� � �������
while (select count(*) from air_base.dbo.passenger) >= @StartRow  
begin
    select
		air_base.dbo.passenger.id_passenger,
		air_base.dbo.passenger.second_name_passenger,
		air_base.dbo.passenger.name_passenger,
		air_base.dbo.passenger.number_pasport,
		air_base.dbo.passenger.weight_baggage,
		air_base.dbo.passenger.id_tickets
	from air_base.dbo.passenger
	where air_base.dbo.passenger.name_passenger like @name and air_base.dbo.passenger.second_name_passenger like @second_name
    order by air_base.dbo.passenger.id_passenger
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- ����� ���������� � ������������ ����� ������ 
while (select count(*) from air_base.dbo.passenger) >= @StartRow  
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