USE `club_deportivo`;
DROP procedure IF EXISTS `ListarActividades`;

DELIMITER $$
USE `club_deportivo`$$
CREATE PROCEDURE ListarActividades()
  BEGIN
    SELECT * FROM actividad;
END$$

DELIMITER ;
