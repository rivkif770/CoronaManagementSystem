create table Client
(
Id int not null identity primary key,
IdentityClient varchar(50) not null UNIQUE,
FirstName varchar(50) not null,
LastName varchar(50) not null,
Address varchar(225) not null,
BirthDate date not null,
Phone varchar(50) not null,
MobilePhone varchar(50),
Img varchar(225)
)


create table Vaccination
(
Id int not null identity primary key,
IdClient varchar(50) not null,
DateVaccin date not null,
NameCompany varchar(50) not null
foreign key (IdClient) REFERENCES [dbo].[Client]([IdentityClient]),
)

create table Sick
(
Id int not null identity primary key,
IdClient varchar(50) not null UNIQUE,
DatePositive date not null,
DateRecovery date not null,
foreign key (IdClient) REFERENCES [dbo].[Client]([IdentityClient]),
)

select * from [dbo].[Client]
delete from [dbo].[Client]
where [Id] = 1055