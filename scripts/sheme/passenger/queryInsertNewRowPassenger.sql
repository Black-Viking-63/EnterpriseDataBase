declare @id int
exec @id = dbo.searchFreeIdPassenger @id output
insert into air_base.dbo.passenger values(@id, 'Владимир', 'Макаров',  1000000+@id, 18, 10000000+@id);
