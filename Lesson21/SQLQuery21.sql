USE Test

--���������� ������ �� ���� ������ ����������� �������� JOIN
SELECT Orders.CreatedAt, Person.LastName 
FROM Orders
INNER JOIN Person ON Person.Id = Orders.PersonId

--������� �� INNER JOIN ������� ���������� OUTER JOIN ���������� ��� ������ ����� ��� ���� ������, ������� ��������� � ����������.
--����� ���������� OUTER JOIN ����������� ���� �� �������� ���� LEFT, RIGHT ��� FULL, ������� ���������� ��� ����������:
--LEFT: ������� ����� ��������� ��� ������ �� ������ ��� ����� �������
--RIGHT: ������� ����� ��������� ��� ������ �� ������ ��� ������ �������
--FULL: ������� ����� ��������� ��� ������ �� ����� ������

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

--������� �� ������

--������� ��� ������ �� ��������
--SELECT LEN('HelloAll') -- ������ ������
--SELECT TRIM('                         Test   ') --�������� �������
--SELECT LEFT('TechMeSkills', 3) --�������� � ������ ������ ������������ ���������� ��������.
--SELECT RIGHT('TechMeSkills', 3)    --�������� � ����� ������ ������������ ���������� ��������.
--SELECT SUBSTRING('TechMeSkills', 3, 2)    -- �������� �� ������ ��������� ������������ ������, ������� � ������������� �������.����� �������� ������� - ������, ������ - ��������� ������ ��� �������, � ������ �������� - ���������� ���������� ��������
--SELECT REPLACE('TechMeSkills', 'TechMe', 'HelloMan')   --  �������� ���� ��������� ������ � ������ ������. ������ �������� ������� - ������, ������ - ���������, ������� ���� ��������, � ������ - ���������, �� ������� ���� ��������
--SELECT REVERSE('TechMeSkills') -- �������������� ������ ��������
--SELECT CONCAT('TechMeSkills Teacher', ' ', 'Artem')  -- ���������� ��� ������ � ����.
--SELECT LOWER('TechMeSkills')   --��������� ������ � ������ �������
--SELECT UPPER('TechMeSkills')   --��������� ������ � ������� �������

--������� ��� ������ � �������

SELECT ROUND(100.1252314, 4)   --��������� �����. � �������� ������� ��������� ���������� �����. ������ �������� ��������� �� �����. ���� ����� ������������ ������������� �����, �� ��� ���������, �� ����� ����� ����� ������� ���� ����������.
SELECT ISNUMERIC(100.1252314)          -- ����������, �������� �� �������� ������.
SELECT ISNUMERIC('100.1252314')        -- ����������, �������� �� �������� ������.
SELECT ISNUMERIC('TeachMeSkills')         -- ����������, �������� �� �������� ������.
SELECT CEILING(100.12)      -- ���������� ���������� ����� �����
SELECT FLOOR(100.12)        -- ���������� ���������� ����� �����
SELECT SQUARE(25)        --  �������� ����� � �������.
SELECT SQRT(225)        -- �������� ���������� ������ �����.
SELECT RAND()       -- ���������� ��������� ����� � ��������� ������ � ��������� �� 0 �� 1.

--������� �� ������ � ������ � ��������

SELECT GETDATE()    -- ���������� ������� ��������� ���� 
SELECT DAY(GETDATE())       -- ���������� ���� ����
SELECT MONTH(GETDATE())     -- ���������� ����� ����
SELECT YEAR(GETDATE())      -- ���������� ��� �� ����
SELECT DATENAME(week  , GETDATE())       -- ���������� ����� ���� � ���� ������.
--year (yy, yyyy): ���
--quarter (qq, q): �������
--month (mm, m): �����
--dayofyear (dy, y): ���� ����
--day (dd, d): ���� ������
--week (wk, ww): ������
--weekday (dw): ���� ������
--hour (hh): ���
--minute (mi, n): ������
--second (ss, s): �������
--millisecond (ms): ������������
--microsecond (mcs): ������������
--nanosecond (ns): �����������
SELECT DATEPART(month, GETDATE())       -- ���������� ����� ���� � ���� �����.
SELECT DATEDIFF(year, '2023-7-28', '2022-7-28')     -- ���������� ������� ����� ����� ������
SELECT DATEDIFF(day, '2023-7-28', '2022-9-28')      
SELECT ISDATE('2023-07-28')       
SELECT ISDATE('28-07-2023')     
SELECT ISDATE('SQL2023')   


