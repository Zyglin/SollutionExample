USE Test

--соединения данных из двух таблиц применяется оператор JOIN
SELECT Orders.CreatedAt, Person.LastName 
FROM Orders
INNER JOIN Person ON Person.Id = Orders.PersonId

--Отличие от INNER JOIN внешнее соединение OUTER JOIN возвращает все строки одной или двух таблиц, которые участвуют в соединении.
--Перед оператором OUTER JOIN указывается одно из ключевых слов LEFT, RIGHT или FULL, которые определяют тип соединения:
--LEFT: выборка будет содержать все строки из первой или левой таблицы
--RIGHT: выборка будет содержать все строки из второй или правой таблицы
--FULL: выборка будет содержать все строки из обоих таблиц

SELECT  Person.LastName,Orders.CreatedAt
FROM Person
LEFT OUTER JOIN Orders ON Person.Id = Orders.PersonId 

SELECT  Person.LastName, Orders.CreatedAt
FROM Person
RIGHT OUTER JOIN Orders ON Orders.PersonId = Person.Id

SELECT  Person.LastName,Orders.CreatedAt
FROM Person
FULL OUTER JOIN Orders ON Orders.PersonId = Person.Id

SELECT * FROM Person
CROSS JOIN  Orders

--Задание на Джоины

--Функции для работы со строками
--SELECT LEN('HelloAll') -- длинна строки
--SELECT TRIM('                         Test   ') --вырезает пробелы
--SELECT LEFT('TechMeSkills', 3) --вырезает с начала строки определенное количество символов.
--SELECT RIGHT('TechMeSkills', 3)    --вырезает с конца строки определенное количество символов.
--SELECT SUBSTRING('TechMeSkills', 3, 2)    -- вырезает из строки подстроку определенной длиной, начиная с определенного индекса.Певый параметр функции - строка, второй - начальный индекс для вырезки, и третий параметр - количество вырезаемых символов
--SELECT REPLACE('TechMeSkills', 'TechMe', 'HelloMan')   --  заменяет одну подстроку другой в рамках строки. Первый параметр функции - строка, второй - подстрока, которую надо заменить, а третий - подстрока, на которую надо заменить
--SELECT REVERSE('TechMeSkills') -- переворачивает строку наоборот
--SELECT CONCAT('TechMeSkills Teacher', ' ', 'Artem')  -- объединяет две строки в одну.
--SELECT LOWER('TechMeSkills')   --переводит строку в нижний регистр
--SELECT UPPER('TechMeSkills')   --переводит строку в верхний регистр

--Функции для работы с числами

SELECT ROUND(100.1252314, 4)   --округляет число. В качестве первого параметра передается число. Второй параметр указывает на длину. Если длина представляет положительное число, то оно указывает, до какой цифры после запятой идет округление.
SELECT ISNUMERIC(100.1252314)          -- определяет, является ли значение числом.
SELECT ISNUMERIC('100.1252314')        -- определяет, является ли значение числом.
SELECT ISNUMERIC('TeachMeSkills')         -- определяет, является ли значение числом.
SELECT CEILING(100.12)      -- возвращает наибольшее целое число
SELECT FLOOR(100.12)        -- возвращает наименьшее целое число
SELECT SQUARE(25)        --  возводит число в квадрат.
SELECT SQRT(225)        -- получает квадратный корень числа.
SELECT RAND()       -- генерирует случайное число с плавающей точкой в диапазоне от 0 до 1.

--Функции по работе с датами и временем

SELECT GETDATE()    -- возвращает текущую локальную дату 
SELECT DAY(GETDATE())       -- возвращает день даты
SELECT MONTH(GETDATE())     -- возвращает месяц даты
SELECT YEAR(GETDATE())      -- возвращает год из даты
SELECT DATENAME(week  , GETDATE())       -- возвращает часть даты в виде строки.
--year (yy, yyyy): год
--quarter (qq, q): квартал
--month (mm, m): месяц
--dayofyear (dy, y): день года
--day (dd, d): день месяца
--week (wk, ww): неделя
--weekday (dw): день недели
--hour (hh): час
--minute (mi, n): минута
--second (ss, s): секунда
--millisecond (ms): миллисекунда
--microsecond (mcs): микросекунда
--nanosecond (ns): наносекунда
SELECT DATEPART(month, GETDATE())       -- возвращает часть даты в виде числа.
SELECT DATEDIFF(year, '2023-7-28', '2022-7-28')     -- возвращает разницу между двумя датами
SELECT DATEDIFF(day, '2023-7-28', '2022-9-28')      
SELECT ISDATE('2023-07-28')       
SELECT ISDATE('28-07-2023')     
SELECT ISDATE('SQL2023')   


