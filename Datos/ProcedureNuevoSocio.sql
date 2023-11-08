USE `club_deportivo`;
DROP procedure IF EXISTS `NuevaPersona`;

DELIMITER $$
USE `club_deportivo`$$
create procedure NuevaPersona(in Nombre varchar(45),in Apellido varchar(45),in Direccion varchar(45), in Dni varchar(45), out rta int)
 begin
	declare existe int default 0;
	declare id int default 0;

 	set existe = (select count(*) from socio s where s.dni = Dni);
	if existe = 0 then	 
		insert into socio(dni, nombre, apellido, direccion) values(Dni, Nombre,Apellido,Direccion);
         set id = LAST_INSERT_ID();
         set rta  = id;
	else
		 set rta = existe;
	end if;		 
    
end$$

DELIMITER ;



