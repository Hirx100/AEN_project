SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

CREATE DATABASE IF NOT EXISTS `aen_database` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `aen_database`;

DELIMITER $$
DROP PROCEDURE IF EXISTS `aenClassSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenClassSelect` ()  NO SQL
BEGIN
Select * from class;
END$$

DROP PROCEDURE IF EXISTS `aenMarkRuningSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenMarkRuningSelect` (IN `_classSign` VARCHAR(2), IN `_classNummer` INT(11), IN `_startDate` DATE, IN `_endDate` DATE, IN `_selectedStudent` VARCHAR(40), IN `_selectedSubject` VARCHAR(40))  NO SQL
BEGIN
SELECT `mark_number`,`description`, subject.subject_name, student.name as student ,`mark_Date`, teacher.name as teacher
FROM mark
INNER JOIN subject on mark.subject_ID= subject.subject_ID
INNER JOIN student on mark.student_ID= student.student_ID
INNER JOIN teacher on mark.teacher_ID= student.student_ID
WHERE student.class_ID=(SELECT class_Id FROM class WHERE class.character_sign= _classSign AND class.class_year=_classNummer)
AND student.name LIKE _selectedStudent
AND subject.subject_name=_selectedSubject
AND mark_Date BETWEEN _startDate AND _endDate
GROUP BY mark.description;
END$$

DROP PROCEDURE IF EXISTS `aenMarkStartSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenMarkStartSelect` (IN `_classSign` VARCHAR(2), IN `_classNummer` INT(11))  NO SQL
BEGIN
SELECT DISTINCT `mark_number`,`description`, subject.subject_name, student.name as student ,`mark_Date`, teacher.name as teacher
FROM mark
INNER JOIN subject on mark.subject_ID= subject.subject_ID
INNER JOIN student on mark.student_ID= student.student_ID
INNER JOIN teacher on mark.teacher_ID= student.student_ID
WHERE student.class_ID=(SELECT class_Id FROM class WHERE class.character_sign= _classSign AND class.class_year=_classNummer)
GROUP BY mark.description;
END$$

DROP PROCEDURE IF EXISTS `aenParentDataSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenParentDataSelect` (IN `_username` VARCHAR(10))  NO SQL
BEGIN
Select * From `parent` where `user_name` = _username; 
END$$

DROP PROCEDURE IF EXISTS `aenParentDataUpdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenParentDataUpdate` (IN `_username` VARCHAR(10), IN `_name` VARCHAR(50), IN `_borndate` DATE, IN `_password` VARCHAR(50))  NO SQL
BEGIN
 UPDATE `parent` 
    SET `name`= _name,
    	`born_date`= _borndate,
        `password`= _password
     WHERE `user_name` = _username;
END$$

DROP PROCEDURE IF EXISTS `aenParentPassSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenParentPassSelect` (IN `_username` VARCHAR(40), IN `_password` VARCHAR(40))  NO SQL
BEGIN
Select * From `parent` where `user_name` = _username and `password` = _password; 
END$$

DROP PROCEDURE IF EXISTS `aenStudentDataSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenStudentDataSelect` (IN `_username` INT(40))  NO SQL
BEGIN
Select * From `student` where `user_name` = _username; 
END$$

DROP PROCEDURE IF EXISTS `aenStudentDataUpdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenStudentDataUpdate` (IN `_username` VARCHAR(10), IN `_name` INT(40), IN `_borndate` DATE, IN `_password` VARCHAR(40))  NO SQL
BEGIN
 UPDATE `student` 
    SET `name`= _name,
    	`born_date`= _borndate,
        `password`= _password
     WHERE `user_name` = _username;
END$$

DROP PROCEDURE IF EXISTS `aenStudentPassSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenStudentPassSelect` (IN `_username` VARCHAR(40), IN `_password` VARCHAR(40))  NO SQL
BEGIN
Select * From `student` where `user_name` = _username and `password` = _password; 
END$$

DROP PROCEDURE IF EXISTS `aenStudentsSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenStudentsSelect` ()  NO SQL
BEGIN
Select * From student; 
END$$

DROP PROCEDURE IF EXISTS `aenSubjectSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenSubjectSelect` ()  NO SQL
BEGIN
Select * from subject;
END$$

DROP PROCEDURE IF EXISTS `aenTeacherDataSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenTeacherDataSelect` (IN `_username` VARCHAR(40))  NO SQL
BEGIN
Select * From `teacher` where `user_name` = _username; 
END$$

DROP PROCEDURE IF EXISTS `aenTeacherDataUpdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenTeacherDataUpdate` (IN `_username` VARCHAR(40), IN `_name` VARCHAR(50), IN `_borndate` DATE, IN `_password` VARCHAR(50))  NO SQL
BEGIN
 UPDATE `teacher` 
    SET `name`= _name,
    	`born_date`= _borndate,
        `password`= _password
     WHERE `user_name` = _username;
END$$

DROP PROCEDURE IF EXISTS `aenTeacherPassSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenTeacherPassSelect` (IN `_username` VARCHAR(50), IN `_password` VARCHAR(50))  BEGIN
Select * From `teacher` where `user_name` = _username and `password` = _password; 
END$$

DELIMITER ;