--Функция CASE 
SELECT Email,
    CASE Id
        WHEN 1 THEN 'Artem Zyglin Email'
        WHEN 2 THEN 'Leon Email'
        WHEN 3 THEN 'Yuri Email'
        ELSE 'Unknown Emails'
    END AS EmailOwner
FROM Person

--Функция IIF 

SELECT Email,
    IIF(Email='zyglinasd@mail.ru', 'Teacher Account', 'User Account') AS AccountStatus
FROM Person

INSERT INTO Person VALUES(7,'Egor','Sidorov',NULL);
--Функция ISNULL
SELECT FirstName, LastName,
        ISNULL(Email, 'Unkown') AS Email
FROM Person

--Смысл разделения SQL-выражений на пакеты состоит в том, что одни выражения должны успешно выполниться до запуска
--других выражений.
--Например, при добавлении таблиц мы должны бы уверены, что была создана база данных,
--в которой мы собираемся создать таблицы.


--Представления(Views) представляют виртуальные таблицы. 
-- Они упрощают комплексные SQL-операции,защищают данные, так как представления могут дать доступ к части таблицы,
--а не ко всей таблице.
--GO
--CREATE VIEW OrdersPerson AS
--SELECT Orders.CreatedAt AS OrderDate, 
--        Person.Email AS Product  
--FROM Orders INNER JOIN Person ON Orders.PersonId = Person.Id

GO
ALTER VIEW OrdersPerson AS
SELECT Orders.CreatedAt AS OrderDate, 
        Person.Email AS Email,
        Person.FirstName AS FirstName  
FROM Orders 
INNER JOIN Person ON Orders.PersonId = Person.Id

GO
DROP VIEW OrdersPerson

--Задание по представлениям 

--В предыдущих случаях сначала создавалась база данных, а затем в эту БД добавлялась таблица с помощью отдельных команд SQL. Но можно сразу совместить в одном скрипте несколько команд.
--В этом случае отдельные наборы команд называются пакетами (batch).
--Каждый пакет состоит из одного или нескольких SQL-выражений, которые выполняются как оно целое.
--В качестве сигнала завершения пакета и выполнения его выражений служит команда GO.


--Хранимые процедуры 
--Когда нам нужно инкапсулировать все действия в один объект - хранимую процедуру (stored procedure).
--хранимые процедуры представляют набор инструкций, которые выполняются как единое целое.
--Тем самым хранимые процедуры позволяют упростить комплексные операции и вынести их в единый объект. 
--Также хранимые процедуры позволяют ограничить доступ к данным в таблицах и тем самым уменьшить вероятность
--преднамеренных или неосознанных нежелательных действий в отношении этих данных.
--И еще один важный аспект - производительность. Хранимые процедуры обычно выполняются быстрее, чем обычные SQL-инструкции.
--Все потому что код процедур компилируется один раз при первом ее запуске, а затем сохраняется в скомпилированной форме.

GO
CREATE PROCEDURE ExampleProcedure AS
BEGIN
    SELECT [FirstName], [LastName]
    FROM [dbo].[Person]
END;

GO
Alter PROCEDURE ExampleProcedure AS
BEGIN
    SELECT [FirstName], [LastName]
    FROM [dbo].[Person]
END;

EXEC ExampleProcedure

DROP PROCEDURE ExampleProcedure

--Триггеры

--Триггеры представляют специальный тип хранимой процедуры, которая вызывается автоматически при выполнении определенного действия над таблицей или представлением,
--в частности, при добавлении, изменении или удалении данных,
--то есть при выполнении команд INSERT, UPDATE, DELETE.

--CREATE TRIGGER имя_триггера
--ON {имя_таблицы | имя_представления}
--{AFTER | INSTEAD OF} [INSERT | UPDATE | DELETE]
--AS выражения_sql

--AFTER: выполняется после выполнения действия. Определяется только для таблиц.
--INSTEAD OF: выполняется вместо действия . Определяется для таблиц и представлений
--После типа триггера идет указание операции, для которой определяется триггер: INSERT, UPDATE или DELETE.

--Для AFTER можно применять сразу для нескольких действий, UPDATE,INSERT или DELETE.
--Для триггера INSTEAD OF можно определить только одно действие.

GO
CREATE TRIGGER Person_INSERT
ON Person
AFTER INSERT
AS
SELECT * FROM Person

INSERT INTO Person VALUES(12,'Egor4','Sidorov6','example6@mail.ruuuu');


DROP TRIGGER Person_INSERT

