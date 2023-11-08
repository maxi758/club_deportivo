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


  
