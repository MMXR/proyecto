-- MySQL dump 10.16  Distrib 10.1.35-MariaDB, for Win32 (AMD64)
--
-- Host: 127.0.0.1    Database: almacenxmmr
-- ------------------------------------------------------
-- Server version	10.1.35-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `nif` varchar(9) COLLATE utf8_unicode_ci NOT NULL,
  `nombre` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `direccion` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `lugarEntrega` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`nif`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empresa` (
  `nif` varchar(9) COLLATE utf8_unicode_ci NOT NULL,
  `nombre` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `dirección` varchar(55) COLLATE utf8_unicode_ci NOT NULL,
  `logo` varchar(95) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`nif`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estante`
--

DROP TABLE IF EXISTS `estante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estante` (
  `altura` int(11) NOT NULL,
  `fila` int(11) NOT NULL,
  `estateria_idestateria` int(11) NOT NULL,
  PRIMARY KEY (`altura`,`fila`,`estateria_idestateria`),
  KEY `fk_estante_estateria1` (`estateria_idestateria`),
  CONSTRAINT `fk_estante_estateria1` FOREIGN KEY (`estateria_idestateria`) REFERENCES `estateria` (`idestateria`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estante`
--

LOCK TABLES `estante` WRITE;
/*!40000 ALTER TABLE `estante` DISABLE KEYS */;
/*!40000 ALTER TABLE `estante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estateria`
--

DROP TABLE IF EXISTS `estateria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estateria` (
  `idestateria` int(11) NOT NULL AUTO_INCREMENT,
  `numAlturas` int(11) NOT NULL,
  `numFilas` int(11) NOT NULL,
  PRIMARY KEY (`idestateria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estateria`
--

LOCK TABLES `estateria` WRITE;
/*!40000 ALTER TABLE `estateria` DISABLE KEYS */;
/*!40000 ALTER TABLE `estateria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `familia`
--

DROP TABLE IF EXISTS `familia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `familia` (
  `codFamilia` int(1) NOT NULL,
  `idString` varchar(2) COLLATE utf8_unicode_ci DEFAULT NULL,
  `descripcion` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`codFamilia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `familia`
--

LOCK TABLES `familia` WRITE;
/*!40000 ALTER TABLE `familia` DISABLE KEYS */;
/*!40000 ALTER TABLE `familia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marca` (
  `idmarca` int(11) NOT NULL,
  `nombre` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idmarca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `codigo` varchar(13) COLLATE utf8_unicode_ci NOT NULL,
  `descripcion` varchar(55) COLLATE utf8_unicode_ci NOT NULL,
  `precio` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `stock` int(11) NOT NULL,
  `subfamilia_codSF` int(1) NOT NULL,
  `subfamilia_familia_codFamilia` int(1) NOT NULL,
  `marca_idmarca` int(11) NOT NULL,
  `pesoNeto` decimal(10,0) NOT NULL,
  `pesoBruto` decimal(10,0) NOT NULL,
  PRIMARY KEY (`codigo`,`subfamilia_codSF`,`subfamilia_familia_codFamilia`),
  KEY `fk_producto_subfamilia1` (`subfamilia_codSF`,`subfamilia_familia_codFamilia`),
  KEY `fk_producto_marca1` (`marca_idmarca`),
  CONSTRAINT `fk_producto_marca1` FOREIGN KEY (`marca_idmarca`) REFERENCES `marca` (`idmarca`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_producto_subfamilia1` FOREIGN KEY (`subfamilia_codSF`, `subfamilia_familia_codFamilia`) REFERENCES `subfamilia` (`codSF`, `familia_codFamilia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto_has_estante`
--

DROP TABLE IF EXISTS `producto_has_estante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto_has_estante` (
  `producto_codigo` varchar(13) COLLATE utf8_unicode_ci NOT NULL,
  `estante_altura` int(11) NOT NULL,
  `estante_fila` int(11) NOT NULL,
  `estante_estateria_idestateria` int(11) NOT NULL,
  PRIMARY KEY (`producto_codigo`,`estante_altura`,`estante_fila`,`estante_estateria_idestateria`),
  KEY `fk_producto_has_estante_estante1` (`estante_altura`,`estante_fila`,`estante_estateria_idestateria`),
  CONSTRAINT `fk_producto_has_estante_estante1` FOREIGN KEY (`estante_altura`, `estante_fila`, `estante_estateria_idestateria`) REFERENCES `estante` (`altura`, `fila`, `estateria_idestateria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_producto_has_estante_producto1` FOREIGN KEY (`producto_codigo`) REFERENCES `producto` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto_has_estante`
--

LOCK TABLES `producto_has_estante` WRITE;
/*!40000 ALTER TABLE `producto_has_estante` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto_has_estante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subfamilia`
--

DROP TABLE IF EXISTS `subfamilia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subfamilia` (
  `codSF` int(1) NOT NULL,
  `idCaracter` varchar(2) COLLATE utf8_unicode_ci NOT NULL,
  `descripcion` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `familia_codFamilia` int(1) NOT NULL,
  PRIMARY KEY (`codSF`,`familia_codFamilia`),
  KEY `fk_subfamilia_familia` (`familia_codFamilia`),
  CONSTRAINT `fk_subfamilia_familia` FOREIGN KEY (`familia_codFamilia`) REFERENCES `familia` (`codFamilia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subfamilia`
--

LOCK TABLES `subfamilia` WRITE;
/*!40000 ALTER TABLE `subfamilia` DISABLE KEYS */;
/*!40000 ALTER TABLE `subfamilia` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-12-05  8:22:27
