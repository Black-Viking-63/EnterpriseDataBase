# Структура папок
[Database](https://github.com/Black-Viking-63/EnterpriseDataBase/tree/main/Lab%20Work%20%231/scripts/database) - содержит скрипты для работы с самой базой данных  
[Scheme](https://github.com/Black-Viking-63/EnterpriseDataBase/tree/main/Lab%20Work%20%231/scripts/sheme) - содержит скрипты для работы со схемой базой данных (таблицами)

# Описание ER-Модели
В качестве бизнес-модели была выбрана модель авиационных перевозок. Схема модели представлена на фото.    

![Screenshot](images/scheme.PNG)

# Описание сущностей ER-Модели
## Действующий самолет
<table>
    <thead>
        <tr>
            <th colspan =5>Active Aircraft</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td align="center" valign="center">ScreenShot</td>
            <td align="center" valign="center">Название поля</td>
            <td align="center" valign="center">Тип данных</td>
            <td align="center" valign="center">Описание</td>
            <td align="center" valign="center">Ключ</td>
        </tr>
        <tr>
            <td rowspan=4> <img src="images/activeAircraft.PNG"/> </td>
            <td align="center" valign="center">id_activeAircraft</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является уникальным идентификатором,</br>который используется для однозначной</br>маркировки записей в таблице.</td>
            <td align="center" valign="center">Primary Key</td>
        </tr>
        <tr>
            <td align="center" valign="center">active_label</td>
            <td align="center" valign="center">bool</td>
            <td align="center" valign="center">Является маркером действительности самолета.</br> Если выбрано значение true, то самолет действителен</br>может летать, вследствии чего должен иметь</br>место вылета и место прилета. Если выбрано значение</br>false самолет считается не действительным и летать</br>не может, а в места вылета и прилета имеют значения NULL.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">departure_airport</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о месте вылета (город) самолета, в случае если он действителен.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">arrival_airport</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о месте прилета (город) самолета, в случае если он действителен.</td>
            <td align="center" valign="center"> --- </td>
        </tr>       
    </tbody>
</table>

## Информация о самолете
<table>
    <thead>
        <tr>
            <th colspan =5>Infromation Aircraft</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td align="center" valign="center">ScreenShot</td>
            <td align="center" valign="center">Название поля</td>
            <td align="center" valign="center">Тип даных</td>
            <td align="center" valign="center">Описание</td>
            <td align="center" valign="center">Ключ</td>
        </tr>
        <tr>
            <td rowspan=7><img src="images/informationAircraft.PNG"/> </td>
            <td align="center" valign="center">id_informationAircraft</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является уникальным идентификатором,</br>который используется для однозначной</br>маркировки записей в таблице.</td>
            <td align="center" valign="center">Primary Key</td>
        </tr>
        <tr>
            <td align="center" valign="center">company_aircraft</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, сожержащим информацию</br>о производителе самолета.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">model_aircraft</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о модели самолета.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">count_seats</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о количестве меств в самолете.</td>
            <td align="center" valign="center"> --- </td>
        </tr>      
        <tr>
            <td align="center" valign="center">class_aircraft</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о классе самолета.</td>
            <td align="center" valign="center"> --- </td>
        </tr> 
        <tr>
            <td align="center" valign="center">start_operation</td>
            <td align="center" valign="center">Date</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о дате начала эксплуатации самолета.</td>
            <td align="center" valign="center"> --- </td>
        </tr> 
        <tr>
            <td align="center" valign="center">end_operation</td>
            <td align="center" valign="center">Type</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о дате окончания эксплуатации самолета.</td>
            <td align="center" valign="center"> --- </td>
        </tr> 
    </tbody>
</table>  

## Аэропорт
<table>
    <thead>
        <tr>
            <th colspan =5>Airport</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td align="center" valign="center">ScreenShot</td>
            <td align="center" valign="center">Название поля</td>
            <td align="center" valign="center">Тип данных</td>
            <td align="center" valign="center">Описание</td>
            <td align="center" valign="center">Ключ</td>
        </tr>
        <tr>
            <td rowspan=5><img src="images/airport.PNG"/> </td>
            <td align="center" valign="center">id_airport</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является уникальным идентификатором,</br>который используется для однозначной</br>маркировки записей в таблице.</td>
            <td align="center" valign="center">Primary Key</td>
        </tr>
        <tr>
            <td align="center" valign="center">dislocation</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о городе дислокации аэропорта.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">name_airport</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о имени аэропорта.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">class_airport</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о типе/классе аэропорта.</td>
            <td align="center" valign="center"> --- </td>
        </tr>      
        <tr>
            <td align="center" valign="center">count_runway</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о количестве взлетных полос в аэропорту.</td>
            <td align="center" valign="center"> --- </td>
        </tr> 
    </tbody>
</table>  

## Взлетная полоса

<table>
    <thead>
        <tr>
            <th colspan =5>Runway</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td align="center" valign="center">ScreenShot</td>
            <td align="center" valign="center">Название поля</td>
            <td align="center" valign="center">Тип данных</td>
            <td align="center" valign="center">Описание</td>
            <td align="center" valign="center">Ключ</td>
        </tr>
        <tr>
            <td rowspan=6><img src="images/runway.PNG"/> </td>
            <td align="center" valign="center">id_runway</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является уникальным идентификатором,</br>который используется для однозначной</br>маркировки записей в таблице.</td>
            <td align="center" valign="center">Primary Key</td>
        </tr>
        <tr>
            <td align="center" valign="center">lenght_runway</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о длине взлетной полосы.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">width_runway</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о ширине взлетной полосы.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">active_label</td>
            <td align="center" valign="center">bool</td>
            <td align="center" valign="center">Является маркером действительности взлетной полосы.</br> Если выбрано значение true, то полоса доступна для работы,</br> иначе не доступна.</td>
            <td align="center" valign="center"> --- </td>
        </tr>      
        <tr>
            <td align="center" valign="center">class_runway</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о классе взлетной полосы.</td>
            <td align="center" valign="center"> --- </td>
        </tr> 
        <tr>
            <td align="center" valign="center">id_airport</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>об аэропорте в котоом находится взлетная полоса.</td>
            <td align="center" valign="center"> Foreign Key </td>
        </tr> 
    </tbody>
</table>  

## Авиакомпания

<table>
    <thead>
        <tr>
            <th colspan =5>Aircompany</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td align="center" valign="center">ScreenShot</td>
            <td align="center" valign="center">Название поля</td>
            <td align="center" valign="center">Тип данных</td>
            <td align="center" valign="center">Описание</td>
            <td align="center" valign="center">Ключ</td>
        </tr>
        <tr>
            <td rowspan=5><img src="images/aircompany.PNG"/> </td>
            <td align="center" valign="center">id_aircompany</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является уникальным идентификатором,</br>который используется для однозначной</br>маркировки записей в таблице.</td>
            <td align="center" valign="center">Primary Key</td>
        </tr>
        <tr>
            <td align="center" valign="center">name_aircompany</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о имени авиакомпании.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">count_aircrfat</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о количестве самолетов в компании</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">mean_count_passenger</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о среднем количестве пассаиров перевозимых компанией.</td>
            <td align="center" valign="center"> --- </td>
        </tr>      
        <tr>
            <td align="center" valign="center">city_dislocation</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о городе дислокации авиакомпании.</td>
            <td align="center" valign="center"> --- </td>
        </tr> 
    </tbody>
</table>  

## Passenger

<table>
    <thead>
        <tr>
            <th colspan =5>Passenger</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td align="center" valign="center">ScreenShot</td>
            <td align="center" valign="center">Название поля</td>
            <td align="center" valign="center">Тип данных</td>
            <td align="center" valign="center">Описание</td>
            <td align="center" valign="center">Ключ</td>
        </tr>
        <tr>
            <td rowspan=6><img src="images/passenger.PNG"/> </td>
            <td align="center" valign="center">id_passenger</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является уникальным идентификатором,</br>который используется для однозначной</br>маркировки записей в таблице.</td>
            <td align="center" valign="center">Primary Key</td>
       </tr>
        <tr>
            <td align="center" valign="center">second_name_passenger</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о фамилии пассажира.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">name_passenger</td>
            <td align="center" valign="center">VARCHAR()</br>String</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о имени пассажира.</td>
            <td align="center" valign="center"> --- </td>
        </tr>
        <tr>
            <td align="center" valign="center">number_passport</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о номере паспорта пассажира.</td>
            <td align="center" valign="center"> --- </td>
        </tr>      
        <tr>
            <td align="center" valign="center">weight_baggage</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о весе багажа пассажира.</td>
            <td align="center" valign="center"> --- </td>
        </tr> 
                <tr>
            <td align="center" valign="center">id_tickets</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является полем, содержащим информацию</br>о номере билета пассажира.</td>
            <td align="center" valign="center"> --- </td>
        </tr> 
    </tbody>
</table>  

## ClientAircompany

<table>
    <thead>
        <tr>
            <th colspan =5>ClientAircompany</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td align="center" valign="center">ScreenShot</td>
            <td align="center" valign="center">Название поля</td>
            <td align="center" valign="center">Тип данных</td>
            <td align="center" valign="center">Описание</td>
            <td align="center" valign="center">Ключ</td>
        </tr>
        <tr>
            <td rowspan=6> <img src="images/clientAircompany.PNG"/> </td>
            <td align="center" valign="center">id_aircompany</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является уникальным идентификатором,</br>который используется для установления</br> связи между записями в таблицах.</td>            
            <td align="center" valign="center">Primary Key</br>Foreign Key</td>
        </tr>
        <tr>
            <td align="center" valign="center">id_passenger</td>
            <td align="center" valign="center">int</td>
            <td align="center" valign="center">Является уникальным идентификатором,</br>который используется для установления</br> связи между записями в таблицах.
            </td>
            <td align="center" valign="center">Primary Key</br>Foreign Key</td>
        </tr>        
    </tbody>
</table>  

# Связи сущностей

| Тип связи | Скриншот | Описание |
|:---:|:---:|:---:|
| 1-1 | ![Screenshot](images/1-1.PNG) | Данным типом связи,</br>связаны 2 сущности:</br>"действующий" самолет</br>и</br>информация об этом самолете,</br>поскольку не может быть</br>2-х абсолютно одинаковых самолетов. |
| 1-N | ![Screenshot](images/1-N.PNG) | Данным типом связи,</br>связаны 2 сущности:</br>аэропорт</br>и</br>взлетные полосы</br>поскольку аэропорт</br>может иметь как одну</br>так и несколько взлетных полос. | 
| N-M | ![Screenshot](images/N-N.PNG) | Данным типом связи, связаны 2 сущности,</br>через промежуточную третью:</br>авиакомпания и пассажир</br>связаны через</br>клиентов авиакомпаний.</br> Поскольку, пассажир</br>может быть зарегистрирован</br>не в одной авиакомпании, а авиакомпании</br>явно имеют более одного клиента(пассажира). |
