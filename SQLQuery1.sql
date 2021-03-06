﻿CREATE TABLE Brands(
	BrandId int PRIMARY KEY IDENTITY(1,1),
	BrandName varchar(255),
)
CREATE TABLE Colors(
	ColorId int PRIMARY KEY IDENTITY(1,1),
	ColorName varchar(255),
)
CREATE TABLE Cars(
	CarId int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice int,
	Descriptions varchar(255),
	FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId)
)

INSERT INTO Cars(CarId,BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
		(1,1,1,1995,200,'Karbüratörlü LPG'),
		(2,2,3,2000,500,'Enjeksiyonlu LPG'),
		(3,3,4,2000,600,'Enjeksiyonlu Benzin'),
		(4,4,2,1995,300,'Karbüratörlü Benzin');

INSERT INTO Brands(BrandId,BrandName)
VALUES
		(1,'RENAULT'),
		(2,'BMW'),
		(3,'OPEL'),
		(4,'FORD');

INSERT INTO Colors(ColorId,ColorName)
VALUES
		(1,'BEYAZ'),
		(2,'MAVİ'),
		(3,'SİYAH'),
		(4,'GRİ');

CREATE TABLE Users(
	UserId int PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(255),
	LastName nvarchar(255),
	Email nvarchar(255),
	Password nvarchar(255),
)

CREATE TABLE Customers(
	CustomerId int PRIMARY KEY IDENTITY(1,1),
	UserId int,
	CompanyName nvarchar(255),
	FOREIGN KEY(UserId) REFERENCES Users(UserId)
)

CREATE TABLE RentAls(
	RentAlId int PRIMARY KEY IDENTITY(1,1),
	CarId int,
	CustomerId int,
	RentDate datetime,
	ReturnDate datetime,
	FOREIGN KEY (CarId) REFERENCES Cars(CarId),
	FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
)

Select * from Users



