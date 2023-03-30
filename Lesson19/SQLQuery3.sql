
--CREATE DATABASE Test;
--DROP DATABASE Test;

--USE Test;

-- CREATE TABLE имя_Таблицы(
-- Имя_Поля Тип_Данных,
-- Имя_Поля Тип_Данных,
-- Имя_Поля Тип_Данных,
--)

--CREATE TABLE Person
--(
--    Id INT,
--    FirstName NVARCHAR(20),
--    LastName NVARCHAR(20),
--    Email NVARCHAR(30),
--)

--DROP TABLE Person

--Cоздайте таблицу Customer с полями Id, Name, Salary, Email, Adress.

--С помощью выражения PRIMARY KEY столбец можно сделать первичным ключом.

--CREATE TABLE Person
--(
--    Id INT PRIMARY KEY,
--    FirstName NVARCHAR(20),
--    LastName NVARCHAR(20),
--    Email VARCHAR(30)
--)

--Если мы хотим, чтобы столбец имел только уникальные значения, то для него можно определить атрибут UNIQUE.

--CREATE TABLE Person
--(
--    Id INT PRIMARY KEY,
--    FirstName NVARCHAR(20),
--    LastName NVARCHAR(20),
--    Email NVARCHAR(30) UNIQUE
--)

--Чтобы указать, может ли столбец принимать значение NULL, при определении столбца ему можно задать атрибут NULL или NOT NULL

--CREATE TABLE Person
--(
--    Id INT PRIMARY KEY,
--    FirstName NVARCHAR(20) NOT NULL,
--    LastName NVARCHAR(20) NOT NULL,
--    Email VARCHAR(30) UNIQUE,
--)

--Атрибут DEFAULT определяет значение по умолчанию для столбца. Если при добавлении данных для столбца не будет предусмотрено значение, то для него будет использоваться значение по умолчанию.

--CREATE TABLE Person
--(
--    Id INT PRIMARY KEY,
--    FirstName NVARCHAR(20) DEFAULT 'Hello Test',
--    LastName NVARCHAR(20) NOT NULL,
--    Email VARCHAR(30) UNIQUE,
--)

--Ключевое слово CHECK задает ограничение для диапазона значений, которые могут храниться в столбце. 
--Для соединения условий используется ключевое слово AND.
--CHECK( (Имя_Поля != значение) AND (Имя_Поля != значение))
--CREATE TABLE Person
--(
--    Id INT PRIMARY KEY,
--    FirstName NVARCHAR(20) DEFAULT 'Hello Test',
--    LastName NVARCHAR(20) NOT NULL,
--    Email NVARCHAR(30) UNIQUE,
--	CHECK((Email !='') AND (LastName !=''))
--)

--FK


--CREATE TABLE Person
--(
--    Id INT NOT NULL,
--    FirstName NVARCHAR(20) NOT NULL,
--    LastName NVARCHAR(20) NOT NULL,
--    Email NVARCHAR(30) UNIQUE
--);

--FK Orders  FOREIGN KEY (имя поля текущей таблицы) REFERENCES имя_таблицы (Id)
--CREATE TABLE Orders
--(
--    Id INT NOT NULL,
--    PersonId INT,
--    CreatedAt Date,
--	FOREIGN KEY(PersonId) REFERENCES Person(Id)
--);

--DROP TABLE Person;

--DROP TABLE Orders;

---- ALTER TABLE имя_таблицы
---- ADD имя_Колонки тип ограничения
--ALTER TABLE Person
--ADD WalletAddress NVARCHAR(50) NULL

---- ALTER TABLE имя_таблицы
---- DROP COLUMN имя_Колонки
--ALTER TABLE Person
--DROP COLUMN WalletAddress;


---- ALTER TABLE имя_таблицы
---- ALTER COLUMN имя_Колонки тип ограничения
--ALTER TABLE Person
--ALTER COLUMN WalletAddress NVARCHAR(200) NOT NULL ;

---- ALTER TABLE имя_таблицы
---- ALTER FOREIGN KEY (имя поля текущей таблицы) REFERENCES имя_таблицы (поле таблицы на которую мы ссылаемся)
--ALTER TABLE Orders
--ADD FOREIGN KEY(PersonId) REFERENCES Person(Id);


---- ALTER TABLE имя_таблицы
---- ALTER PRIMARY KEY (поле таблицы)
--ALTER TABLE Person
--ADD PRIMARY KEY (Id);

--ALTER TABLE Orders
--ADD PRIMARY KEY (Id);
---- ALTER TABLE имя_таблицы
---- DROP CONSTRAINT имя ключа
--ALTER TABLE Person  
--DROP CONSTRAINT PK__Person__3214EC079B5D5905;   


-- Первая таблица Book поля Id PK, Name NOT NULL, AuthorId FK, Price , Desctiption 
-- Вторая таблица Author поля Id Pk, FirstName NOT Null, LastName Default, Adress, Age, BirthDay Date, City
-- Ограничение Check Age > 30

--('2020-12-15')
--('2020.12.15')

INSERT Person VALUES (1,'Artem', 'Zyglin','zyglinasd@mail.ru');

INSERT INTO Person (Id,FirstName,LastName,Email)
VALUES (2,'Leon', 'Example', 'leon@mail.ru')

INSERT Orders VALUES (1,1, '2023-03-30');
INSERT Orders VALUES (2,2, '2023-03-30');