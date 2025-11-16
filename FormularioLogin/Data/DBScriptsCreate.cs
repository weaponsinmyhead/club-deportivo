
namespace FormularioLogin.Data
{
	public class DBScriptsCreate
	{

		public static string CreateDatabase => @"
		
		-- Schema u462690221_club
		-- -----------------------------------------------------
		CREATE SCHEMA IF NOT EXISTS `u462690221_club` DEFAULT CHARACTER SET utf8 ;
		USE `u462690221_club` ;
		SET FOREIGN_KEY_CHECKS = 0;
		";

		public static string CreateTables => @"

		USE u462690221_club;

		DROP TABLE IF EXISTS `u462690221_club`.`cuota`;
		DROP TABLE IF EXISTS `u462690221_club`.`inscripcion`;
		DROP TABLE IF EXISTS `u462690221_club`.`actividad`;
		DROP TABLE IF EXISTS `u462690221_club`.`profesor`;
		DROP TABLE IF EXISTS `u462690221_club`.`noSocio`;
		DROP TABLE IF EXISTS `u462690221_club`.`socio`;
		DROP TABLE IF EXISTS `u462690221_club`.`usuario`;
		DROP TABLE IF EXISTS `u462690221_club`.`rol`;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`rol`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`rol` (
		  `id` INT NOT NULL AUTO_INCREMENT,
		  `name` VARCHAR(255) NOT NULL,
		  PRIMARY KEY (`id`)
		) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`usuario`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`usuario` (
		  `id` INT NOT NULL AUTO_INCREMENT,
		  `nombre` VARCHAR(45) NOT NULL,
		  `email` VARCHAR(45) NOT NULL,
		  `contrasenia` NVARCHAR(250) NOT NULL,
		  `rol_id` INT NOT NULL,
		  `create_time` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
		  `activo` TINYINT NOT NULL DEFAULT 1,
		  PRIMARY KEY (`id`),
		  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
		  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE,
		  INDEX `fk_rol_idx` (`rol_id` ASC) VISIBLE,
		  CONSTRAINT `fk_rol`
			FOREIGN KEY (`rol_id`)
			REFERENCES `u462690221_club`.`rol` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
		) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`socio`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`socio` (
		  `id` INT NOT NULL AUTO_INCREMENT,
		  `nombre` VARCHAR(45) NOT NULL,
		  `apellido` VARCHAR(45) NOT NULL,
		  `dni` VARCHAR(11) NOT NULL,
		  `fecha_nac` DATE NOT NULL,
		  `email` VARCHAR(100) NOT NULL,
		  `fecha_emision` DATE NOT NULL,
		  `estado` TINYINT NOT NULL DEFAULT 1,
		  `create_time` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
		  `carnet` TINYINT NOT NULL DEFAULT 1,
		  PRIMARY KEY (`id`),
		  UNIQUE INDEX `dni_UNIQUE` (`dni` ASC)
		) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`noSocio`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`noSocio` (
		  `id` INT NOT NULL AUTO_INCREMENT,
		  `nombre` VARCHAR(45) NOT NULL,
		  `apellido` VARCHAR(45) NOT NULL,
		  `dni` VARCHAR(11) NOT NULL,
		  `fecha_nac` DATE NOT NULL,
		  `email` VARCHAR(100) NOT NULL,
		  `create_time` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
		  PRIMARY KEY (`id`),
		  UNIQUE INDEX `dni_UNIQUE` (`dni` ASC) VISIBLE
		) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`profesor`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`profesor` (
		  `id` INT NOT NULL AUTO_INCREMENT,  
		  `usuario_id` INT NULL,
		  `especialidad` VARCHAR(45) NULL,
		  `asistencia` VARCHAR(45) NULL,
		  `sueldo_mensual` DECIMAL(10,2) NULL, 
		  `fecha_ingreso` DATE NULL,
		  `salon_asignado` VARCHAR(45) NULL,
		  PRIMARY KEY (`id`),
		  INDEX `fk_profesor_usuario_idx` (`usuario_id` ASC) VISIBLE,
		  CONSTRAINT `fk_profesor_usuario`
			FOREIGN KEY (`usuario_id`)
			REFERENCES `u462690221_club`.`usuario` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
		) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`actividad`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`actividad` (
		  `id` INT NOT NULL AUTO_INCREMENT, 
		  `nombre_actividad` VARCHAR(45) NOT NULL,  
		  `tipo` VARCHAR(45) NULL,
		  `horario` INT NOT NULL,
		  `profesor_id` INT NULL,
		  `cupo_max` INT NOT NULL,
		  `precio_diario` DECIMAL(10,2) NULL,
		  `precio_mensual` DECIMAL(10,2) NULL,
		  PRIMARY KEY (`id`),
		  INDEX `profesor_id_idx` (`profesor_id` ASC) VISIBLE,
		  CONSTRAINT `fk_actividad_profesor`
			FOREIGN KEY (`profesor_id`)
			REFERENCES `u462690221_club`.`profesor` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
		) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;

