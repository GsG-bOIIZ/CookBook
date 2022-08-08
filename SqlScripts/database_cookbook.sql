create database CookBook
use CookBook

create table Recipe
(
    Id int identity(1,1) constraint PK_Faculty primary key,
    Title nvarchar(255),
    Description nvarchar(255),
	CookingTime INT,
	Portions INT,
	Stars INT,
	Likes INT
)