CREATE DATABASE  IF NOT EXISTS `mpoy` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mpoy`;
-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: mpoy
-- ------------------------------------------------------
-- Server version	8.0.28-0ubuntu0.20.04.3

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ProdEIns`
--

DROP TABLE IF EXISTS `ProdEIns`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ProdEIns` (
  `IdPoI` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(25) NOT NULL,
  `Cantidad` double(6,2) NOT NULL,
  `Precio` double(6,2) NOT NULL,
  `Tipo` enum('Fr','V','C','S','Fe','Pe','Pl') NOT NULL,
  `BajaLogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdPoI`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ProdEIns`
--

LOCK TABLES `ProdEIns` WRITE;
/*!40000 ALTER TABLE `ProdEIns` DISABLE KEYS */;
INSERT INTO `ProdEIns` VALUES (1,'Manzanas',5000.00,34.00,'Fr',0),(2,'Naranjas',5000.00,38.00,'Fr',0),(3,'Limones',5000.00,36.00,'Fr',0),(4,'Papas rosadas',5000.00,35.00,'V',0),(5,'Zapallo criollo',5000.00,41.00,'V',0),(6,'Trigo',5000.00,20.00,'C',0),(7,'Cebada',5000.00,25.00,'C',0),(8,'Plantines manzanas',5000.00,14.00,'Pl',0),(9,'Plantines naranjas',5000.00,18.00,'Pl',0),(10,'Plantines limones',5000.00,16.00,'Pl',0),(11,'Semillas papas rosadas',5000.00,15.00,'S',0),(12,'Semillas zapallo criollo',5000.00,21.00,'S',0),(13,'Semillas trigo',4996.00,10.00,'S',0),(14,'Semillas cebada',5000.00,15.00,'S',0),(15,'Fertilizante de fosforo',5000.00,20.00,'Fe',0),(16,'Fertilizante de nitrogeno',5000.00,23.00,'Fe',0),(17,'Pesticidas',5000.00,40.00,'Pe',0);
/*!40000 ALTER TABLE `ProdEIns` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-03 17:06:58
