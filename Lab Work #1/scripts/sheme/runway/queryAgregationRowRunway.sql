declare @class int = 0;
select MAX(air_base.dbo.runway.length_runway)
from air_base.dbo.runway
where air_base.dbo.runway.class_runway = @class
select MAX(air_base.dbo.runway.width_runway)
from air_base.dbo.runway
where air_base.dbo.runway.class_runway = @class