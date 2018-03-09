-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.7.16-log


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema sistema
--

CREATE DATABASE IF NOT EXISTS sistema;
USE sistema;

--
-- Definition of table `cat_usuario`
--

DROP TABLE IF EXISTS `cat_usuario`;
CREATE TABLE `cat_usuario` (
  `id_rango` varchar(5) NOT NULL,
  `rango` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_rango`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cat_usuario`
--

/*!40000 ALTER TABLE `cat_usuario` DISABLE KEYS */;
INSERT INTO `cat_usuario` (`id_rango`,`rango`) VALUES 
 ('1','administrador'),
 ('2','empleado');
/*!40000 ALTER TABLE `cat_usuario` ENABLE KEYS */;


--
-- Definition of table `productos`
--

DROP TABLE IF EXISTS `productos`;
CREATE TABLE `productos` (
  `id_producto` int(15) unsigned NOT NULL AUTO_INCREMENT,
  `nom_producto` varchar(25) DEFAULT NULL,
  `precio` float DEFAULT NULL,
  `cantidad` int(5) DEFAULT NULL,
  PRIMARY KEY (`id_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `productos`
--

/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` (`id_producto`,`nom_producto`,`precio`,`cantidad`) VALUES 
 (1,'bubu lubu',1,14),
 (3,'doritos',9,6),
 (5,'maruchan',5.5,6),
 (6,'carlos v',7,12),
 (7,'cacahuates sabritas',15,3),
 (8,'chetos ',5,5),
 (9,'submarinos',12,4),
 (10,'tang',5.5,10),
 (11,'tostitos',7,6),
 (12,'cerrillos',2.5,12),
 (13,'yogurt danone ',8,5),
 (14,'gatorade',18,9),
 (15,'submarinos',12,12),
 (16,'ciel 1 L',8,7),
 (17,'atun dolores ',11,8),
 (18,'aceite 123',28,2),
 (19,'fabuloso',12,6),
 (20,'bolsa de arroz',15,2),
 (21,'Nutri Leche',10,8),
 (24,'Galletas Maria',8,8),
 (25,'Tajin',8.5,12);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;


--
-- Definition of table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `id_usuario` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) DEFAULT NULL,
  `apepat` varchar(30) DEFAULT NULL,
  `apemat` varchar(30) DEFAULT NULL,
  `id_rango` varchar(20) DEFAULT NULL,
  `contrasena` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_usuario`),
  KEY `id_rango` (`id_rango`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuarios`
--

/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`id_usuario`,`nombre`,`apepat`,`apemat`,`id_rango`,`contrasena`) VALUES 
 (1,'ernesto','gonzalez','garcia','1','ernesto'),
 (2,'jose','Granada','Teodoro','1','jose'),
 (3,'Anelly','Hernandez','Ramirez','2','anelly'),
 (4,'Sergio','Velazquez','Perez','2','checo');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;


--
-- Definition of table `venta`
--

DROP TABLE IF EXISTS `venta`;
CREATE TABLE `venta` (
  `id_venta` int(11) DEFAULT '1',
  `fecha_venta` varchar(30) DEFAULT NULL,
  `producto` varchar(30) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `cp_vendidos` int(11) DEFAULT NULL,
  `nombre_usuario` varchar(10) DEFAULT NULL,
  `subtotal` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `venta`
--

/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` (`id_venta`,`fecha_venta`,`producto`,`precio`,`cp_vendidos`,`nombre_usuario`,`subtotal`) VALUES 
 (1,'27/08/2017','gatorade',18,1,'jose',18),
 (1,'27/08/2017','carlos v',7,2,'jose',14),
 (2,'27/08/2017','bubu lubu',1,2,'jose',2),
 (2,'27/08/2017','maruchan',5.5,1,'jose',5.5),
 (1,'27/08/2017','doritos',9,2,'jose',18);
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
