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
DROP PROCEDURE IF EXISTS `aenClassDelete`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenClassDelete` (IN `_class_id` INT(11))  NO SQL
BEGIN
DELETE FROM class WHERE class.class_ID=_class_id;
END$$

DROP PROCEDURE IF EXISTS `aenClassInsert`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenClassInsert` (IN `_insertSign` VARCHAR(2), IN `_insertYear` INT(1), IN `_insertStartNumer` INT(1), IN `_insertStartDate` DATE)  NO SQL
BEGIN
INSERT INTO `class`(`class_start`, `start_number`, `character_sign`, `class_year`) VALUES (_insertStartDate,_insertStartNumer,_insertSign,_insertYear);
END$$

DROP PROCEDURE IF EXISTS `aenClassSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenClassSelect` ()  NO SQL
BEGIN
Select * from class;
END$$

DROP PROCEDURE IF EXISTS `aenClassUpdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenClassUpdate` (IN `_updateClassID` INT(11), IN `_startDate` DATE, IN `_updateStartClassNumber` INT(2), IN `_updateClassSign` VARCHAR(2), IN `_updateClassYear` INT(2))  NO SQL
BEGIN
UPDATE `class` SET `class_start`=_startDate,`start_number`=_updateStartClassNumber,`character_sign`=_updateClassSign,
`class_year`=_updateClassYear WHERE class_ID= _updateClassID;
END$$

DROP PROCEDURE IF EXISTS `aenMarkDelete`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenMarkDelete` (IN `_mark_ID` INT)  NO SQL
BEGIN
DELETE FROM mark
WHERE mark.mark_ID= _mark_ID;
END$$

DROP PROCEDURE IF EXISTS `aenMarkInstert`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenMarkInstert` (IN `_studentName` VARCHAR(40), IN `_teacherName` VARCHAR(40), IN `_subjectName` VARCHAR(40), IN `_markNumber` INT(1), IN `_description` VARCHAR(100), IN `_markDate` DATE)  NO SQL
BEGIN
INSERT INTO `mark`(`student_ID`, `teacher_ID`, `subject_ID`, `mark_number`, `description`, `mark_Date`) 
VALUES 
(
(SELECT student_ID FROM student WHERE student.name=_studentName),
(SELECT teacher_ID FROM teacher WHERE teacher.name= _teacherName),
(SELECT subject_ID FROM subject WHERE subject.subject_name=_subjectName),
_markNumber,_description,
_markDate);
END$$

DROP PROCEDURE IF EXISTS `aenMarkRuningSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenMarkRuningSelect` (IN `_classSign` VARCHAR(2), IN `_classNummer` INT(11), IN `_startDate` DATE, IN `_endDate` DATE, IN `_selectedStudent` VARCHAR(40), IN `_selectedSubject` VARCHAR(40))  NO SQL
BEGIN
SELECT `mark_number`,`description`, subject.subject_name, student.name as student ,`mark_Date`, teacher.name as teacher, mark.mark_ID
FROM mark
INNER JOIN subject on mark.subject_ID= subject.subject_ID
INNER JOIN student on mark.student_ID= student.student_ID
INNER JOIN teacher on mark.teacher_ID= student.student_ID
WHERE student.class_ID=(SELECT class_Id FROM class WHERE class.character_sign= _classSign AND class.class_year=_classNummer)
AND student.name LIKE _selectedStudent
AND subject.subject_name=_selectedSubject
AND mark_Date BETWEEN _startDate AND _endDate
GROUP BY mark.mark_ID;
END$$

DROP PROCEDURE IF EXISTS `aenMarkStartSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenMarkStartSelect` (IN `_classSign` VARCHAR(2), IN `_classNummer` INT(11))  NO SQL
BEGIN
SELECT `mark_number`,`description`, subject.subject_name, student.name as student ,`mark_Date`, teacher.name as teacher, mark.mark_ID
FROM mark
INNER JOIN subject on mark.subject_ID= subject.subject_ID
INNER JOIN student on mark.student_ID= student.student_ID
INNER JOIN teacher on mark.teacher_ID= student.student_ID
WHERE student.class_ID=(SELECT class_Id FROM class WHERE class.character_sign= _classSign AND class.class_year=_classNummer)
GROUP BY mark.mark_ID;
END$$

