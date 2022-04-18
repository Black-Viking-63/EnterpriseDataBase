declare @airport varchar(50) = '',
  @label varchar(5) ='True',
  @StartRow int = 1, 
  @RowsPerPage int = 100;
--Поиск аэропортов прилета
WHILE (SELECT COUNT(*) FROM air_base.dbo.activeAircraft) >= @StartRow  
BEGIN
    select 
		air_base.dbo.activeAircraft.id_activeAircraft,
		air_base.dbo.activeAircraft.active_label,
		air_base.dbo.activeAircraft.departure_airport
	from air_base.dbo.activeAircraft 
	where arrival_airport like @airport
    order by air_base.dbo.activeAircraft.id_activeAircraft   
        OFFSET @StartRow - 1 ROWS   
        FETCH NEXT @RowsPerPage ROWS ONLY;
SET @StartRow = @StartRow + @RowsPerPage;  
CONTINUE
END;
--Поиск аэропортов вылета
WHILE (SELECT COUNT(*) FROM air_base.dbo.activeAircraft) >= @StartRow  
BEGIN
    select 
		air_base.dbo.activeAircraft.id_activeAircraft,
		air_base.dbo.activeAircraft.active_label,
		air_base.dbo.activeAircraft.arrival_airport
	from air_base.dbo.activeAircraft where departure_airport like @airport
    order by air_base.dbo.activeAircraft.id_activeAircraft   
        OFFSET @StartRow - 1 ROWS   
        FETCH NEXT @RowsPerPage ROWS ONLY;
SET @StartRow = @StartRow + @RowsPerPage;  
CONTINUE
END;
--Поиск действующих самолетов
WHILE (SELECT COUNT(*) FROM air_base.dbo.activeAircraft) >= @StartRow  
BEGIN
    select 
		air_base.dbo.activeAircraft.id_activeAircraft,
		air_base.dbo.activeAircraft.departure_airport,
		air_base.dbo.activeAircraft.arrival_airport
	from air_base.dbo.activeAircraft where active_label like @label
    order by air_base.dbo.activeAircraft.id_activeAircraft   
        OFFSET @StartRow - 1 ROWS   
        FETCH NEXT @RowsPerPage ROWS ONLY;
SET @StartRow = @StartRow + @RowsPerPage;  
CONTINUE
END;