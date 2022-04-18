declare @company int = 2,
		@passenger int = 2;
if not exists(
	select * 
	from air_base.dbo.clientAircompany
	where air_base.dbo.clientAircompany.id_aircompany = @company and air_base.dbo.clientAircompany.id_passenger = @passenger)
	update air_base.dbo.clientAircompany set air_base.dbo.clientAircompany.id_passenger = @passenger where air_base.dbo.clientAircompany.id_aircompany = @company
else return;
if not exists(
	select * 
	from air_base.dbo.clientAircompany
	where air_base.dbo.clientAircompany.id_aircompany = @company and air_base.dbo.clientAircompany.id_passenger = @passenger)
	update air_base.dbo.clientAircompany set air_base.dbo.clientAircompany.id_aircompany = @company where air_base.dbo.clientAircompany.id_passenger = @passenger
else return;