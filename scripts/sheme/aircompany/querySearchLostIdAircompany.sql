create procedure dbo.searchFreeIdAircompany
@id int output
as
select @id = (
				select distinct top(1) air_base.dbo.aircompany.id_aircompany+1 from air_base.dbo.aircompany
				where air_base.dbo.aircompany.id_aircompany+1 NOT IN ( select distinct air_base.dbo.aircompany.id_aircompany
											from air_base.dbo.aircompany)
			 )
			 from air_base.dbo.aircompany;
return @id;