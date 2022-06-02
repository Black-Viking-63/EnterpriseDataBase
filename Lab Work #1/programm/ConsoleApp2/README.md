# Программа генерации данных
Данная программа составлена и написана на языке `C#`, для автоматической генерации случайных данных, которые в последующем будут использованы для работы с базой данных.

# Структура программы
## Классы-структуры
* [`clsAircraft.cs`](https://github.com/Black-Viking-63/EnterpriseDataBase/blob/main/programm/ConsoleApp2/ConsoleApp2/clsAircraft.cs) - класс описывающий, элемент таблицы `activeAircraft`
* [`clsInfoAircraft.cs`](https://github.com/Black-Viking-63/EnterpriseDataBase/blob/main/programm/ConsoleApp2/ConsoleApp2/clsInfoAircraft.cs) - класс описывающий, элемент таблицы `informationAircraft`
* [`clsAirport.cs`](https://github.com/Black-Viking-63/EnterpriseDataBase/blob/main/programm/ConsoleApp2/ConsoleApp2/clsAirport.cs) - класс описывающий, элемент таблицы `airport`
* [`clsRunway.cs`](https://github.com/Black-Viking-63/EnterpriseDataBase/blob/main/programm/ConsoleApp2/ConsoleApp2/clsRunway.cs) - класс описывающий, элемент таблицы `runway`
* [`clsAircompany.cs`](https://github.com/Black-Viking-63/EnterpriseDataBase/blob/main/programm/ConsoleApp2/ConsoleApp2/clsAircompany.cs) - класс описывающий, элемент таблицы `aircompany`
* [`clsPassenger.cs`](https://github.com/Black-Viking-63/EnterpriseDataBase/blob/main/programm/ConsoleApp2/ConsoleApp2/clsPassenger.cs) - класс описывающий, элемент таблицы `passenger`
* [`clsAirPass.cs`](https://github.com/Black-Viking-63/EnterpriseDataBase/blob/main/programm/ConsoleApp2/ConsoleApp2/clsAirPass.cs) - класс описывающий, элемент таблицы `clientAircompany`
## Класс данных
* [`clsData.cs`](https://github.com/Black-Viking-63/EnterpriseDataBase/blob/main/programm/ConsoleApp2/ConsoleApp2/clsData.cs) - класс, содержащий в себе различне данные, используемые для генерации данных
## Общий класс
* [`Program.cs`](https://github.com/Black-Viking-63/EnterpriseDataBase/blob/main/programm/ConsoleApp2/ConsoleApp2/Program.cs) - класс, содержащий в себе точку входа программы

# Генерация данных
Для генерации данных в каждом классе-структуре описан метод `random#` (где, # - имя класса-структуры). Данный метод возвращает экземпляр класса-структуры, который в последующем пишется в файл.

# Сохранение данных
Для корректного сохранения данных, и упрощения загрузки в базу данных реализован метод `toString`, который сохраняет данные в необходимом формате.