DROP TABLE IF EXISTS `class`;
CREATE TABLE IF NOT EXISTS `class` (
  `class_ID` int(11) NOT NULL AUTO_INCREMENT,
  `class_start` date NOT NULL,
  `start_number` int(11) NOT NULL,
  `character_sign` varchar(2) COLLATE utf8_hungarian_ci NOT NULL,
  `class_year` int(11) NOT NULL,
  PRIMARY KEY (`class_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `class` (`class_ID`, `class_start`, `start_number`, `character_sign`, `class_year`) VALUES
(1, '2010-09-01', 1, 'A', 1),
(2, '2017-09-01', 1, 'B', 1);

DROP TABLE IF EXISTS `mark`;
CREATE TABLE IF NOT EXISTS `mark` (
  `mark_ID` int(11) NOT NULL AUTO_INCREMENT,
  `student_ID` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `subject_ID` int(11) NOT NULL,
  `mark_number` int(1) NOT NULL,
  `description` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `mark_Date` date NOT NULL,
  PRIMARY KEY (`mark_ID`),
  KEY `teacher_ID` (`teacher_ID`),
  KEY `student_ID` (`student_ID`,`subject_ID`),
  KEY `subject_ID` (`subject_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `mark` (`mark_ID`, `student_ID`, `teacher_ID`, `subject_ID`, `mark_number`, `description`, `mark_Date`) VALUES
(1, 1, 1, 1, 5, 'Ókor csodái.', '2012-05-21'),
(2, 2, 2, 2, 3, 'Összeadás', '2017-05-29'),
(3, 1, 1, 2, 2, 'Kivonás', '2012-05-22'),
(4, 1, 1, 2, 3, 'Szorzás', '2012-05-29');

DROP TABLE IF EXISTS `omission`;
CREATE TABLE IF NOT EXISTS `omission` (
  `omission_ID` int(11) NOT NULL AUTO_INCREMENT,
  `student_ID` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `date` date NOT NULL,
  `hour` int(11) NOT NULL,
  `delay` bit(1) NOT NULL,
  `certify` bit(1) NOT NULL,
  PRIMARY KEY (`omission_ID`),
  KEY `student_ID` (`student_ID`,`teacher_ID`),
  KEY `teacher_ID` (`teacher_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

DROP TABLE IF EXISTS `parent`;
CREATE TABLE IF NOT EXISTS `parent` (
  `parent_ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `born_date` date NOT NULL,
  `user_name` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  PRIMARY KEY (`parent_ID`),
  KEY `teacher_ID` (`teacher_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `parent` (`parent_ID`, `name`, `born_date`, `user_name`, `password`, `teacher_ID`) VALUES
(1, 'Kasszás Erzsébet', '1968-02-12', 'KaEr', 'valami', 1),
(2, 'Boldog Árpád', '1969-02-12', 'BoÁr', 'akármi', 2);

DROP TABLE IF EXISTS `student`;
CREATE TABLE IF NOT EXISTS `student` (
  `student_ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `born_date` date NOT NULL,
  `user_name` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `parent_ID` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `class_ID` int(11) NOT NULL,
  PRIMARY KEY (`student_ID`),
  KEY `parent_ID` (`parent_ID`,`teacher_ID`,`class_ID`),
  KEY `class_ID` (`class_ID`),
  KEY `teacher_ID` (`teacher_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `student` (`student_ID`, `name`, `born_date`, `user_name`, `password`, `parent_ID`, `teacher_ID`, `class_ID`) VALUES
(1, 'Jon Snow', '1996-04-08', 'JoSn', 'nem', 1, 1, 1),
(2, 'Minimum Sára', '1995-05-28', 'MiSá', 'igen1', 2, 2, 2);

DROP TABLE IF EXISTS `subject`;
CREATE TABLE IF NOT EXISTS `subject` (
  `subject_ID` int(11) NOT NULL AUTO_INCREMENT,
  `subject_name` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  PRIMARY KEY (`subject_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `subject` (`subject_ID`, `subject_name`) VALUES
(1, 'Történelem'),
(2, 'Matematika');

DROP TABLE IF EXISTS `teacher`;
CREATE TABLE IF NOT EXISTS `teacher` (
  `teacher_ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `born_date` date NOT NULL,
  `user_name` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  PRIMARY KEY (`teacher_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `teacher` (`teacher_ID`, `name`, `born_date`, `user_name`, `password`) VALUES
(1, 'Teszt Elek', '1960-02-18', 'TeEl', '1234'),
(2, 'Valami Márta', '1960-02-18', 'VaMá', 'tütü');


ALTER TABLE `mark`
  ADD CONSTRAINT `mark_ibfk_1` FOREIGN KEY (`teacher_ID`) REFERENCES `teacher` (`teacher_ID`),
  ADD CONSTRAINT `mark_ibfk_2` FOREIGN KEY (`student_ID`) REFERENCES `student` (`student_ID`),
  ADD CONSTRAINT `mark_ibfk_3` FOREIGN KEY (`subject_ID`) REFERENCES `subject` (`subject_ID`);

ALTER TABLE `omission`
  ADD CONSTRAINT `omission_ibfk_1` FOREIGN KEY (`student_ID`) REFERENCES `student` (`student_ID`),
  ADD CONSTRAINT `omission_ibfk_2` FOREIGN KEY (`teacher_ID`) REFERENCES `teacher` (`teacher_ID`);

ALTER TABLE `parent`
  ADD CONSTRAINT `parent_ibfk_1` FOREIGN KEY (`teacher_ID`) REFERENCES `teacher` (`teacher_ID`);

ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_1` FOREIGN KEY (`class_ID`) REFERENCES `class` (`class_ID`),
  ADD CONSTRAINT `student_ibfk_2` FOREIGN KEY (`teacher_ID`) REFERENCES `teacher` (`teacher_ID`),
  ADD CONSTRAINT `student_ibfk_3` FOREIGN KEY (`parent_ID`) REFERENCES `parent` (`parent_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
