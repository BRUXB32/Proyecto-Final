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
-- Table structure for table `Sectores`
--

DROP TABLE IF EXISTS `Sectores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Sectores` (
  `IdPredio` int NOT NULL,
  `IdSector` int NOT NULL,
  `IdP` int DEFAULT NULL,
  `TamañoSec` int NOT NULL,
  `Etapa` enum('Recien Plantado','Z2.2','Z3.3','Reposo','Libre') DEFAULT NULL,
  `CambioEstado` date DEFAULT NULL,
  PRIMARY KEY (`IdPredio`,`IdSector`),
  KEY `IdP` (`IdP`),
  CONSTRAINT `Sectores_ibfk_1` FOREIGN KEY (`IdPredio`) REFERENCES `Predios` (`IdPredio`),
  CONSTRAINT `Sectores_ibfk_2` FOREIGN KEY (`IdP`) REFERENCES `ProdEIns` (`IdPoI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Sectores`
--

LOCK TABLES `Sectores` WRITE;
/*!40000 ALTER TABLE `Sectores` DISABLE KEYS */;
INSERT INTO `Sectores` VALUES (1,1,6,3,'Recien Plantado',NULL),(1,2,7,3,'Recien Plantado',NULL),(1,3,6,3,'Reposo',NULL),(1,4,7,3,'Reposo',NULL),(2,1,1,2,'Recien Plantado',NULL),(2,2,2,2,'Recien Plantado',NULL),(2,3,3,2,'Recien Plantado',NULL),(2,4,1,2,'Reposo',NULL),(2,5,2,2,'Reposo',NULL),(2,6,3,2,'Reposo',NULL);
/*!40000 ALTER TABLE `Sectores` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-03 17:06:51
