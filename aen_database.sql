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
CREATE TABLE `class` (
  `class_ID` int(11) NOT NULL,
  `class_start` date NOT NULL,
  `start_number` int(11) NOT NULL,
  `character_sign` varchar(2) COLLATE utf8_hungarian_ci NOT NULL,
  ` class_year` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `class` (`class_ID`, `class_start`, `start_number`, `character_sign`, ` class_year`) VALUES
(1, '2010-09-01', 1, 'A', 1);

DROP TABLE IF EXISTS `lesson`;
CREATE TABLE `lesson` (
  `lesson_ID` int(11) NOT NULL,
  `date` date NOT NULL,
  `hour` int(11) NOT NULL,
  `content` varchar(200) COLLATE utf8_hungarian_ci NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `class_ID` int(11) NOT NULL,
  `subject_ID` int(11) NOT NULL,
  `substituting` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

DROP TABLE IF EXISTS `mark`;
CREATE TABLE `mark` (
  `mark_ID` int(11) NOT NULL,
  `student_ID` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `subject_ID` int(11) NOT NULL,
  `description` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `weighting` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

DROP TABLE IF EXISTS `omission`;
CREATE TABLE `omission` (
  `omission_ID` int(11) NOT NULL,
  `student_ID` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `date` date NOT NULL,
  `hour` int(11) NOT NULL,
  `delay` bit(1) NOT NULL,
  `certify` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

DROP TABLE IF EXISTS `parent`;
CREATE TABLE `parent` (
  `parent_ID` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `born_date` date NOT NULL,
  `user_name` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `active` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `parent` (`parent_ID`, `name`, `born_date`, `user_name`, `password`, `teacher_ID`, `active`) VALUES
(1, 'Kasszás Erzsébet', '1968-02-12', 'KaEr', 'valami', 1, b'1');

DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `student_ID` int(11) NOT NULL,
  `name` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `born_date` date NOT NULL,
  `user_name` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `parent_ID` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `class_ID` int(11) NOT NULL,
  `active` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `student` (`student_ID`, `name`, `born_date`, `user_name`, `password`, `parent_ID`, `teacher_ID`, `class_ID`, `active`) VALUES
(3, ' Jhon Snow', '1996-04-08', 'JhSn', 'nem', 1, 1, 1, b'1');

DROP TABLE IF EXISTS `subject`;
CREATE TABLE `subject` (
  `subject_ID` int(11) NOT NULL,
  `subject_name` varchar(25) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

DROP TABLE IF EXISTS `teacher`;
CREATE TABLE `teacher` (
  `teacher_ID` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `born_date` date NOT NULL,
  `user_name` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `active` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `teacher` (`teacher_ID`, `name`, `born_date`, `user_name`, `password`, `active`) VALUES
(1, 'Teszt Elemér', '1960-02-18', 'TeEl', '1234', b'1');


ALTER TABLE `class`
  ADD PRIMARY KEY (`class_ID`);

ALTER TABLE `lesson`
  ADD PRIMARY KEY (`lesson_ID`),
  ADD KEY `teacher_ID` (`teacher_ID`,`class_ID`),
  ADD KEY `class_ID` (`class_ID`),
  ADD KEY `subject_ID` (`subject_ID`);

ALTER TABLE `mark`
  ADD PRIMARY KEY (`mark_ID`),
  ADD KEY `teacher_ID` (`teacher_ID`),
  ADD KEY `student_ID` (`student_ID`,`subject_ID`),
  ADD KEY `subject_ID` (`subject_ID`);

ALTER TABLE `omission`
  ADD PRIMARY KEY (`omission_ID`),
  ADD KEY `student_ID` (`student_ID`,`teacher_ID`),
  ADD KEY `teacher_ID` (`teacher_ID`);

ALTER TABLE `parent`
  ADD PRIMARY KEY (`parent_ID`),
  ADD KEY `teacher_ID` (`teacher_ID`);

ALTER TABLE `student`
  ADD PRIMARY KEY (`student_ID`),
  ADD KEY `parent_ID` (`parent_ID`,`teacher_ID`,`class_ID`),
  ADD KEY `class_ID` (`class_ID`),
  ADD KEY `teacher_ID` (`teacher_ID`);

ALTER TABLE `subject`
  ADD PRIMARY KEY (`subject_ID`);

ALTER TABLE `teacher`
  ADD PRIMARY KEY (`teacher_ID`);


ALTER TABLE `class`
  MODIFY `class_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

ALTER TABLE `lesson`
  MODIFY `lesson_ID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `mark`
  MODIFY `mark_ID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `omission`
  MODIFY `omission_ID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `parent`
  MODIFY `parent_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

ALTER TABLE `student`
  MODIFY `student_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

ALTER TABLE `subject`
  MODIFY `subject_ID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `teacher`
  MODIFY `teacher_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;


ALTER TABLE `lesson`
  ADD CONSTRAINT `lesson_ibfk_1` FOREIGN KEY (`teacher_ID`) REFERENCES `teacher` (`teacher_ID`),
  ADD CONSTRAINT `lesson_ibfk_2` FOREIGN KEY (`class_ID`) REFERENCES `class` (`class_ID`),
  ADD CONSTRAINT `lesson_ibfk_3` FOREIGN KEY (`subject_ID`) REFERENCES `subject` (`subject_ID`);

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