DROP PROCEDURE IF EXISTS `aenMarkUpdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenMarkUpdate` (IN `_updateStudent` VARCHAR(40), IN `_updateTeacher` VARCHAR(40), IN `_updateSubject` VARCHAR(40), IN `_updateMarkNummer` INT(1), IN `_updateDescription` VARCHAR(100), IN `_updateMarkDate` DATE, IN `_updateMarkID` INT(11))  NO SQL
BEGIN
UPDATE mark
SET 
mark.student_ID=(SELECT student.student_ID FROM student WHERE student.name=_updateStudent),

mark.teacher_ID=(SELECT teacher.teacher_ID FROM teacher WHERE teacher.name=_updateTeacher),

mark.subject_ID=(SELECT subject.subject_ID FROM subject WHERE subject.subject_name=_updateSubject),

mark.mark_number=_updateMarkNummer,

mark.description=_updateDescription,

mark.mark_Date=_updateMarkDate
WHERE mark.mark_ID=_UpdateMarkID;
END$$

DROP PROCEDURE IF EXISTS `aenOmissionDelete`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenOmissionDelete` (IN `_omission_ID` INT(11))  NO SQL
BEGIN
DELETE FROM mark
WHERE omission.omission_ID= _omission_ID;
END$$

DROP PROCEDURE IF EXISTS `aenOmissionInsert`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenOmissionInsert` (IN `_studentName` VARCHAR(40), IN `_teacherName` VARCHAR(40), IN `_omissionDate` DATE, IN `_omissionHour` INT(1), IN `_omissionDelay` BIT(1), IN `_certify` BIT(1))  NO SQL
BEGIN
INSERT INTO `omission`(`student_ID`, `teacher_ID`, `date`, `hour`, `delay`, `certify`) 
VALUES 
(
(SELECT student_ID FROM student WHERE student.name=_studentName),
(SELECT teacher_ID FROM teacher WHERE teacher.name= _teacherName),
 	_omissionDate,
    _omissionHour,
    _omissionDelay,
    _certify
);
END$$

DROP PROCEDURE IF EXISTS `aenOmissionRuningSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenOmissionRuningSelect` (IN `_classSign` VARCHAR(2), IN `_classNummer` VARCHAR(11), IN `_selectedStudent` VARCHAR(40), IN `_startDate` DATE, IN `_endDate` DATE)  NO SQL
BEGIN
SELECT omission_ID,omission.date, student.name as student, teacher.name as teacher, hour,delay, certify FROM `omission` 
INNER JOIN student ON omission.student_ID= student.student_ID
INNER JOIN teacher ON teacher.teacher_ID=omission.omission_ID
WHERE omission.student_ID IN
(SELECT student_ID FROM student WHERE student.class_ID=
(SELECT class.class_ID FROM class WHERE class.character_sign=_classSign AND class.class_year= _classNummer and student.name LIKE _selectedStudent AND
omission.date BETWEEN _startDate AND _endDate));
END$$

DROP PROCEDURE IF EXISTS `aenOmissionStartSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenOmissionStartSelect` (IN `_classSign` VARCHAR(2), IN `_classNumber` INT(11))  NO SQL
BEGIN
SELECT omission_ID,omission.date, student.name as student, teacher.name as teacher, omission.hour,omission.delay,omission.certify FROM `omission` 
INNER JOIN student ON omission.student_ID= student.student_ID
INNER JOIN teacher ON omission.teacher_ID=teacher.teacher_ID
WHERE omission.student_ID IN
(SELECT student_ID FROM student WHERE student.class_ID=
(SELECT class.class_ID FROM class WHERE class.character_sign=_classSign AND class.class_year= _classNumber));
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

DROP PROCEDURE IF EXISTS `aenParentDelete`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenParentDelete` (IN `_parent_id` INT(11))  NO SQL
BEGIN
DELETE FROM parent WHERE parent.parent_ID=_parent_id;
END$$

DROP PROCEDURE IF EXISTS `aenParentInstert`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenParentInstert` (IN `_parentName` VARCHAR(40), IN `_bornDate` DATE, IN `_accName` VARCHAR(4), IN `_password` VARCHAR(10), IN `_teacherName` VARCHAR(40))  NO SQL
BEGIN
INSERT INTO `parent`(`name`, `born_date`, `user_name`, `password`, `teacher_ID`) VALUES (_parentName, _bornDate, _accName, _password,(SELECT teacher_ID FROM teacher WHERE teacher.name LIKE _teacherName));
END$$

