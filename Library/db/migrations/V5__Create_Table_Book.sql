CREATE TABLE IF NOT EXISTS `book` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `title` varchar(200) NOT NULL,
  `description` varchar(2000) NOT NULL,
  `registerDate` date NOT NULL,
  `alterDate` date NOT NULL,
  `idCategory` int(11) NOT NULL,
  `author` varchar(100) NOT NULL,
  `publishDate` date NOT NULL,
  
  PRIMARY KEY (`id`)
) 