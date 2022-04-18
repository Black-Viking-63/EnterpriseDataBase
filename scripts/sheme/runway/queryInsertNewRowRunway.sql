declare @id int
exec @id = dbo.searchFreeIdRunway @id output
insert into air_base.dbo.runway values(@id, 1588, 60, 'True', 3, 45);