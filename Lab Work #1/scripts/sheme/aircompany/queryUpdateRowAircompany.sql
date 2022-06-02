declare @name varchar(50) = 'S7_Airlines';
declare @city varchar(50) = '';
declare @id int = 0;
declare @count int = 555;
declare @mean_count int = 0;
-- обновление имени авиакомпании
update air_base.dbo.aircompany
set air_base.dbo.aircompany.name_aircompany = @name
where air_base.dbo.aircompany.id_aircompany = @id;
-- обновление числа самоелетов
update air_base.dbo.aircompany 
set air_base.dbo.aircompany.count_aircraft = @count 
where air_base.dbo.aircompany.name_aircompany like @name;
--обновление числа пассажиров
update air_base.dbo.aircompany 
set air_base.dbo.aircompany.mean_count_passenger = @mean_count 
where air_base.dbo.aircompany.name_aircompany like @name;
-- обновление города дислокации
update air_base.dbo.aircompany 
set air_base.dbo.aircompany.city_dislocation = @city 
where air_base.dbo.aircompany.name_aircompany like @name;