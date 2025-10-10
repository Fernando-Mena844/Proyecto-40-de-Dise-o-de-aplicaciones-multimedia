create database Proyecto40_20220050_20250091
go

use Proyecto40_20220050_20250091
go

create table Roles(
idRol int identity(1,1) primary key,
descripcionRol varchar (30) not null);
go

create table Permisos(
idPermisos int identity (1,1) primary key,
rol_id int not null,
foreign key (rol_id) references Roles(idRol),
descripcionPermiso varchar (30));
go

create table Usuarios(
idUsuario int identity(1,1) primary key,
rol_id int,
foreign key (rol_id) references Roles(idRol),
nombreUsuario varchar (60) not null,
correoUsuario varchar (60) unique not null,
documentoUsuario varchar(10) unique not null,
contraseniaUsuario char(60) not null)
go
insert into Roles values ('Administrador'), ('T�cnico'), ('Cliente')
--Estas son las credenciales:
--Documento: 0004
--Contrase�a: 1234
insert into Usuarios values (1,'Cesar Zepeda', 'cesar@gmail.com','0004', '$2a$11$apc0UAFg5kpElKx74teLo.5Jytu.V8kIDoJ4N/HJBEOy7laBokAGm')


create table Categorias(
idCategoria int identity(1,1) primary key,
descripcionCategoria varchar (50) not null)
go

create table Clientes(
idCliente int identity(1,1) primary key,
nombreCliente varchar(60) not null,
documentoCliente char(10) unique not null,
correoCliente varchar(60) unique not null,
telefonoCliente char(9) not null)
go

create table Tickets(
idTicket int identity(1,1) primary key,
descripcionTicket varchar(100) not null,	
categoria_id int not null,
foreign key (categoria_id) references Categorias(idCategoria) on delete cascade,
cliente_id int not null,
foreign key (cliente_id) references Clientes(idCliente) on delete cascade,
usuario_id int not null,
foreign key (usuario_id) references Usuarios(idUsuario) on delete cascade,
fechaRecibido date default getdate(),
fechaEntrega date);
go


INSERT INTO Categorias (descripcionCategoria)
VALUES ('Soporte T�cnico'), ('Mantenimiento'), ('Garant�a');