		-- -----------------------------------------------------
		-- Table `u462690221_club`.`cuota`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`cuota` (
		`id` int NOT NULL AUTO_INCREMENT,
		`socio_id` int DEFAULT NULL,
		`no_socio_id` int DEFAULT NULL,
		`monto` decimal(10,2) NOT NULL,
		`fecha_emision` date NOT NULL,
		`fecha_vencimiento` date DEFAULT NULL,
		`nombre` varchar(45) DEFAULT NULL,
		`apellido` varchar(45) DEFAULT NULL,
		`estado` tinyint DEFAULT '0',
		`actividad_id` int DEFAULT NULL,
		`es_socio` tinyint NOT NULL DEFAULT '0',
		PRIMARY KEY (`id`),
		KEY `fk_socio_id_idx` (`socio_id`),
		KEY `fk_no_socio_id_idx` (`no_socio_id`),
		KEY `fk_actividad_id_idx` (`actividad_id`),
		CONSTRAINT `fk_no_socio_id` FOREIGN KEY (`no_socio_id`) REFERENCES `u462690221_club`.`noSocio` (`id`),
		CONSTRAINT `fk_socio_id` FOREIGN KEY (`socio_id`) REFERENCES `u462690221_club`.`socio` (`id`),
		CONSTRAINT `fk_cuota_actividad` FOREIGN KEY (`actividad_id`) REFERENCES `u462690221_club`.`actividad` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
		) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;


		-- -----------------------------------------------------
		-- Table `u462690221_club`.`inscripcion`
		-- -----------------------------------------------------
		CREATE TABLE IF NOT EXISTS `u462690221_club`.`inscripcion` (
		  `id` INT NOT NULL AUTO_INCREMENT,  
		  `socio_id` INT NULL,
		  `no_socio_id` INT NULL,
		  `actividad_id` INT NOT NULL,  
		  `fecha_inscripcion` DATE NOT NULL,  
		  `estado` TINYINT NULL DEFAULT 1,
		 
		  PRIMARY KEY (`id`),
		  INDEX `fk_inscripcion_socio_idx` (`socio_id` ASC) VISIBLE,
		  INDEX `fk_inscripcion_nosocio_idx` (`no_socio_id` ASC) VISIBLE,
		  INDEX `fk_inscripcion_actividad_idx` (`actividad_id` ASC) VISIBLE,
		  CONSTRAINT `fk_inscripcion_socio`  
			FOREIGN KEY (`socio_id`)
			REFERENCES `u462690221_club`.`socio` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION,
		  CONSTRAINT `fk_inscripcion_nosocio`
			FOREIGN KEY (`no_socio_id`)
			REFERENCES `u462690221_club`.`noSocio` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION,
		  CONSTRAINT `fk_inscripcion_actividad`
			FOREIGN KEY (`actividad_id`)
			REFERENCES `u462690221_club`.`actividad` (`id`)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION,
		  CONSTRAINT `chk_inscripcion_participante` 
			CHECK ((socio_id IS NOT NULL AND no_socio_id IS NULL) OR 
				   (socio_id IS NULL AND no_socio_id IS NOT NULL))
		) ENGINE = InnoDB DEFAULT CHARSET=utf8mb4;;

		SET FOREIGN_KEY_CHECKS = 1;";


		//en estos scripts van los datos iniciales para la BBDD
		
		public static string InsertInitialData => @"
		INSERT INTO u462690221_club.rol(name) VALUES('Admin');
		INSERT INTO u462690221_club.rol(name) VALUES('Profesor');

		
		
		INSERT INTO `u462690221_club`.`usuario` (`nombre`, `email`, `contrasenia`, `rol_id`) VALUES
		('admin', 'admin@sistema.com','admin',1),
		('Prof. Natación', 'profe.natacion@club.com', 'password123', 2),
		('Prof. Musculación', 'profe.musculacion@club.com', 'password123', 2),
		('Prof. Yoga', 'profe.yoga@club.com', 'password123', 2),
		('Prof. CrossFit', 'profe.crossfit@club.com', 'password123', 2),
		('Prof. Pilates', 'profe.pilates@club.com', 'password123', 2),
		('Prof. Natación Infantil', 'profe.natacion.infantil@club.com', 'password123', 2),
		('Prof. Artes Marciales', 'profe.artes.marciales@club.com', 'password123', 2),
		('Prof. Danza Aeróbica', 'profe.danza@club.com', 'password123', 2),
		('Prof. Entrenamiento Funcional', 'profe.funcional@club.com', 'password123', 2),
		('Prof. Spinning', 'profe.spinning@club.com', 'password123', 2);


