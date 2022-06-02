declare @company int = 2,
		@passenger int = 2;
if not exists(
	select * 
	from air_base.dbo.clientAircompany
	where air_base.dbo.clientAircompany.id_aircompany = @company and air_base.dbo.clientAircompany.id_passenger = @passenger)
	insert into air_base.dbo.clientAircompany values(@company, @passenger);
else return;