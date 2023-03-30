
--CREATE DATABASE Test;
--DROP DATABASE Test;

--USE Test;

-- CREATE TABLE ���_�������(
-- ���_���� ���_������,
-- ���_���� ���_������,
-- ���_���� ���_������,
--)

--CREATE TABLE Person
--(
--    Id INT,
--    FirstName NVARCHAR(20),
--    LastName NVARCHAR(20),
--    Email NVARCHAR(30),
--)

--DROP TABLE Person

--C������� ������� Customer � ������ Id, Name, Salary, Email, Adress.

--� ������� ��������� PRIMARY KEY ������� ����� ������� ��������� ������.

--CREATE TABLE Person
--(
--    Id INT PRIMARY KEY,
--    FirstName NVARCHAR(20),
--    LastName NVARCHAR(20),
--    Email VARCHAR(30)
--)

--���� �� �����, ����� ������� ���� ������ ���������� ��������, �� ��� ���� ����� ���������� ������� UNIQUE.

--CREATE TABLE Person
--(
--    Id INT PRIMARY KEY,
--    FirstName NVARCHAR(20),
--    LastName NVARCHAR(20),
--    Email NVARCHAR(30) UNIQUE
--)

--����� �������, ����� �� ������� ��������� �������� NULL, ��� ����������� ������� ��� ����� ������ ������� NULL ��� NOT NULL

--CREATE TABLE Person
--(
--    Id INT PRIMARY KEY,
--    FirstName NVARCHAR(20) NOT NULL,
--    LastName NVARCHAR(20) NOT NULL,
--    Email VARCHAR(30) UNIQUE,
--)

--������� DEFAULT ���������� �������� �� ��������� ��� �������. ���� ��� ���������� ������ ��� ������� �� ����� ������������� ��������, �� ��� ���� ����� �������������� �������� �� ���������.

--CREATE TABLE Person
--(
--    Id INT PRIMARY KEY,
--    FirstName NVARCHAR(20) DEFAULT 'Hello Test',
--    LastName NVARCHAR(20) NOT NULL,
--    Email VARCHAR(30) UNIQUE,
--)

--�������� ����� CHECK ������ ����������� ��� ��������� ��������, ������� ����� ��������� � �������. 
--��� ���������� ������� ������������ �������� ����� AND.
--CHECK( (���_���� != ��������) AND (���_���� != ��������))
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

--FK Orders  FOREIGN KEY (��� ���� ������� �������) REFERENCES ���_������� (Id)
--CREATE TABLE Orders
--(
--    Id INT NOT NULL,
--    PersonId INT,
--    CreatedAt Date,
--	FOREIGN KEY(PersonId) REFERENCES Person(Id)
--);

--DROP TABLE Person;

--DROP TABLE Orders;

---- ALTER TABLE ���_�������
---- ADD ���_������� ��� �����������
--ALTER TABLE Person
--ADD WalletAddress NVARCHAR(50) NULL

---- ALTER TABLE ���_�������
---- DROP COLUMN ���_�������
--ALTER TABLE Person
--DROP COLUMN WalletAddress;


---- ALTER TABLE ���_�������
---- ALTER COLUMN ���_������� ��� �����������
--ALTER TABLE Person
--ALTER COLUMN WalletAddress NVARCHAR(200) NOT NULL ;

---- ALTER TABLE ���_�������
---- ALTER FOREIGN KEY (��� ���� ������� �������) REFERENCES ���_������� (���� ������� �� ������� �� ���������)
--ALTER TABLE Orders
--ADD FOREIGN KEY(PersonId) REFERENCES Person(Id);


---- ALTER TABLE ���_�������
---- ALTER PRIMARY KEY (���� �������)
--ALTER TABLE Person
--ADD PRIMARY KEY (Id);

--ALTER TABLE Orders
--ADD PRIMARY KEY (Id);
---- ALTER TABLE ���_�������
---- DROP CONSTRAINT ��� �����
--ALTER TABLE Person  
--DROP CONSTRAINT PK__Person__3214EC079B5D5905;   


-- ������ ������� Book ���� Id PK, Name NOT NULL, AuthorId FK, Price , Desctiption 
-- ������ ������� Author ���� Id Pk, FirstName NOT Null, LastName Default, Adress, Age, BirthDay Date, City
-- ����������� Check Age > 30

--('2020-12-15')
--('2020.12.15')

INSERT Person VALUES (1,'Artem', 'Zyglin','zyglinasd@mail.ru');

INSERT INTO Person (Id,FirstName,LastName,Email)
VALUES (2,'Leon', 'Example', 'leon@mail.ru')

INSERT Orders VALUES (1,1, '2023-03-30');
INSERT Orders VALUES (2,2, '2023-03-30');