		INSERT INTO u462690221_club.socio (`nombre`, `apellido`, `dni`, `fecha_nac`, `email`, `fecha_emision`, `create_time`) VALUES
		('Juan', 'Pérez', '30123456', '1985-03-15', 'juan.perez@email.com', '2023-01-10', '2024-01-18 08:15:00'),
		('María', 'González', '32123457', '1990-07-22', 'maria.gonzalez@email.com', '2023-02-15', '2024-01-12 11:30:00'),
		('Carlos', 'Rodríguez', '34123458', '1988-11-30', 'carlos.rodriguez@email.com', '2023-03-20', '2024-01-05 14:45:00'),
		('Ana', 'López', '36123459', '1992-05-08', 'ana.lopez@email.com', '2023-04-25', '2023-12-22 09:20:00'),
		('Luis', 'Martínez', '38123460', '1987-09-14', 'luis.martinez@email.com', '2023-05-30', '2023-12-10 16:35:00'),
		('Laura', 'García', '40123461', '1995-12-03', 'laura.garcia@email.com', '2023-06-05', '2023-11-28 13:10:00'),
		('Diego', 'Hernández', '42123462', '1983-08-19', 'diego.hernandez@email.com', '2023-07-10', '2023-11-15 10:25:00'),
		('Sofía', 'Díaz', '44123463', '1991-04-25', 'sofia.diaz@email.com', '2023-08-15', '2023-11-03 15:40:00'),
		('Pedro', 'Sánchez', '46123464', '1986-06-11', 'pedro.sanchez@email.com', '2023-09-20', '2023-10-20 12:55:00'),
		('Elena', 'Ramírez', '48123465', '1993-10-07', 'elena.ramirez@email.com', '2023-10-25', '2023-10-08 18:05:00');

		INSERT INTO u462690221_club.noSocio (`nombre`, `apellido`, `dni`, `fecha_nac`, `email`, `create_time`) VALUES
		('Miguel', 'Torres', '50123466', '1994-02-18', 'miguel.torres@email.com', '2024-01-15 09:30:00'),
		('Carmen', 'Flores', '52123467', '1989-07-12', 'carmen.flores@email.com', '2024-01-10 14:20:00'),
		('Jorge', 'Vargas', '54123468', '1996-11-05', 'jorge.vargas@email.com', '2023-12-28 11:45:00'),
		('Isabel', 'Castro', '56123469', '1984-03-29', 'isabel.castro@email.com', '2023-12-15 16:10:00'),
		('Fernando', 'Reyes', '58123470', '1997-09-16', 'fernando.reyes@email.com', '2023-11-30 08:55:00'),
		('Patricia', 'Morales', '60123471', '1990-01-22', 'patricia.morales@email.com', '2023-11-20 13:40:00'),
		('Ricardo', 'Ortega', '62123472', '1982-12-08', 'ricardo.ortega@email.com', '2023-11-05 10:15:00'),
		('Diana', 'Guerrero', '64123473', '1998-04-14', 'diana.guerrero@email.com', '2023-10-25 15:30:00'),
		('Roberto', 'Mendoza', '66123474', '1981-06-30', 'roberto.mendoza@email.com', '2023-10-10 12:25:00'),
		('Adriana', 'Rojas', '68123475', '1999-08-26', 'adriana.rojas@email.com', '2023-09-28 17:50:00');

		INSERT INTO u462690221_club.profesor (`especialidad`, `asistencia`, `sueldo_mensual`, `fecha_ingreso`, `salon_asignado`) VALUES
		('Natación', 'Regular', 85000.00, '2022-03-15', 'Pileta Principal'),
		('Musculación', 'Excelente', 78000.00, '2021-06-10', 'Sala de Pesas A'),
		('Yoga', 'Buena', 72000.00, '2023-01-20', 'Sala de Yoga'),
		('CrossFit', 'Excelente', 90000.00, '2020-11-05', 'Box CrossFit'),
		('Pilates', 'Regular', 75000.00, '2022-09-12', 'Sala de Pilates'),
		('Natación Adultos', 'Excelente', 88000.00, '2021-08-22', 'Pileta Olímpica'),
		('Artes Marciales', 'Buena', 82000.00, '2022-05-30', 'Dojo Central'),
		('Danza Aeróbica', 'Regular', 68000.00, '2023-03-10', 'Sala de Baile 1'),
		('Entrenamiento Funcional', 'Excelente', 86000.00, '2020-12-15', 'Área Funcional'),
		('Spinning', 'Buena', 79000.00, '2022-11-08', 'Sala de Spinning');


