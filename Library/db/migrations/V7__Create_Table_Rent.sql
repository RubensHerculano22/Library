CREATE TABLE IF NOT EXISTS `rent` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `idUser` int(11) NOT NULL,
  `idBook` int(11) NOT NULL,
  `rentDate` date NOT NULL,
  `devolutionPlanDate` date NOT NULL,
  `devolutionDate` date,
 
  PRIMARY KEY (`id`)
) 