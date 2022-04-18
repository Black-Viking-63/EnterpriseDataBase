bulk insert air_base.dbo.activeAircraft
from 'F:\DATA\small0.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.informationAircraft
from 'F:\DATA\small1.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.airport
from 'F:\DATA\small2.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.runway
from 'F:\DATA\small3.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.aircompany
from 'F:\DATA\small4.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.passenger
from 'F:\DATA\small5.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.clientAircompany
from 'F:\DATA\small6.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );