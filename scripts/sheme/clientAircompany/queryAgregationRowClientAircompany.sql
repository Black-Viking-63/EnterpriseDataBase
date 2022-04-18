declare @id int=0;
select SUM(COUNT(air_base.dbo.clientAircompany.id_passenger)) 
from air_base.dbo.clientAircompany
where air_base.dbo.clientAircompany.id_aircompany = @id