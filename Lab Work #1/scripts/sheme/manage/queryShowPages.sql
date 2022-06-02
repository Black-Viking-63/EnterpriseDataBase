declare 
  @StartRow int = 1, 
  @RowsPerPage int = 100000;
while (select count(*) from air_base.dbo.passenger) >= @StartRow  
begin
    select *  
    from air_base.dbo.passenger 
    order by air_base.dbo.passenger.id_passenger   
        offset @StartRow - 1 rows   
        fetch next @RowsPerPage rows only;
set @StartRow = @StartRow + @RowsPerPage;  
continue
end;