use mpoy;

drop table if exists Historico,Facturas,Sectores,ProdEIns,Predios,Usuarios,Personas;

create table if not exists Personas(
Cedula int(8),
Nombre varchar(60) not null,
Correo varchar(80),
Tel int(9),
TipoP enum('PF','PV','PC','AD') not null,
BajaLogica bool default false not null ,
primary key(Cedula)
);

create table if not exists Usuarios(
Cedula int(8),
Contraseña varchar(20) not null,
TipoP enum('PF','PV','PC','AD') not null,
BajaLogica bool default false not null,
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
Etapa enum('Recien Plantado','Z2.2','Z3.0','Reposo','Libre'),
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
PrecioTotal double(6,2) not null,
Cantidad double(6,2) not null,
Fecha datetime not null,
Estado enum('Espera','Acceptado','Anulado') not null,
foreign key(Cedula) references Personas(Cedula),
foreign key(IdPoI) references ProdEIns(IdPoI),
primary key(IdFactura)
);

create table if not exists Historico(
IdHistorico int(15) auto_increment,
Cedula  int(8) not null,
Fecha datetime not null,
Operacion varchar(300) not null,
foreign key(Cedula) references Personas(Cedula),
primary key(IdHistorico)
);

insert into Personas(Cedula,Nombre,Correo,Tel,TipoP)
values
(12345672,'Administrativo','administrativo@gmail.com',123456789,'AD'),
(10000008,'Productor Cereales','productor.cereales@gmail.com',123456782,'PC'),
(54992740,'Productor Frutas','productor.frutas@gmail.com',null,'PF'),
(1000001,'Productor Verduras','productor.verduras@gmail.com',null,'PV');

insert into Usuarios(Cedula,Contraseña,TipoP)
values
(12345672,'1234Adm..','AD'),
(10000008,'1234PC..','PC'),
(54992740,'1234PF..','PF'),
(1000001,'1234PV..','PV');

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
(2,54992740,1243),
(3,1000001,1200),
(4,NULL,0),
(5,NULL,0);

insert into Sectores(IdPredio,IdSector,IdP,TamañoSec,Etapa)
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
(2,6,3,2,'Reposo');

insert into Facturas(TipoT,Cedula,IdPoI,PrecioTotal,Cantidad,Fecha,Estado)
values
('C',54992740,8,200,3,now(),'Acceptado'),
('C',10000008,13,600,4,now(),'Espera'),
('V',54992740,1,800,3,now(),'Espera');

insert into Historico(Cedula,Fecha,Operacion)
values
(12345672,now(),'Cambio Nombre de usuario 10000008'),
(12345672,now(),'Cambio Cedula de usuario 54992740');

select Facturas.IdFactura,Facturas.TipoT,ProdEIns.Nombre,Facturas.PrecioTotal,Facturas.Cantidad,Facturas.Fecha,Facturas.Estado from Facturas,ProdEIns where Facturas.Cedula = 12345678 and Facturas.IdPoI=ProdEIns.IdPoI;
select Facturas.IdFactura,ProdEIns.Nombre,Facturas.Cantidad,Facturas.Fecha from Facturas,ProdEIns where Facturas.Cedula = 54992740 and Facturas.TipoT='C' and Facturas.IdPoI=ProdEIns.IdPoI;
select Facturas.IdFactura,ProdEIns.Nombre,Facturas.Cantidad,Facturas.Fecha from Facturas,ProdEIns where Facturas.Cedula = 54992740 and Facturas.TipoT='V' and Facturas.IdPoI=ProdEIns.IdPoI;
select Facturas.IdFactura,ProdEIns.Nombre,Facturas.Cantidad,Facturas.Fecha from Facturas,ProdEIns where Facturas.Cedula = 54992740 and Facturas.TipoT='C' and Facturas.Cantidad>2 and Facturas.IdPoI=ProdEIns.IdPoI;
select Facturas.IdFactura,ProdEIns.Nombre,Facturas.Cantidad,Facturas.Fecha from Facturas,ProdEIns where Facturas.Cedula = 54992740 and Facturas.TipoT='V' and Facturas.Cantidad<5 and Facturas.IdPoI=ProdEIns.IdPoI;

select count(*) from Personas where Personas.TipoP!='AD';
select count(*) from Personas where Personas.Correo="" and Personas.Tel="";
select count(*) from Personas where Personas.TipoP!='AD' and Personas.Correo!=null and Personas.Tel!=null;

select count(*) from Facturas where Facturas.TipoT='C';
select count(*) from Facturas where Facturas.TipoT='V';
select count(*) from Facturas where Facturas.TipoT='C' and Facturas.Cedula = 54992740;
select count(*) from Facturas where Facturas.TipoT='V' and Facturas.Cedula = 54992740;
select count(*) from Facturas where Facturas.TipoT='C' and Facturas.Cedula = 54992740 and Facturas.Cantidad>2;
select count(*) from Facturas where Facturas.TipoT='V' and Facturas.Cedula = 54992740 and Facturas.Cantidad<5;


select Personas.Cedula from Personas,Facturas where Personas.Cedula=Facturas.Cedula;

select Facturas.TipoT, count(*) as Cantidad from Facturas group by Facturas.TipoT;
select Facturas.TipoT, count(*) as Cantidad from Facturas group by Facturas.TipoT having count(*)>1;

##select Facturas.TipoT from Facturas  having count(*)>1;

select * from Personas where Personas.TipoP like 'P%';

##select Facturas.IdFactura, Facturas.TipoT, ProdEIns.Nombre, Facturas.Cedula

-------------------------------------------------------------------------------------------------------------------

select count(*) from Personas where Personas.TipoP!='AD';
select sum(PrecioTotal) from Facturas where TipoT='C';
select sum(Facturas.PrecioTotal) from Facturas where Facturas.TipoT='V';


select Fecha,Operacion from Historico where Cedula in(select Cedula from Personas where Cedula = 12345672) order by Fecha desc;
select sum(PrecioTotal) as Gastos from Facturas where TipoT='C' and Fecha > '2022-08-28 18:24:18';
select sum(PrecioTotal) as Ganancias from Facturas where TipoT='V' and Fecha > '2022-08-28 18:24:18';