bulk insert air_base.dbo.activeAircraft
from 'F:\DATA\big0.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.informationAircraft
from 'F:\DATA\big1.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.airport
from 'F:\DATA\big2.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.runway
from 'F:\DATA\big3.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.aircompany
from 'F:\DATA\big4.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.passenger
from 'F:\DATA\big5.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );
bulk insert air_base.dbo.clientAircompany
from 'F:\DATA\big6.txt'
    with
    (
	datafiletype = 'widechar',
    fieldterminator = ' ',
    rowterminator = '\n'
    );