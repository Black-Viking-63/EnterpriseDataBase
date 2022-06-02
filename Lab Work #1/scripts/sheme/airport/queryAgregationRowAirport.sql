declare @name varchar(50)= '',
		@class varchar(50) = '';
select max(air_base.dbo.airport.count_runway) 
from air_base.dbo.airport
where air_base.dbo.airport.name_airport like @name and air_base.dbo.airport.class_airport like @class