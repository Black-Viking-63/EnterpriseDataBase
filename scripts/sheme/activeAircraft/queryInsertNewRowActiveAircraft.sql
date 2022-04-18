declare @id int
exec @id = dbo.searchFreeIdActiveAircraft @id output
insert into air_base.dbo.activeAircraft values(@id, 'True', 'Самара', 'Москва');