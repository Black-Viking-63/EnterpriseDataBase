declare 
  @StartRow int = 1, 
  @RowsPerPage int = 100000,
  @length_runway int = 0,
  @width_runway int = 0,
  @square int = 0,
  @active_label varchar = '',
  @class_runway int = 0,
  @id_airport int = 0;
-- ����� ������ �� ����� 
while (select count(*) from air_base.dbo.runway) >= @StartRow  
begin
    select
		air_base.dbo.runway.id_airport,
		air_base.dbo.runway.length_runway,
		air_base.dbo.runway.width_runway,
		air_base.dbo.runway.active_label,
		air_base.dbo.runway.class_runway,
		air_base.dbo.runway.id_airport
	from air_base.dbo.runway
	where air_base.dbo.runway.length_runway = @length_runway
	--where air_base.dbo.runway.length_runway > @length_runway
	--where air_base.dbo.runway.length_runway < @length_runway
	--where air_base.dbo.runway.length_runway <= @length_runway
	--where air_base.dbo.runway.length_runway >= @length_runway
    order by air_base.dbo.runway.id_runway
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- ����� ������ �� ������ 
while (select count(*) from air_base.dbo.runway) >= @StartRow  
begin
    select
		air_base.dbo.runway.id_airport,
		air_base.dbo.runway.length_runway,
		air_base.dbo.runway.width_runway,
		air_base.dbo.runway.active_label,
		air_base.dbo.runway.class_runway,
		air_base.dbo.runway.id_airport
	from air_base.dbo.runway
	where air_base.dbo.runway.width_runway = @width_runway
	--where air_base.dbo.runway.width_runway < @width_runway
	--where air_base.dbo.runway.width_runway > @width_runway
	--where air_base.dbo.runway.width_runway <= @width_runway
	--where air_base.dbo.runway.width_runway >= @width_runway
    order by air_base.dbo.runway.id_runway
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- ����� ������ �� �������
while (select count(*) from air_base.dbo.runway) >= @StartRow  
begin
    select
		air_base.dbo.runway.id_airport,
		air_base.dbo.runway.length_runway,
		air_base.dbo.runway.width_runway,
		air_base.dbo.runway.active_label,
		air_base.dbo.runway.class_runway,
		air_base.dbo.runway.id_airport
	from air_base.dbo.runway
	where air_base.dbo.runway.width_runway*air_base.dbo.runway.length_runway = @square
	--where air_base.dbo.runway.width_runway*air_base.dbo.runway.length_runway < @square
	--where air_base.dbo.runway.width_runway*air_base.dbo.runway.length_runway > @square
	--where air_base.dbo.runway.width_runway*air_base.dbo.runway.length_runway <= @square
	--where air_base.dbo.runway.width_runway*air_base.dbo.runway.length_runway >= @square
    order by air_base.dbo.runway.id_runway
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- ����� ������ �� �����
while (select count(*) from air_base.dbo.runway) >= @StartRow  
begin
    select
		air_base.dbo.runway.id_airport,
		air_base.dbo.runway.length_runway,
		air_base.dbo.runway.width_runway,
		air_base.dbo.runway.active_label,
		air_base.dbo.runway.class_runway,
		air_base.dbo.runway.id_airport
	from air_base.dbo.runway
	where air_base.dbo.runway.active_label like @active_label
	--where air_base.dbo.runway.active_label not like @active_label
    order by air_base.dbo.runway.id_runway
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- ����� ������ �� ������
while (select count(*) from air_base.dbo.runway) >= @StartRow  
begin
    select
		air_base.dbo.runway.id_airport,
		air_base.dbo.runway.length_runway,
		air_base.dbo.runway.width_runway,
		air_base.dbo.runway.active_label,
		air_base.dbo.runway.class_runway,
		air_base.dbo.runway.id_airport
	from air_base.dbo.runway
	where air_base.dbo.runway.class_runway = @class_runway
	--where air_base.dbo.runway.class_runway < @class_runway
	--where air_base.dbo.runway.class_runway > @class_runway
	--where air_base.dbo.runway.class_runway <= @class_runway
	--where air_base.dbo.runway.class_runway >= @class_runway
    order by air_base.dbo.runway.id_runway
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;
-- ����� ������ �� ���������
while (select count(*) from air_base.dbo.runway) >= @StartRow  
begin
    select
		air_base.dbo.runway.id_airport,
		air_base.dbo.runway.length_runway,
		air_base.dbo.runway.width_runway,
		air_base.dbo.runway.active_label,
		air_base.dbo.runway.class_runway,
		air_base.dbo.runway.id_airport
	from air_base.dbo.runway
	where air_base.dbo.runway.id_airport = @id_airport
	--where air_base.dbo.runway.id_airport > @id_airport
	--where air_base.dbo.runway.id_airport < @id_airport
	--where air_base.dbo.runway.id_airport <= @id_airport
	--where air_base.dbo.runway.id_airport >= @id_airport
    order by air_base.dbo.runway.id_runway
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;