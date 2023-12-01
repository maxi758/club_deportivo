create database club_deportivo;

CREATE TABLE `club_deportivo`.`socio` (
  `idSocio` INT NOT NULL AUTO_INCREMENT,
  `dni` VARCHAR(45) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NOT NULL,
  `direccion` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idSocio`));
  
  CREATE TABLE `club_deportivo`.`no_socio` (
  `id_no_socio` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NOT NULL,
  `direccion` VARCHAR(45) NOT NULL,
  `dni` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_no_socio`));

CREATE TABLE `club_deportivo`.`actividad` (
  `idActividad` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `descripcion` VARCHAR(45) NOT NULL,
  `precio` INT NOT NULL,
  PRIMARY KEY (`idActividad`));

  create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

--insert into roles values
--(120,'Administrador'),
--(121,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

--insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
--(26,'Mari2023','123456',120);

  
