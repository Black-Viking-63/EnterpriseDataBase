﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBase.Classes.Models
{
    public static class clsData
    {
        public static bool[] labels = { false, false, false, false, true, true, true, true };
        public static string[] airports = {
            "Абакан", "Анадырь", "Анапа", "Архангельск", "Астрахань", "Барнаул", "Белгород", "Благовещенск", "Братск", "Брянск",
            "Варандей", "Владивосток", "Владикавказ", "Волгоград", "Воронеж", "Грозный", "Екатеринбург", "Жуковский", "Иркутск",
            "Казань", "Калининград", "Калуга", "Кемерово", "Краснодар", "Красноярск", "Курган", "Курск", "Липецк", "Магадан", "Магнитогорск",
            "Махачкала", "Минеральные_Воды", "Москва", "Москва", "Мурманск", "Нальчик", "Нижневартовск", "Нижнекамск", "Нижний_Новгород",
            "Новокузнецк", "Новосибирск", "Омск", "Оренбург", "Орск", "Остафьево", "Пермь", "Петрозаводск", "Петропавловск-Камчатский",
            "Псков", "Ростов-на-Дону", "Сабетта", "Самара", "Санкт-Петербург", "Саранск", "Саратов", "Симферополь", "Сочи", "Ставрополь",
            "Сургут", "Сыктывкар", "Томск", "Тюмень", "Улан-Удэ", "Ульяновск", "Уфа", "Хабаровск", "Ханты-Мансийск", "Чебоксары", "Челябинск",
            "Череповец", "Чита", "Элиста", "Южно-Сахалинск", "Якутск", "Ярославль"
        };

        public static string[] companies =
        {
            "Airbus", "ATR", "Saab_AB", "Антонов", "ОАК",
            "Сухой", "Иркут", "Туполев", "Ильюшин", "Boeing",
            "Douglas", "Bombardier", "Embraer"
        };
        public static string[] models =
        {
            "А220", "A300", "A310", "A318", "A319", "A320", "A321", "A330", "A340", "A350", "A380", "ATR_42", "ATR_72", "Saab_2000", "Saab_340",
            "Ан-2", "Ан-3", "Ан-4", "Ан-6", "Ан-8", "Ан-10", "Ан-12", "Ан-14", "Ан-22", "Ан-24", "Ан-26", "Ан-28", "Ан-30", "Ан-32", "Ан-34", "Ан-38", 
            "Ан-50", "Ан-70", "Ан-71", "Ан-72", "Ан-74", "Ан-124", "Ан-132",  "Ан-140", "Ан-148", "Ан-158", "Ан-168", "Ан-178", "Ан-180", "Ан-188", "Ан-218",
            "Ан-225", "Ан-318", "Ан-418", "Ил-96-300", "Ил-62М", "Ил-114", "Ту-160", "Ту-22М3", "Ту-95МС", "Ту-204", "Ту-214", "707", "717", "727",
            "737", "747", "757", "767", "777", "787", "Business_Jet", "B-52", "Chinook", "EA-18_Growler", "C-17", "YAL-1", "175", "EMB_110", 
            "EMB_120", "EMB_121", "ERJ_135", "ERJ_140", "ERJ_145", "E170", "E175", "E190", "E195", "E175-E2", "E190-E2", "E195-E2",
            "Legacy_600", "Lineage_1000", "Legacy_450", "Legacy_500", "Legacy_650", "Phenom_100", "Phenom_300", "Praetor_500","Praetor_600"
        };
        public static string[] classes_aircraft =
        {
            "Ближнемагистральный",
            "Среднемагистральный",
            "Дальнемагистральный"
        };

        public static string[] dislocations =
        {
            "Абакан", "Анадырь", "Анапа", "Архангельск", "Астрахань", "Барнаул", "Белгород", "Благовещенск", "Братск", "Брянск",
            "Варандей", "Владивосток", "Владикавказ", "Волгоград", "Воронеж", "Грозный", "Екатеринбург", "Жуковский", "Иркутск",
            "Казань", "Калининград", "Калуга", "Кемерово", "Краснодар", "Красноярск", "Курган", "Курск", "Липецк", "Магадан", "Магнитогорск",
            "Махачкала", "Минеральные_Воды", "Москва", "Москва", "Мурманск", "Нальчик", "Нижневартовск", "Нижнекамск", "Нижний_Новгород",
            "Новокузнецк", "Новосибирск", "Омск", "Оренбург", "Орск", "Остафьево", "Пермь", "Петрозаводск", "Петропавловск-Камчатский",
            "Псков", "Ростов-на-Дону", "Сабетта", "Самара", "Санкт-Петербург", "Саранск", "Саратов", "Симферополь", "Сочи", "Ставрополь",
            "Сургут", "Сыктывкар", "Томск", "Тюмень", "Улан-Удэ", "Ульяновск", "Уфа", "Хабаровск", "Ханты-Мансийск", "Чебоксары", "Челябинск",
            "Череповец", "Чита", "Элиста", "Южно-Сахалинск", "Якутск", "Ярославль"
        };
        public static string[] names_airports =
        {
            "Угольный", "Витязево", "Талаги", "Имени_Кустодиева", "Михайловка", "Имени_Шухова", "Игнатьево",
            "Кневичи", "Беслан", "Гумрак", "Имени_Петра_I", "Северный", "Кольцово", "Раменское", "Имени_Габдуллы_Тукая",
            "Храброво", "Грабцево", "Имени_Леонова", "Пашковский",  "Емельяново", "Восточный", "Сокол", "Уйташ",
            "Имени_Лермонтова", "Внуково","Домодедово", "Шереметьево", "Имени_Николая_II", "Бегишево", "Стригино",
            "Спиченково", "Толмачёво", "Центральный", "Большое_Савино", "Бесовец", "Елизово", "Кресты", "Платов", "Курумоч",
            "Пулково", "Гагарин", "Адлер", "Шпаковское", "Имени_Салманова", "Имени_Истомина", "Богашёво",
            "Рощино", "Мухино", "Баратаевка", "Восточный", "Имени_Мустая_Карима", "Новый", "Имени_Николаева",
            "Баландино", "Кадала", "Хомутово", "Имени_Платона_Ойунского", "Туношна"

        };
        public static string[] types_airport = { "Международный", "Областной", "Окружной", "Военный", "Гражданский"};

        public static int[] lenghts = { 3200, 2600, 1800, 1300, 1000, 500 };
        public static int[] widths = { 60, 45, 42, 35, 28, 21 };
        public static int[] classes_airport = { 1, 2, 3, 4, 5, 6 };   
        
        public static string[] names_aircompanies =
        {
        "Aegean_Airlines", "Aer_Lingus", "Aeroflot", "Aeromexico", "Air_Astana", "Air_Canada", "Air_Europa", 
        "Air_France", "Air_India", "Air_Moldova", "Air_New_Zealand", "Air_Transat", "AirBaltic", "Alaska_Airlines",
        "Alitalia", "Allegiant_Air", "Alrosa", "American_Airlines", "Angara", "Aurora_Airlines", "Austrian",
        "Azimuth_Airlines", "Azur_Air", "British_Airways", "Brussels_Airlines", "Bulgaria_Air", "Cathay_Pacific",
        "China_Southern_Airlines", "Czech_Airlines", "Delta_AirLines", "EasyJet", "El_Al", "Emirates", "Etihad_Airways",
        "Finnair", "Fly_One", "Flydubai", "Frontier_Airlines", "Germanwings", "Hawaiian_Airlines", "I_Fly","Iberia",
        "IrAero", "Jet", "JetBlue", "Jetstar_Airways", "KLM", "Korean_air", "LOT", "Lufthansa", "Lufthansa_CityLine",
        "Montenegro_Airlines", "NordStar", "Nordwind_Airlines", "Norwegian_Air_Shuttle", "Pegas_Fly", "Pegasus_Airlines",
        "Qantas_Airways", "Qatar_Airways", "Red_Wings", "Royal_Flight", "RusLine", "Ryanair", "S7_Airlines", "Scoot_Airlines",
        "Singapore_Airlines", "SmartAvia", "Somon_Air", "Southwest_Airlines", "SriLankan_Airlines", "Swiss_Airlines", "Air_Portugal",
        "Thai_Airways", "Turkish_Airlines", "United_Airlines", "Ural_Airlines", "Utair", "Vietnam_Airlines", "Virgin_Atlantic",
        "Virgin_Australia", "Vueling", "WestJet", "WizzAir", "Авиакомпании_Европы", "Азербайджанские_авиалинии", "Белавиа",
        "Газпром_Авиа", "Международные_Авиалинии_Украины", "Победа", "Туркменские_авиалинии", "Узбекские_авиалинии", "Якутия",
        "Ямал",
        };

        public static string[] names_passengers = 
        {
        "Агнес", "Билли", "Большой", "Винченцо", "Вито", "Говард", "Громила", "Джо", "Джон", "Джоуи", "Жёлтый", "Луиджи", "Лука", "Малыш", "Мардж",
        "Марко", "Мартин", "Мишель", "Пепе", "Поли", "Прокурор", "Ральф", "Роберт", "Роберто", "Сальваторе", "Сара", "Серджио", "Сэм", "Томас",
        "Уильям", "Феличе", "Фрэнк", "Элис", "Эннио", "Лейтенант", "Виктор", "Лейтенат", "Сержант", "Капрал", "Имран", "Капитан", "Пол", "Халед",
        "Ясир", "Алехандро", "Борис", "Владимир", "ГариРоуч", "Джеймс", "Джозеф", "СаймонГоуст", "Генерал", "Алёна", "Андрей", "Василий",
        "ДерекФрост", "Юрий", "Антон", "Диего", "Дани", "Клара", "Хуан", "Камилла", "Филли", "Карлос", "Мигель", "Паоло", "Талия", "Пас", "Бембе",
        "Матиас", "Мария", "Доктор", "Елена", "Хорхе", "Мерседес", "Тереза", "Лоренцо", "Адмирал", "Шон", "Роза", "Хулио", "Лита", "Серхио", "Торговец",
        "Сталкер", "Бандит", "Наемник", "Диггер", "Майор", "Профессор", "Череп", "Каролина", "Макс", "Зигрун", "Аня", "Фергюс", "Артём", "Анна",
        "Святослав", "Сэмюэль", "Павел", "Чеслав", "Максим", "Валерий", "Луминара", "Бейл", "Ведж", "Джа-Джа", "Дарт", "Финисс", "Асажж", "Мейс",
        "Максимилиан", "Квинлан", "Ади", "Гален", "Нут", "Джедай", "Джабба", "Ян", "Мара", "Граф", "По", "Иден", "Мастер", "Коммандер", "Оби-Ван", "Ки-Ади",
        "Пло", "Клигг", "Оуэн", "Лана", "Лэндо", "Маз", "Мон", "Саваж", "Баррисс", "Падме", "Император", "Кайло", "Рей", "Магистр", "Аурра", "Хан", "Люк",
        "Энакин", "Шми", "Асока", "Грандмофф", "Шаак", "ГрандАдмирал", "Боба", "Джанго", "Кит", "Чуи", "Гарри", "Рональд", "Гермиона", "Джиневра", "Фред",
        "Перси", "Невилл", "Лаванда", "Оливер", "Кэти", "Ли", "Анджелина", "Кормак", "Колин", "Ромильда", "Драко", "Винсент", "Грегори", "Пэнси",
        "Маркус", "Полумна", "Чжоу", "Майкл", "Роджер", "Джастин", "Эрнест", "Захария", "Альбус", "Минерва", "Северус", "Рубеус", "Квиринус",
        "Златопуст", "Филиус", "Сибилла", "Гораций", "Аргус", "Поппи", "Помона", "Роланда", "Лили", "Сириус", "Римус", "Нимфадора", "Миссис",
        "Наземникус", "Аластор", "Билл", "Чарли", "Лорд", "Беллатриса", "Люциус", "Нарцисса", "Бартемиус", "Питер", "Регулус", "Стэн", "Игорь", "Фенрир",
        "Корбан", "Геральт"
        };
        public static string[] second_names_passengers = 
        {
        "Гилотти", "Бифф", "Стэн", "Риччи", "Скалетта", "Дэвис", "Морелло", "Барбаро", "Норман", "Сухарь", "Пит", "Марино", "Бертоне", "Тони",
        "Коллетти", "Лихтенберг", "Корлеоне", "Повар", "Ломбардо", "Уоткинс", "Автомеханик", "Кларк", "Взломщик", "Анджело", "Трапани", "Гейтс",
        "Пеппоне", "Сальери", "Васкес", "Захаев", "Гас", "Григгс", "Гриффин", "Мактавиш", "Прайс", "Комаров", "Макмиллан", "Николай", "Джексон",
        "аль-Асад", "аль-Фулани", "Рохас", "Воршевский", "Макаров", "Сандерсон", "Данн", "Рамирес", "Аллен", "Райли", "Скэркроу", "Шепард", "Воршевская",
        "Харков", "Жуков", "Вестбрук", "БывшийСпецназовец", "Трак", "Сандман", "Гринч", "Кастильо", "Гарсия", "Кортес", "Монтеро", "Барзага", "Дельгадо",
        "ДеЛаВега", "Бенавидес", "Дуарте", "Альварес", "Алонсо", "Маркесса", "Моралес", "Агилар", "Мартин", "Морено", "Кансеко", "Бенитес", "Маккей",
        "Пакете", "Велес", "Санчес", "Торрес", "Эстевес", "Бармен", "Бес", "Боров", "Волкодав", "Воронин", "Крот", "Кузнецов", "Круглов", "Сахаров",
        "Сидорович", "«Долг»", "Шустрый", "Меченый", "Бласковиц", "Бекер", "Хасс", "Энгель", "Олива", "Рид", "Чёрный", "Мельникова", "Мельников",
        "Тэйлор", "Ермак", "Морозов", "Корбут", "Москвин", "Логинов", "Акбар", "Андули", "Антиллес", "Бинкс", "Бейн", "Валорум", "Вейдер", "Вентресс",
        "Винду", "Вирс", "Вос", "Галлия", "Марек", "Ганрей", "Гривус", "Грогу", "Хатт", "Додонна", "Скайуокер", "Дуку", "Дэмерон", "Версио", "Йода",
        "Коди", "Рекс", "Кеноби", "Мунди", "Кун", "Ларс", "Амидала", "Калриссиан", "Каната", "Мол", "Мотма", "Органа", "Опресс", "Оффи", "Пиетт", "Палпатин",
        "Плэгас", "Реван", "Рен", "СайфоДиас", "Синг", "Соло", "Тано", "Таркин", "Ти", "Траун", "Фетт", "Фисто", "Чубакка", "Поттер", "Уизли", "Грейнджер",
        "Долгопупс", "Браун", "Вуд", "Белл", "Джордан", "Джонсон", "Маклагген", "Криви", "Вейн", "Малфой", "Крэбб", "Гойл", "Паркинсон", "Флинт",
        "Лавгуд", "Чанг", "Корнер", "Финч-Флетчли", "Смит", "Дамблдор", "Макгонагалл", "Снегг", "Хагрид", "Квиррелл", "Локонс", "Флитвик",
        "Трелони", "Слизнорт", "Филч", "Помфри", "Стебль", "Трюк", "Блэк", "Люпин", "Фигг", "Флетчер", "Грюм", "Волан-де-Морт", "Лестрейндж",
        "КраучМладший", "Петтигрю", "Шанпайк", "Каркаров", "Сивый", "Яксли", "Стоун", "Ведьмак"
        };
    }
}