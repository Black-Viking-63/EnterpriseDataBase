declare @company int = 0,
		@passenger int = 0;
delete from air_base.dbo.clientAircompany
delete from air_base.dbo.clientAircompany where air_base.dbo.clientAircompany.id_aircompany = @company
delete from air_base.dbo.clientAircompany where air_base.dbo.clientAircompany.id_passenger = @passenger