USE `club_deportivo`;
DROP procedure IF EXISTS `ListarUsuarios`;

DELIMITER $$
USE `club_deportivo`$$
create procedure ListarUsuarios()
 begin
	select * from socio;
end$$

DELIMITER ;
