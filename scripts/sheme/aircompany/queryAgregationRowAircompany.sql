declare @name varchar(50) = '';
select SUM(air_base.dbo.aircompany.count_aircraft)
from air_base.dbo.aircompany
where air_base.dbo.aircompany.name_aircompany like @name
select max(air_base.dbo.aircompany.mean_count_passenger)
from air_base.dbo.aircompany
where air_base.dbo.aircompany.name_aircompany like @name