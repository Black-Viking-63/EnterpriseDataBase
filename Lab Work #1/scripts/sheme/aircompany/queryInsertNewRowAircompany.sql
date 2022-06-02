declare @id int
exec @id = dbo.searchFreeIdAircompany @id output
insert into air_base.dbo.aircompany values(@id, 'Red_Wings', 230, 372443140, 'Самара');
