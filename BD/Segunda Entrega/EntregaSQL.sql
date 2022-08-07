drop table if exists Facturas,Sectores,ProdEIns,Predios,Personas;

create table if not exists Personas(
Cedula int(8),
Contraseña varchar(20) not null,
Nombre varchar(60) not null,
Correo varchar(80),
Tel int(9),
TipoP enum('PF','PV','PC','AD') not null,
BajaLogica bool default false not null ,
primary key(Cedula)
);

create table if not exists ProdEIns(
IdPoI int(3) auto_increment,
Nombre varchar(25) unique not null,
Cantidad double(6,2) not null,
Precio double(6,2) not null,
Tipo enum('Fr','V','C','S','Fe','Pe','Pl') not null,
BajaLogica bool default false not null,
primary key(IdPoI)
);

create table if not exists Predios(
IdPredio int(2),
Cedula int(8),
CultivoAño int(10),
BajaLogica bool default false not null,
foreign key(Cedula) references Personas(Cedula),
primary key(IdPredio)
);

create table if not exists Sectores(
IdPredio int(2),
IdSector int(1),
IdP int(3),
TamañoSec int(1) not null,
Etapa enum('Recien Plantado','Z2.2','Z3.3','Reposo'),
CambioEstado date,
foreign key(IdPredio) references Predios(IdPredio),
foreign key(IdP) references ProdEIns(IdPoI),
primary key(IdPredio, IdSector)
);

create table if not exists Facturas(
IdFactura int(15) auto_increment,
TipoT enum('C', 'V') not null,
Cedula int(8) not null,
IdPoI int(3) not null,
Cantidad double(6,2) not null,
Fecha datetime not null,
foreign key(Cedula) references Personas(Cedula),
foreign key(IdPoI) references ProdEIns(IdPoI),
primary key(IdFactura)
);

insert into Personas(Cedula,Contraseña,Nombre,Correo,Tel,TipoP)
values
(12345672,'1234Adm..','Administrativo','administrativo@gmail.com',123456789,'AD'),
(10000008,'1234Pro..','Productor','productor@gmail.com',123456782,'PC'),
(12345678,'123Contraseña=)','Jose Martines','josemartines@gmail.com',123456799,'PF');

insert into ProdEIns(Nombre,Cantidad,Precio,Tipo)
values
('Manzanas',5000,34,'Fr'),
('Naranjas',5000,38,'Fr'),
('Limones',5000,36,'Fr'),
('Papas rosadas',5000,35,'V'),
('Zapallo criollo',5000,41,'V'),
('Trigo',5000,20,'C'),
('Cebada',5000,25,'C'),
('Plantines manzanas',5000,14,'Pl'),
('Plantines naranjas',5000,18,'Pl'),
('Plantines limones',5000,16,'Pl'),
('Semillas papas rosadas',5000,15,'S'),
('Semillas zapallo criollo',5000,21,'S'),
('Semillas trigo',4996,10,'S'),
('Semillas cebada',5000,15,'S'),
('Fertilizante de fosforo',5000,20,'Fe'),
('Fertilizante de nitrogeno',5000,23,'Fe'),
('Pesticidas',5000,40,'Pe');

insert into Predios(IdPredio,Cedula,CultivoAño)
values
(1,10000008,1100),
(2,12345678,1243),
(3,NULL,0),
(4,NULL,0),
(5,NULL,0);

insert into Sectores(IdPredio,IdSector,IdP,TamañoSec,Etapa)
values
(1,1,6,3,'Recien Plantado'),
(1,2,7,3,'Recien Plantado'),
(1,3,6,3,'Reposo'),
(1,4,7,3,'Reposo'),
(2,1,1,2,'Recien Plantado'),
(2,2,2,2,'Recien Plantado'),
(2,3,3,2,'Recien Plantado'),
(2,4,1,2,'Reposo'),
(2,5,2,2,'Reposo'),
(2,6,3,2,'Reposo');

insert into Facturas(TipoT,Cedula,IdPoI,Cantidad,Fecha)
values
('C',12345678,8,3,now()),
('C',10000008,13,4,now()),
('V',12345678,1,3,now());

select * from Personas;
select * from ProdEIns;
select * from Predios;
select * from Sectores;
select * from Facturas;