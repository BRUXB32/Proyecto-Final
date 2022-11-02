use dmichaelsson;

drop table if exists historico,facturas,sectores,prodeins,predios,usuarios,personas;

create table if not exists personas(
Cedula int(8),
Nombre varchar(60) not null,
Correo varchar(80),
Tel int(9),
TipoP enum('PF','PV','PC','AD') not null,
BajaLogica bool default false not null ,
primary key(Cedula)
);

create table if not exists usuarios(
Cedula int(8),
Contraseña varchar(20) not null,
TipoP enum('PF','PV','PC','AD') not null,
BajaLogica bool default false not null,
primary key(Cedula)
);

create table if not exists prodeins(
IdPoI int(3) auto_increment,
Nombre varchar(25) unique not null,
Cantidad double(8,2) not null,
Precio double(8,2) not null,
Tipo enum('Fr','V','C','S','Fe','Pe','Pl','G','B') not null,
BajaLogica bool default false not null,
primary key(IdPoI)
);

create table if not exists predios(
IdPredio int(2),
Cedula int(8),
CultivoAño int(10),
BajaLogica bool default false not null,
foreign key(Cedula) references personas(Cedula),
primary key(IdPredio)
);

create table if not exists sectores(
IdPredio int(2),
IdSector int(1),
IdP int(3),
TamañoSec int(1) not null,
Etapa enum('Recien Plantado','Z2.2','Z3.0','Reposo','Libre'),
CambioEstado date,
foreign key(IdPredio) references predios(IdPredio),
foreign key(IdP) references prodeins(IdPoI),
primary key(IdPredio, IdSector)
);

create table if not exists facturas(
IdFactura int(15) auto_increment,
TipoT enum('C', 'V') not null,
Cedula int(8) not null,
IdPoI int(3) not null,
PrecioTotal double(16,4) not null,
Cantidad double(8,2) not null,
Fecha datetime not null,
Estado enum('Espera','Acceptado','Anulado') not null,
foreign key(Cedula) references personas(Cedula),
foreign key(IdPoI) references prodeins(IdPoI),
primary key(IdFactura)
);

create table if not exists historico(
IdHistorico int(15) auto_increment,
Cedula int(8) not null,
Terminal int(2),
Fecha datetime not null,
Tabla varchar(120),
Operacion varchar(300) not null,
foreign key(Cedula) references personas(Cedula),
primary key(IdHistorico)
);

insert into personas(Cedula,Nombre,Correo,Tel,TipoP)
values
(12345672,'Administrativo','administrativo@gmail.com',123456789,'AD'),
(10000008,'Productor Cereales','productor.cereales@gmail.com',123456782,'PC'),
(54992740,'Productor Frutas','productor.frutas@gmail.com',null,'PF'),
(1000001,'Productor Verduras','productor.verduras@gmail.com',null,'PV');

insert into usuarios(Cedula,Contraseña,TipoP)
values
(12345672,'1234Adm..','AD'),
(10000008,'1234PC..','PC'),
(54992740,'1234PF..','PF'),
(1000001,'1234PV..','PV');

insert into prodeins(Nombre,Cantidad,Precio,Tipo)
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
('Brotes papas rosadas',5000,15,'B'),
('Semillas zapallo criollo',5000,21,'S'),
('Grano trigo',4996,10,'G'),
('Grano cebada',5000,15,'G'),
('Fertilizante de fosforo',5000,20,'Fe'),
('Fertilizante de nitrogeno',5000,23,'Fe'),
('Pesticidas',5000,40,'Pe');

insert into predios(IdPredio,Cedula,CultivoAño)
values
(1,10000008,1100),
(2,54992740,1243),
(3,1000001,1200),
(4,NULL,0),
(5,NULL,0);

insert into sectores(IdPredio,IdSector,IdP,TamañoSec,Etapa)
values
(1,1,6,3,'Z2.2'),
(1,2,7,3,'Z3.0'),
(1,3,6,3,'Reposo'),
(1,4,7,3,'Reposo'),
(2,1,1,2,'Recien Plantado'),
(2,2,2,2,'Recien Plantado'),
(2,3,3,2,'Recien Plantado'),
(2,4,1,2,'Reposo'),
(2,5,2,2,'Reposo'),
(2,6,3,2,'Reposo'),
(3,1,4,3,'Libre'),
(3,2,5,3,'Libre'),
(3,3,4,3,'Reposo'),
(3,4,5,3,'Reposo');

insert into facturas(TipoT,Cedula,IdPoI,PrecioTotal,Cantidad,Fecha,Estado)
values
('C',54992740,8,200,3,now(),'Acceptado'),
('C',10000008,13,600,4,now(),'Espera'),
('V',54992740,1,800,3,now(),'Espera');

insert into historico(Cedula,Terminal,Fecha,Tabla,Operacion)
values
(12345672,1,now(),'usuarios','Cambio Nombre de usuario 10000008'),
(12345672,1,now(),'usuarios','Cambio Cedula de usuario 54992740');


select * from usuarios;
select * from historico;
select * from prodeins;
select * from sectores;
select * from predios;
select * from personas;
select * from facturas;