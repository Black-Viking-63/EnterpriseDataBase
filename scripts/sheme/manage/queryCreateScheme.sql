create table air_base.dbo.activeAircraft( 
	id_activeAircraft int primary key,
	active_label varchar(5) not null,
	departure_airport varchar(50),
	arrival_airport varchar(50)
);    
create table air_base.dbo.informationAircraft(
	id_informationAircraft int  primary key,
	company_aircraft varchar(50) not null,
	model_aircraft varchar(50) not null,
	count_seats int check(count_seats > 0 and count_seats < 880) not null,
	class_aircraft varchar(30) not null,
	start_operation Date,
	end_operation Date,
	constraint fk_aircraft_num foreign key (id_informationAircraft) references activeAircraft(id_activeAircraft) on delete cascade on update cascade
);
create table air_base.dbo.airport(
	id_airport int  primary key,
	dislocation varchar(30) not null,
	name_airport varchar(50) not null,
	class_airport varchar(50) not null,
	count_runway int check(count_runway>=0 and count_runway<=10) not null
);
create table air_base.dbo.runway(
	id_runway int  primary key,
	length_runway int check(length_runway>=300 and length_runway<=5500) not null,
	width_runway int check(width_runway>=10 and width_runway<=105) not null,
	active_label varchar(5) not null,
	class_runway int check(class_runway>0 and class_runway<7) not null,
	id_airport int foreign key references airport(id_airport) on delete cascade on update cascade
);
create table air_base.dbo.aircompany(
	id_aircompany int  primary key,
	name_aircompany varchar(50) not null,
	count_aircraft int check(count_aircraft>0 and count_aircraft<=1000) not null,
	mean_count_passenger int check(mean_count_passenger>0) not null,
	city_dislocation varchar(50) not null
);
create table air_base.dbo.passenger(
	id_passenger int  primary key,
	second_name_passenger varchar(30) not null,
	name_passenger varchar(30) not null,
	number_pasport int unique check(number_pasport>=1000000 and number_pasport<=9999999) not null,
	weight_baggage int check(weight_baggage>0 and weight_baggage<=25) not null,
	id_tickets int unique check(id_tickets >= 10000000 and id_tickets <= 99999999)
);
create table air_base.dbo.clientAircompany(
	id_aircompany int foreign key references aircompany(id_aircompany) on delete cascade on update cascade, 
	id_passenger int foreign key references passenger(id_passenger) on delete cascade on update cascade, 
	primary key(id_aircompany, id_passenger)
);