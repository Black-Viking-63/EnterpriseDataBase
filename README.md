# Корпоративные базы данных

Данный репозиторий содержит решение лабораторной работы #1 по курсу "Корпоративные базы данных".

# Содержание

[Скрипты для работы с базой данных](https://github.com/Black-Viking-63/EnterpriseDataBase/tree/main/scripts)  
[Программа генерации данных для базы данных](https://github.com/Black-Viking-63/EnterpriseDataBase/tree/main/programm/ConsoleApp2)

# Описание ER-Модели
В качестве бизнес-модели была выбрана модель авиационных перевозок. Схема модели представлена на фото.    

![Screenshot](images/scheme.PNG)

# Описание сущностей ER-Модели
## Действующий самолет
<table>
    <thead>
        <tr>
            <th colspan =4>Active Aircraft</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>ScreenShot</td>
            <td>Название поля</td>
            <td>Тип данных</td>
            <td>Описание</td>
        </tr>
        <tr>
            <td rowspan=5>ScreenShot</td>
            <td>id_activeAircraft</td>
            <td>Type</td>
            <td>Row 0/2</td>
        </tr>
        <tr>
            <td>active_label</td>
            <td>Type</td>
            <td>Row 1/2</td>
        </tr>
        <tr>
            <td>departure_airport</td>
            <td>Type</td>
            <td>Row 2/2</td>
        </tr>
        <tr>
            <td>arrival_airport</td>
            <td>Type</td>
            <td>Row 3/2</td>
        </tr>       
    </tbody>
</table>


## Информация о самолете
<table>
    <thead>
        <tr>
            <th colspan =4>Infromation Aircraft</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>ScreenShot</td>
            <td>Название поля</td>
            <td>Тип даных</td>
            <td>Описание</td>
        </tr>
        <tr>
            <td rowspan=7>ScreenShot</td>
            <td>id_informationAircraft</td>
            <td>Type</td>
            <td>Row 0/2</td>
        </tr>
        <tr>
            <td>company_aircraft</td>
            <td>Type</td>
            <td>Row 1/2</td>
        </tr>
        <tr>
            <td>model_aircraft</td>
            <td>Type</td>
            <td>Row 2/2</td>
        </tr>
        <tr>
            <td>count_seats</td>
            <td>Type</td>
            <td>Row 3/2</td>
        </tr>      
        <tr>
            <td>class_aircraft</td>
            <td>Type</td>
            <td>Row 4/2</td>
        </tr> 
        <tr>
            <td>start_operation</td>
            <td>Type</td>
            <td>Row 5/2</td>
        </tr> 
        <tr>
            <td>end_operation</td>
            <td>Type</td>
            <td>Row 6/2</td>
        </tr> 
    </tbody>
</table>  


## Аэропорт
<table>
    <thead>
        <tr>
            <th colspan =4>Airport</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>ScreenShot</td>
            <td>Название поля</td>
            <td>Тип даных</td>
            <td>Описание</td>
        </tr>
        <tr>
            <td rowspan=5>ScreenShot</td>
            <td>id_airport</td>
            <td>Type</td>
            <td>Row 0/2</td>
        </tr>
        <tr>
            <td>dislocation</td>
            <td>Type</td>
            <td>Row 1/2</td>
        </tr>
        <tr>
            <td>name_airport</td>
            <td>Type</td>
            <td>Row 2/2</td>
        </tr>
        <tr>
            <td>class_airport</td>
            <td>Type</td>
            <td>Row 3/2</td>
        </tr>      
        <tr>
            <td>count_runway</td>
            <td>Type</td>
            <td>Row 4/2</td>
        </tr> 
    </tbody>
</table>  

## Взлетная полоса

<table>
    <thead>
        <tr>
            <th colspan =4>Runway</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>ScreenShot</td>
            <td>Название поля</td>
            <td>Тип даных</td>
            <td>Описание</td>
        </tr>
        <tr>
            <td rowspan=6>ScreenShot</td>
            <td>id_runway</td>
            <td>Type</td>
            <td>Row 0/2</td>
        </tr>
        <tr>
            <td>lenght_runway</td>
            <td>Type</td>
            <td>Row 1/2</td>
        </tr>
        <tr>
            <td>width_runway</td>
            <td>Type</td>
            <td>Row 2/2</td>
        </tr>
        <tr>
            <td>active_label</td>
            <td>Type</td>
            <td>Row 3/2</td>
        </tr>      
        <tr>
            <td>class_runway</td>
            <td>Type</td>
            <td>Row 4/2</td>
        </tr> 
        <tr>
            <td>id_airport</td>
            <td>Type</td>
            <td>Row 5/2</td>
        </tr> 
    </tbody>
</table>  

## Авиакомпания

<table>
    <thead>
        <tr>
            <th colspan =4>Aircompany</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>ScreenShot</td>
            <td>Название поля</td>
            <td>Тип даных</td>
            <td>Описание</td>
        </tr>
        <tr>
            <td rowspan=5>ScreenShot</td>
            <td>id_aircompany</td>
            <td>Type</td>
            <td>Row 0/2</td>
        </tr>
        <tr>
            <td>name_aircompany</td>
            <td>Type</td>
            <td>Row 1/2</td>
        </tr>
        <tr>
            <td>count_aircrfat</td>
            <td>Type</td>
            <td>Row 2/2</td>
        </tr>
        <tr>
            <td>mean_count_passenger</td>
            <td>Type</td>
            <td>Row 3/2</td>
        </tr>      
        <tr>
            <td>city_dislocation</td>
            <td>Type</td>
            <td>Row 4/2</td>
        </tr> 
    </tbody>
</table>  

## Passenger

<table>
    <thead>
        <tr>
            <th colspan =4>Passenger</th>            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>ScreenShot</td>
            <td>Название поля</td>
            <td>Тип даных</td>
            <td>Описание</td>
        </tr>
        <tr>
            <td rowspan=6>ScreenShot</td>
            <td>id_passenger</td>
            <td>Type</td>
            <td>Row 0/2</td>
        </tr>
        <tr>
            <td>second_name_passenger</td>
            <td>Type</td>
            <td>Row 1/2</td>
        </tr>
        <tr>
            <td>name_passenger</td>
            <td>Type</td>
            <td>Row 2/2</td>
        </tr>
        <tr>
            <td>number_passport</td>
            <td>Type</td>
            <td>Row 3/2</td>
        </tr>      
        <tr>
            <td>weight_baggage</td>
            <td>Type</td>
            <td>Row 4/2</td>
        </tr> 
                <tr>
            <td>id_tickets</td>
            <td>Type</td>
            <td>Row 5/2</td>
        </tr> 
    </tbody>
</table>  

# Связи сущностей

| Тип связи | Скриншот | Описание |
|:---:|:---:|:---:|
| 1-1 | ![Screenshot](images/1-1.PNG) | Данным типом связи,</br>связаны 2 сущности:</br>"действующий" самолет</br>и</br>информация об этом самолете,</br>поскольку не может быть</br>2-х абсолютно одинаковых самолетов. |
| 1-N | ![Screenshot](images/1-N.PNG) | Данным типом связи,</br>связаны 2 сущности:</br>аэропорт</br>и</br>взлетные полосы</br>поскольку аэропорт</br>может иметь как одну</br>так и несколько взлетных полос. | 
| N-M | ![Screenshot](images/N-N.PNG) | Данным типом связи, связаны 2 сущности,</br>через промежуточную третью:</br>авиакомпания и пассажир</br>связаны через</br>клиентов авиакомпаний.</br> Поскольку, пассажир</br>может быть зарегистрирован</br>не в одной авиакомпании, а авиакомпании</br>явно имеют более одного клиента(пассажира). |
