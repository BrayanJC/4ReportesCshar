Create database CRUD_Example_Reportes
use CRUD_Example_Reportes
go
Create table DBPacientes(
Id int identity(1,1) primary key,
Nombres varchar(100) not null,
Apellidos varchar(100) not null,
Fecha_Nacimiento date not null,
Ciudad varchar(100) not null,
Imagen varbinary(max)
)
go
