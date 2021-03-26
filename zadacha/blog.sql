
CREATE DATABASE blogtest;

CREATE TABLE `articles` (
  `Id_article` int NOT NULL AUTO_INCREMENT,
  `name` varchar(10) NOT NULL,
  `content` varchar(50) DEFAULT NULL,
  `publ` date DEFAULT NULL,
  `id_autor` int NOT NULL,
  PRIMARY KEY (`Id_article`),
  KEY `id_autor` (`id_autor`),
  CONSTRAINT `articles_ibfk_1` FOREIGN KEY (`id_autor`) REFERENCES `autors` (`Id_autor`)
) ;

CREATE TABLE `autors` (
  `Id_autor` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_autor`)
) ;

CREATE TABLE `users` (
  `Id_user` int NOT NULL AUTO_INCREMENT,
  `name` varchar(15) NOT NULL,
  `pass` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`Id_user`)
) ;
