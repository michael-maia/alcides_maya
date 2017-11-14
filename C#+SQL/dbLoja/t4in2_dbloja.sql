/*
SQLyog Community v9.63 
MySQL - 5.5.8 : Database - t4in2_dbloja
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`t4in2_dbloja` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `t4in2_dbloja`;

/*Table structure for table `amigos` */

DROP TABLE IF EXISTS `amigos`;

CREATE TABLE `amigos` (
  `codigo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(80) DEFAULT NULL,
  `endereco` varchar(80) DEFAULT NULL,
  `cidade` varchar(80) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `cep` char(9) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `amigos` */

insert  into `amigos`(`codigo`,`nome`,`endereco`,`cidade`,`estado`,`cep`) values (1,'amigo 1','rua 1','Porto Alegre','RS','90000-000'),(2,'amigo 2','rua 2','Porto alegre','RS','90000-000'),(3,'amigo 3','rua 3','Porto alegre','RS','90000-000');

/*Table structure for table `clientes` */

DROP TABLE IF EXISTS `clientes`;

CREATE TABLE `clientes` (
  `codigo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(80) DEFAULT NULL,
  `endereco` varchar(80) DEFAULT NULL,
  `cidade` varchar(80) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `cep` char(9) DEFAULT NULL,
  `dataNascimento` datetime DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

/*Data for the table `clientes` */

insert  into `clientes`(`codigo`,`nome`,`endereco`,`cidade`,`estado`,`cep`,`dataNascimento`) values (1,'Elias Baiano','Rua x, 10','Viamão','RS','97000-000','1910-12-28 00:00:00'),(2,'Rubens Xuxa','Rua y, 20','Porto Alegre','RS','90000-000','1980-08-16 00:00:00'),(3,'Vava Rita Lee','Rua x, 30','Porto Alegre','RS','90000-000','1999-12-12 00:00:00'),(4,'Antonio White','Rua yy, 10','São Leopoldo','RS','93000-000','1962-09-30 00:00:00'),(5,'Vitor Leonel','Rua xx, 23','Porto Alegre','RS','90000-000','1999-12-07 00:00:00'),(6,'Marcio Lulu Santos','Rua ww, 20','Porto Alegre','RS','92000-000','2000-03-24 00:00:00'),(7,'Vidal Morales','Rua xx,20','Canoas','RS','94000-000','1998-12-24 00:00:00'),(8,'Lucas Qualhada','Rua rr,34','Porto Alegre','RS','95000-000','1999-11-12 00:00:00');

/*Table structure for table `fornecedores` */

DROP TABLE IF EXISTS `fornecedores`;

CREATE TABLE `fornecedores` (
  `Codigo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nomeEmpresa` varchar(80) DEFAULT NULL,
  `endereco` varchar(80) DEFAULT NULL,
  `cidade` varchar(80) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `CEP` char(9) DEFAULT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `fornecedores` */

insert  into `fornecedores`(`Codigo`,`nomeEmpresa`,`endereco`,`cidade`,`estado`,`CEP`) values (1,'Hering','Rua x, 30','Sao Paulo','SP','79000-00'),(2,'Fiat Lux','Rua y, 22','Rio de Janeiro','RJ','88000-222'),(3,'Ervateira Barão','Rua z, 57','Porto Alegre','RS','90000-000');

/*Table structure for table `produtos` */

DROP TABLE IF EXISTS `produtos`;

CREATE TABLE `produtos` (
  `codigo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nomeProduto` varchar(80) DEFAULT NULL,
  `precoUnitario` decimal(10,0) DEFAULT NULL,
  `qtdEstoque` int(11) DEFAULT NULL,
  `codigoFornec` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `produtos` */

insert  into `produtos`(`codigo`,`nomeProduto`,`precoUnitario`,`qtdEstoque`,`codigoFornec`) values (1,'Fósforo da Luz','1',150,2),(2,'Camiseta branca','30',100,1),(3,'Camiseta Verde','15',100,1),(4,'Erva Mate Barão','12',10,3),(5,'Erva Cultivada','13',30,3);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