DROP PROCEDURE IF EXISTS `aenParentNameSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenParentNameSelect` ()  NO SQL
SELECT parent.name FROM parent$$

DROP PROCEDURE IF EXISTS `aenParentPassSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenParentPassSelect` (IN `_username` VARCHAR(40), IN `_password` VARCHAR(40))  NO SQL
BEGIN
Select * From `parent` where `user_name` = _username and `password` = _password; 
END$$

DROP PROCEDURE IF EXISTS `aenParentSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenParentSelect` ()  NO SQL
BEGIN
SELECT `parent_ID`,parent.name ,parent.born_date,parent.user_name ,parent.password ,teacher.name as teacher FROM `parent` INNER JOIN teacher on parent.teacher_ID= teacher.teacher_ID;
END$$

DROP PROCEDURE IF EXISTS `aenParentUpdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenParentUpdate` (IN `_updateName` VARCHAR(40), IN `_updateBornDate` DATE, IN `_updatePassword` VARCHAR(10), IN `_updateTeacherName` VARCHAR(40), IN `_updateParentID` INT(11))  NO SQL
BEGIN
UPDATE `parent` SET `name`=_updateName,`born_date`=_updateBornDate,`password`=_updatePassword,`teacher_ID`=(SELECT teacher_ID FROM teacher WHERE teacher.name LIKE _updateTeacherName) WHERE parent_ID=_updateParentID;
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

DROP PROCEDURE IF EXISTS `aenStudentDelete`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenStudentDelete` (IN `_student_id` INT(11))  NO SQL
BEGIN
DELETE FROM student WHERE student.student_ID=_student_id;
END$$

DROP PROCEDURE IF EXISTS `aenStudentInsert`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenStudentInsert` (IN `_studentName` VARCHAR(40), IN `_bornDate` DATE, IN `_accName` VARCHAR(4), IN `_password` VARCHAR(12), IN `_parentName` VARCHAR(40), IN `_teacherName` VARCHAR(40), IN `_classID` INT(11))  NO SQL
BEGIN
INSERT INTO `student`(`name`, `born_date`, `user_name`, `password`, `parent_ID`, `teacher_ID`, `class_ID`) 
VALUES (_studentName,_bornDate,_accName,_password,(SELECT parent_ID FROM parent WHERE parent.name LIKE _parentName),(SELECT teacher_ID FROM teacher WHERE teacher.name LIKE _teacherName),_classID);
END$$

DROP PROCEDURE IF EXISTS `aenStudentPassSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenStudentPassSelect` (IN `_username` VARCHAR(40), IN `_password` VARCHAR(40))  NO SQL
BEGIN
Select * From `student` where `user_name` = _username and `password` = _password; 
END$$

DROP PROCEDURE IF EXISTS `aenStudentSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenStudentSelect` ()  NO SQL
BEGIN
SELECT `student_ID`,student.`name`,student.`born_date` ,student.`user_name`,student.`password`, parent.name as "parent", teacher.name as "head teacher", class.class_ID as "class_id" FROM `student`
INNER JOIN parent on student.parent_ID= parent.parent_ID
INNER JOIN teacher ON student.teacher_ID= teacher.teacher_ID
INNER JOIN class on student.class_ID= class.class_ID;
END$$

DROP PROCEDURE IF EXISTS `aenStudentsSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenStudentsSelect` (IN `_classSign` VARCHAR(40), IN `_classNummer` INT(11))  NO SQL
BEGIN
Select * From student Where student.class_ID = (SELECT `class_ID` FROM `class` WHERE class.character_sign= _classSign AND class.class_year= _classNummer);
END$$

DROP PROCEDURE IF EXISTS `aenStudentUpdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenStudentUpdate` (IN `_updateName` VARCHAR(40), IN `_updatePassword` VARCHAR(10), IN `_updateBornDate` DATE, IN `_updateTeacherName` VARCHAR(40), IN `_updateStudentID` INT(11), IN `_updateParentName` VARCHAR(40), IN `_updateClass` INT(11))  NO SQL
BEGIN
UPDATE `student` SET `name`=_updateName,`born_date`=_updateBornDate,`password`=_updatePassword,`teacher_ID`=(SELECT teacher_ID FROM teacher WHERE teacher.name LIKE _updateTeacherName),
`parent_ID`=(SELECT parent_ID FROM parent WHERE parent.name LIKE _updateParentName),
class_ID=_updateClass
WHERE student.student_ID=_updateStudentID;
END$$