--������� CASE 
SELECT Email,
    CASE Id
        WHEN 1 THEN 'Artem Zyglin Email'
        WHEN 2 THEN 'Leon Email'
        WHEN 3 THEN 'Yuri Email'
        ELSE 'Unknown Emails'
    END AS EmailOwner
FROM Person

--������� IIF 

SELECT Email,
    IIF(Email='zyglinasd@mail.ru', 'Teacher Account', 'User Account') AS AccountStatus
FROM Person

INSERT INTO Person VALUES(7,'Egor','Sidorov',NULL);
--������� ISNULL
SELECT FirstName, LastName,
        ISNULL(Email, 'Unkown') AS Email
FROM Person

--����� ���������� SQL-��������� �� ������ ������� � ���, ��� ���� ��������� ������ ������� ����������� �� �������
--������ ���������.
--��������, ��� ���������� ������ �� ������ �� �������, ��� ���� ������� ���� ������,
--� ������� �� ���������� ������� �������.


--�������������(Views) ������������ ����������� �������. 
-- ��� �������� ����������� SQL-��������,�������� ������, ��� ��� ������������� ����� ���� ������ � ����� �������,
--� �� �� ���� �������.
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

--������� �� �������������� 

--� ���������� ������� ������� ����������� ���� ������, � ����� � ��� �� ����������� ������� � ������� ��������� ������ SQL. �� ����� ����� ���������� � ����� ������� ��������� ������.
--� ���� ������ ��������� ������ ������ ���������� �������� (batch).
--������ ����� ������� �� ������ ��� ���������� SQL-���������, ������� ����������� ��� ��� �����.
--� �������� ������� ���������� ������ � ���������� ��� ��������� ������ ������� GO.


--�������� ��������� 
--����� ��� ����� ��������������� ��� �������� � ���� ������ - �������� ��������� (stored procedure).
--�������� ��������� ������������ ����� ����������, ������� ����������� ��� ������ �����.
--��� ����� �������� ��������� ��������� ��������� ����������� �������� � ������� �� � ������ ������. 
--����� �������� ��������� ��������� ���������� ������ � ������ � �������� � ��� ����� ��������� �����������
--�������������� ��� ������������ ������������� �������� � ��������� ���� ������.
--� ��� ���� ������ ������ - ������������������. �������� ��������� ������ ����������� �������, ��� ������� SQL-����������.
--��� ������ ��� ��� �������� ������������� ���� ��� ��� ������ �� �������, � ����� ����������� � ���������������� �����.

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

--��������

--�������� ������������ ����������� ��� �������� ���������, ������� ���������� ������������� ��� ���������� ������������� �������� ��� �������� ��� ��������������,
--� ���������, ��� ����������, ��������� ��� �������� ������,
--�� ���� ��� ���������� ������ INSERT, UPDATE, DELETE.

--CREATE TRIGGER ���_��������
--ON {���_������� | ���_�������������}
--{AFTER | INSTEAD OF} [INSERT | UPDATE | DELETE]
--AS ���������_sql

--AFTER: ����������� ����� ���������� ��������. ������������ ������ ��� ������.
--INSTEAD OF: ����������� ������ �������� . ������������ ��� ������ � �������������
--����� ���� �������� ���� �������� ��������, ��� ������� ������������ �������: INSERT, UPDATE ��� DELETE.

--��� AFTER ����� ��������� ����� ��� ���������� ��������, UPDATE,INSERT ��� DELETE.
--��� �������� INSTEAD OF ����� ���������� ������ ���� ��������.

GO
CREATE TRIGGER Person_INSERT
ON Person
AFTER INSERT
AS
SELECT * FROM Person

INSERT INTO Person VALUES(12,'Egor4','Sidorov6','example6@mail.ruuuu');


DROP TRIGGER Person_INSERT