		INSERT INTO u462690221_club.actividad (`nombre_actividad`, `tipo`, `horario`, `profesor_id`, `cupo_max`, `precio_diario`, `precio_mensual`) VALUES
		('Natación Principiantes', 'Acuático', 800, 1, 15, 500.00, 3500.00),
		('Natación Avanzada', 'Acuático', 1700, 1, 12, 600.00, 4000.00),
		('Musculación Básica', 'Fuerza', 900, 2, 20, 400.00, 2800.00),
		('Musculación Avanzada', 'Fuerza', 1800, 2, 15, 500.00, 3200.00),
		('Yoga Matutino', 'Relajación', 700, 3, 25, 350.00, 2200.00),
		('Yoga Vespertino', 'Relajación', 1900, 3, 25, 350.00, 2200.00),
		('CrossFit AM', 'Funcional', 600, 4, 18, 600.00, 3800.00),
		('CrossFit PM', 'Funcional', 1830, 4, 18, 600.00, 3800.00),
		('Pilates Suelo', 'Flexibilidad', 1000, 5, 20, 450.00, 3000.00),
		('Pilates Maquinas', 'Flexibilidad', 1600, 5, 10, 550.00, 3500.00),
		('Natación Infantil', 'Acuático', 1500, 6, 12, 400.00, 2800.00),
		('Natación Tercera Edad', 'Acuático', 1100, 6, 10, 350.00, 2000.00),
		('Kárate', 'Artes Marciales', 1700, 7, 25, 450.00, 3000.00),
		('Judo', 'Artes Marciales', 1900, 7, 20, 450.00, 3000.00),
		('Zumba', 'Baile', 1800, 8, 30, 300.00, 1800.00),
		('Ritmos Latinos', 'Baile', 2000, 8, 25, 350.00, 2200.00),
		('Entrenamiento Funcional', 'Funcional', 700, 9, 15, 500.00, 3200.00),
		('Circuito Training', 'Funcional', 1830, 9, 15, 500.00, 3200.00),
		('Spinning Mañana', 'Cardio', 800, 10, 15, 400.00, 2500.00),
		('Spinning Tarde', 'Cardio', 1930, 10, 15, 400.00, 2500.00);


	
		INSERT INTO `u462690221_club`.`cuota` 
		(`socio_id`, `monto`, `fecha_emision`, `fecha_vencimiento`, `nombre`, `apellido`, `estado`, `actividad_id`, `es_socio`) VALUES
		(1, 3500.00, '2024-10-01', '2024-10-31', 'Juan', 'Pérez', 1, 1, 1),		
		(2, 3500.00, '2024-11-01', '2024-11-12', 'María', 'González', 0, 2, 1),
		(3, 2800.00, '2024-11-01', '2024-11-12', 'Carlos', 'Rodríguez', 0, 3, 1),	
		(4, 4000.00, '2024-11-01', '2024-11-30', 'Ana', 'López', 1, 4, 1),
		(5, 3200.00, '2024-11-01', '2024-11-12', 'Luis', 'Martínez', 0, 5, 1);

		INSERT INTO `u462690221_club`.`cuota` 
		(`socio_id`, `monto`, `fecha_emision`, `fecha_vencimiento`, `nombre`, `apellido`, `estado`, `actividad_id`, `es_socio`) VALUES
		(1, 3500.00, '2024-10-01', '2024-10-31', 'Juan', 'Pérez', 1, 1, 1),
		(2, 3500.00, '2024-10-01', '2024-10-31', 'María', 'González', 1, 2, 1),
		(3, 2800.00, '2024-10-01', '2024-10-31', 'Carlos', 'Rodríguez', 1, 3, 1),
		(4, 4000.00, '2024-10-01', '2024-10-31', 'Ana', 'López', 1, 4, 1),
		(5, 3200.00, '2024-10-01', '2024-10-31', 'Luis', 'Martínez', 1, 5, 1),
		(1, 3500.00, '2024-09-01', '2024-09-30', 'Juan', 'Pérez', 1, 1, 1),
		(2, 3500.00, '2024-09-01', '2024-09-30', 'María', 'González', 1, 2, 1),
		(3, 2800.00, '2024-09-01', '2024-09-30', 'Carlos', 'Rodríguez', 1, 3, 1),
		(4, 2200.00, '2024-08-15', '2024-09-15', 'Ana', 'López', 1, 6, 1),
		(5, 3800.00, '2024-08-10', '2024-09-10', 'Luis', 'Martínez', 0, 7, 1),
		(1, 3000.00, '2024-07-01', '2024-07-31', 'Juan', 'Pérez', 1, 8, 1),
		(2, 2500.00, '2024-07-05', '2024-08-05', 'María', 'González', 1, 9, 1);

		
";
    }

}