DROP PROCEDURE IF EXISTS `aenSubjcetUpdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenSubjcetUpdate` (IN `_updateSubjectName` VARCHAR(40), IN `_updateSubjcetID` INT(11))  NO SQL
BEGIN
UPDATE `subject` SET `subject_name`=_updateSubjectName WHERE `subject_ID`=_updateSubjcetID;
END$$

DROP PROCEDURE IF EXISTS `aenSubjectDelete`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenSubjectDelete` (IN `_subject_id` INT(11))  NO SQL
BEGIN
DELETE FROM subject WHERE subject.subject_ID=_subject_id;
END$$

DROP PROCEDURE IF EXISTS `aenSubjectInsert`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenSubjectInsert` (IN `_insertSubject` VARCHAR(40))  NO SQL
BEGIN
INSERT INTO `subject`(`subject_name`) VALUES (_insertSubject);
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

DROP PROCEDURE IF EXISTS `aenTeacherDelete`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenTeacherDelete` (IN `_teacher_id` INT(11))  NO SQL
BEGIN
DELETE FROM teacher WHERE teacher.teacher_ID=_teacher_id;
END$$

DROP PROCEDURE IF EXISTS `aenTeacherInsert`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenTeacherInsert` (IN `_name` VARCHAR(50), IN `_bornDate` DATE, IN `_accName` VARCHAR(4), IN `_password` VARCHAR(10))  NO SQL
BEGIN
INSERT INTO `teacher`(`name`, `born_date`, `user_name`, `password`) VALUES (_name,_bornDate,_accName,_password);
END$$

DROP PROCEDURE IF EXISTS `aenTeacherPassSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenTeacherPassSelect` (IN `_username` VARCHAR(50), IN `_password` VARCHAR(50))  BEGIN
Select * From `teacher` where `user_name` = _username and `password` = _password; 
END$$

DROP PROCEDURE IF EXISTS `aenTeachersSelect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenTeachersSelect` ()  NO SQL
BEGIN
SELECT * FROM `teacher`;
END$$

DROP PROCEDURE IF EXISTS `aenTeacherUpdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `aenTeacherUpdate` (IN `_updateName` VARCHAR(40), IN `_updateMarkDate` DATE, IN `_updatePassword` VARCHAR(40), IN `_updateTeacherID` INT(11))  NO SQL
BEGIN
UPDATE `teacher` SET `name`=_updateName,`born_date`=_updateMarkDate,`password`=_updatePassword WHERE teacher_ID=_updateTeacherID;
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `class` (`class_ID`, `class_start`, `start_number`, `character_sign`, `class_year`) VALUES
(1, '2010-09-01', 1, 'A', 1),
(2, '2017-09-01', 1, 'B', 1),
(3, '2011-09-01', 2, 'C', 4);

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `mark` (`mark_ID`, `student_ID`, `teacher_ID`, `subject_ID`, `mark_number`, `description`, `mark_Date`) VALUES
(1, 1, 1, 1, 5, 'Ókor csodái.', '2012-05-21'),
(2, 2, 2, 2, 3, 'Összeadás', '2017-05-29'),
(4, 1, 1, 2, 5, 'Lómaiszámok', '2012-05-31'),
(5, 2, 1, 2, 3, 'Osztás', '2012-05-31'),
(6, 1, 1, 1, 3, '1848 forradalom', '2018-07-20');

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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `omission` (`omission_ID`, `student_ID`, `teacher_ID`, `date`, `hour`, `delay`, `certify`) VALUES
(1, 1, 2, '2018-07-17', 2, b'0', b'1'),
(3, 2, 2, '2018-07-24', 3, b'1', b'0');

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
(1, 'Kasszás Erzsébet', '1968-02-12', 'KaEr', '1234', 2),
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `student` (`student_ID`, `name`, `born_date`, `user_name`, `password`, `parent_ID`, `teacher_ID`, `class_ID`) VALUES
(1, 'Jon Snow', '1996-04-08', 'JoSn', 'akad', 1, 1, 1),
(2, 'Minimum Sára', '1995-05-28', 'MiSá', 'igen1', 2, 2, 2),
(3, 'Fási Ádám', '2000-06-19', 'FáÁd', 'Cica', 2, 2, 1);

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
