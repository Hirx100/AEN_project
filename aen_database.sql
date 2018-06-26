-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2018. Jún 26. 11:00
-- Kiszolgáló verziója: 10.1.33-MariaDB
-- PHP verzió: 7.2.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `aen_database`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `class`
--

CREATE TABLE `class` (
  `class_ID` int(11) NOT NULL,
  `class_start` date NOT NULL,
  `start_number` int(11) NOT NULL,
  `character_sign` varchar(2) COLLATE utf8_hungarian_ci NOT NULL,
  ` class_year` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `lesson`
--

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

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `mark`
--

CREATE TABLE `mark` (
  `mark_ID` int(11) NOT NULL,
  `student_ID` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `subject_ID` int(11) NOT NULL,
  `description` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `weighting` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `omission`
--

CREATE TABLE `omission` (
  `omission_ID` int(11) NOT NULL,
  `student_ID` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `date` date NOT NULL,
  `hour` int(11) NOT NULL,
  `delay` bit(1) NOT NULL,
  `certify` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `parent`
--

CREATE TABLE `parent` (
  `parent_ID` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `born_date` date NOT NULL,
  `user_name` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `active` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `student`
--

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

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `subject`
--

CREATE TABLE `subject` (
  `subject_ID` int(11) NOT NULL,
  `subject_name` varchar(25) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `teacher`
--

CREATE TABLE `teacher` (
  `teacher_ID` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `born_date` date NOT NULL,
  `user_name` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `active` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`class_ID`);

--
-- A tábla indexei `lesson`
--
ALTER TABLE `lesson`
  ADD PRIMARY KEY (`lesson_ID`),
  ADD KEY `teacher_ID` (`teacher_ID`,`class_ID`),
  ADD KEY `class_ID` (`class_ID`),
  ADD KEY `subject_ID` (`subject_ID`);

--
-- A tábla indexei `mark`
--
ALTER TABLE `mark`
  ADD PRIMARY KEY (`mark_ID`),
  ADD KEY `teacher_ID` (`teacher_ID`),
  ADD KEY `student_ID` (`student_ID`,`subject_ID`),
  ADD KEY `subject_ID` (`subject_ID`);

--
-- A tábla indexei `omission`
--
ALTER TABLE `omission`
  ADD PRIMARY KEY (`omission_ID`),
  ADD KEY `student_ID` (`student_ID`,`teacher_ID`),
  ADD KEY `teacher_ID` (`teacher_ID`);

--
-- A tábla indexei `parent`
--
ALTER TABLE `parent`
  ADD PRIMARY KEY (`parent_ID`),
  ADD KEY `teacher_ID` (`teacher_ID`);

--
-- A tábla indexei `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`student_ID`),
  ADD KEY `parent_ID` (`parent_ID`,`teacher_ID`,`class_ID`),
  ADD KEY `class_ID` (`class_ID`),
  ADD KEY `teacher_ID` (`teacher_ID`);

--
-- A tábla indexei `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`subject_ID`);

--
-- A tábla indexei `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`teacher_ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `class`
--
ALTER TABLE `class`
  MODIFY `class_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `lesson`
--
ALTER TABLE `lesson`
  MODIFY `lesson_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `mark`
--
ALTER TABLE `mark`
  MODIFY `mark_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `omission`
--
ALTER TABLE `omission`
  MODIFY `omission_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `parent`
--
ALTER TABLE `parent`
  MODIFY `parent_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `student`
--
ALTER TABLE `student`
  MODIFY `student_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `subject`
--
ALTER TABLE `subject`
  MODIFY `subject_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `teacher`
--
ALTER TABLE `teacher`
  MODIFY `teacher_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `lesson`
--
ALTER TABLE `lesson`
  ADD CONSTRAINT `lesson_ibfk_1` FOREIGN KEY (`teacher_ID`) REFERENCES `teacher` (`teacher_ID`),
  ADD CONSTRAINT `lesson_ibfk_2` FOREIGN KEY (`class_ID`) REFERENCES `class` (`class_ID`),
  ADD CONSTRAINT `lesson_ibfk_3` FOREIGN KEY (`subject_ID`) REFERENCES `subject` (`subject_ID`);

--
-- Megkötések a táblához `mark`
--
ALTER TABLE `mark`
  ADD CONSTRAINT `mark_ibfk_1` FOREIGN KEY (`teacher_ID`) REFERENCES `teacher` (`teacher_ID`),
  ADD CONSTRAINT `mark_ibfk_2` FOREIGN KEY (`student_ID`) REFERENCES `student` (`student_ID`),
  ADD CONSTRAINT `mark_ibfk_3` FOREIGN KEY (`subject_ID`) REFERENCES `subject` (`subject_ID`);

--
-- Megkötések a táblához `omission`
--
ALTER TABLE `omission`
  ADD CONSTRAINT `omission_ibfk_1` FOREIGN KEY (`student_ID`) REFERENCES `student` (`student_ID`),
  ADD CONSTRAINT `omission_ibfk_2` FOREIGN KEY (`teacher_ID`) REFERENCES `teacher` (`teacher_ID`);

--
-- Megkötések a táblához `parent`
--
ALTER TABLE `parent`
  ADD CONSTRAINT `parent_ibfk_1` FOREIGN KEY (`teacher_ID`) REFERENCES `teacher` (`teacher_ID`);

--
-- Megkötések a táblához `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_1` FOREIGN KEY (`class_ID`) REFERENCES `class` (`class_ID`),
  ADD CONSTRAINT `student_ibfk_2` FOREIGN KEY (`teacher_ID`) REFERENCES `teacher` (`teacher_ID`),
  ADD CONSTRAINT `student_ibfk_3` FOREIGN KEY (`parent_ID`) REFERENCES `parent` (`parent_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
