-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Dec 15. 12:53
-- Kiszolgáló verziója: 10.1.38-MariaDB
-- PHP verzió: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `auto_data`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `carcategories`
--

CREATE TABLE `carcategories` (
  `categories` varchar(50) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `carcategories`
--

INSERT INTO `carcategories` (`categories`) VALUES
('válasszon'),
('Buborékautók'),
('Minik/Keicars/Mikroautók'),
('A-szegmens/Városi miniautók'),
('B-szegmens/Városi kisautók/Szubkompaktok'),
('C-szegmens/Kompaktok/Alsó-középkategória'),
('D-szegmens/Felső-középkategória'),
('E-szegmens/Nagyautók/Felsőkategória'),
('F-szegmens/Luxusautók'),
('Mini egyterűek'),
('Kis egyterűek'),
('Közepes egyterűek'),
('Buszok'),
('Grand Turismók'),
('Sportautók'),
('Szuperautók'),
('Roadsterek'),
('Terepjárók'),
('Szabadidő-autók'),
('Városi crossoverek');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `cars`
--

CREATE TABLE `cars` (
  `id` int(11) NOT NULL,
  `category` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `make` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `model` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `code` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `body` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `fuel_type` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `cylinder_number` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `cylinder_arrangement` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `aspiration` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `power` int(11) NOT NULL,
  `torque` int(11) NOT NULL,
  `displacement` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `gearbox_type` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `gears` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `powertrain` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `acceleration100` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `acceleration200` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `vmax` int(11) NOT NULL,
  `consumption` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `production_start` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `production_end` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `bat_capacity` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `fuel_range` int(11) NOT NULL,
  `registered_by` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `cars`
--

INSERT INTO `cars` (`id`, `category`, `make`, `model`, `code`, `body`, `fuel_type`, `cylinder_number`, `cylinder_arrangement`, `aspiration`, `power`, `torque`, `displacement`, `gearbox_type`, `gears`, `powertrain`, `acceleration100`, `acceleration200`, `vmax`, `consumption`, `production_start`, `production_end`, `bat_capacity`, `fuel_range`, `registered_by`) VALUES
(15, 'E-szegmens/Nagyautók/Felsőkategória', 'BMW', '540', 'E39', 'szedán', 'benzin', '8', 'V', 'nincs', 286, 440, '4,4', 'hagyományos automata váltó', '5', 'hátsókerék', '6,7', '31,9', 250, '10,9', '1998', '2001', '0', 0, 5),
(16, 'E-szegmens/Nagyautók/Felsőkategória', 'BMW', 'M5', 'E39', 'szedán', 'benzin', '8', 'V', 'nincs', 400, 500, '4,9', 'kéziváltó', '6', 'hátsókerék', '5,3', '24,8', 250, '10,2', '1998', '2001', '0', 0, 5),
(17, 'E-szegmens/Nagyautók/Felsőkategória', 'BMW', '530', 'E39', 'kombi', 'dízel', '6', 'soros', 'nincs', 193, 390, '3,0', 'hagyományos automata váltó', '5', 'hátsókerék', '8,9', '36,8', 222, '6,6', '1998', '2003', '0', 0, 5),
(18, 'F-szegmens/Luxusautók', 'Audi', 'A8', 'D2', 'szedán', 'dízel', '8', 'V', 'turbó', 224, 480, '3,3', 'hagyományos automata váltó', '5', 'összkerék', '8,2', '33,4', 242, '9,7', '1999', '2002', '0', 0, 13),
(19, 'F-szegmens/Luxusautók', 'Audi', 'A8', 'D3', 'szedán', 'benzin', '8', 'V', 'nincs', 335, 430, '4,2', 'hagyományos automata váltó', '5', 'összkerék', '6,3', '29,7', 250, '11,9', '2002', '2005', '0', 0, 13),
(20, 'F-szegmens/Luxusautók', 'Mercedes-AMG', 'S65', 'W221', 'szedán', 'benzin', '12', 'V', 'turbó', 612, 1000, '6,0', 'hagyományos automata váltó', '5', 'hátsókerék', '4,4', '17,6', 250, '14,5', '2009', '2010', '0', 0, 8),
(21, 'F-szegmens/Luxusautók', 'Mercedes-AMG', 'E55', 'W210', 'szedán', 'benzin', '8', 'V', 'nincs', 354, 530, '5,4', 'hagyományos automata váltó', '5', 'hátsókerék', '5,9', '22,6', 250, '12,7', '1997', '2000', '0', 0, 8),
(22, 'E-szegmens/Nagyautók/Felsőkategória', 'Mercedes-Benz', 'CLS350', 'C257', 'szedán', 'dízel', '6', 'soros', 'turbó', 286, 600, '2,9', 'hagyományos automata váltó', '9', 'hátsókerék', '5,7', '23,4', 250, '5,8', '2018', 'még gyártásban', '0', 0, 8),
(23, 'Terepjárók', 'Dacia', 'Duster', '', 'terepjáró', 'dízel', '4', 'soros', 'turbó', 110, 260, '1,5', 'kéziváltó', '6', 'összkerék', '12,4', '1', 169, '4,7', '2018', 'még gyártásban', '0', 0, 8),
(24, 'Roadsterek', 'Mazda', 'MX5', 'NB', 'kabrió', 'benzin', '4', 'soros', 'nincs', 110, 134, '1,6', 'kéziváltó', '5', 'hátsókerék', '9,7', '0', 191, '8,1', '1998', '2005', '0', 0, 9),
(25, 'E-szegmens/Nagyautók/Felsőkategória', 'Volvo', 'V70', '', 'kombi', 'benzin', '5', 'soros', 'turbó', 300, 400, '2,5', 'kéziváltó', '6', 'összkerék', '5,7', '21,4', 250, '8,6', '2000', '2007', '0', 0, 10),
(26, 'F-szegmens/Luxusautók', 'BMW', '730', 'E65', 'szedán', 'dízel', '6', 'soros', 'turbó', 218, 500, '3,0', 'hagyományos automata váltó', '6', 'hátsókerék', '8,0', '35,4', 235, '8,5', '2002', '2005', '0', 0, 10),
(27, 'C-szegmens/Kompaktok/Alsó-középkategória', 'Volvo', 'C30', '', 'ferdehátú', 'dízel', '5', 'soros', 'turbó', 177, 400, '2,0', 'hagyományos automata váltó', '6', 'elsőkerék', '8,7', '39,4', 220, '5,8', '2010', '2012', '0', 0, 10),
(28, 'E-szegmens/Nagyautók/Felsőkategória', 'Mercedes-Benz', 'E280', 'W124', 'szedán', 'benzin', '6', 'soros', 'nincs', 193, 270, '2,8', 'hagyományos automata váltó', '5', 'hátsókerék', '8,1', '35,1', 230, '12,5', '1993', '1995', '0', 0, 10),
(29, 'D-szegmens/Felső-középkategória', 'BMW', '325', 'E90', 'szedán', 'benzin', '6', 'soros', 'nincs', 218, 250, '2,5', 'hagyományos automata váltó', '6', 'hátsókerék', '6,7', '28,5', 245, '8,4', '2005', '2007', '0', 0, 10),
(30, 'D-szegmens/Felső-középkategória', 'Honda', 'Accord', '', 'szedán', 'benzin', '4', 'soros', 'nincs', 190, 220, '2,4', 'hagyományos automata váltó', '5', 'elsőkerék', '7,9', '33,4', 227, '9,1', '2002', '2007', '0', 0, 10),
(31, 'D-szegmens/Felső-középkategória', 'Ford', 'Mondeo', '', 'szedán', 'benzin', '4', 'soros', 'nincs', 145, 190, '2,0', 'kéziváltó', '5', 'elsőkerék', '9,8', '40,2', 215, '8,0', '2001', '2006', '0', 0, 10),
(32, 'A-szegmens/Városi miniautók', 'Toyota', 'Yaris', '', 'ferdehátú', 'benzin', '4', 'soros', 'nincs', 68, 90, '1,0', 'kéziváltó', '5', 'elsőkerék', '13,6', '0', 155, '5,7', '1999', '2005', '0', 0, 10);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `gears`
--

CREATE TABLE `gears` (
  `gear_type` varchar(30) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `gears`
--

INSERT INTO `gears` (`gear_type`) VALUES
('válasszon'),
('kéziváltó'),
('hagyományos automata váltó'),
('duplakuplungos automat váltó'),
('robotizált automata váltó'),
('fokozatmentes automata váltó'),
('szekvenciális váltó'),
('nincs');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `last_name` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `first_name` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `position` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `birthdate` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `username` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(200) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `last_name`, `first_name`, `position`, `birthdate`, `email`, `username`, `password`) VALUES
(5, 'admin', '', 'adminisztrátor', '1988 szeptember 07', 'ujjpetertamas@gmail.com', 'admin', '8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918'),
(8, 'Zeitler', 'Mátyás', 'újságíró', '1992. 03. 03. 0:00:00', 'zeitler.matyas@alapjarat.hu', 'matyas.zeitler', '7CACE028DBC66DCB32BDC5023044735E3BBE12311FE282305612351810DF610A'),
(9, 'Rupa', 'Adrienn', 'szerkesztő', '1990. 11. 05. 0:00:00', 'adrienn.rupa@alapjarat.hu', 'adrienn.rupa', 'D302886ECCA83222A392F6549E520DACBD95DC65F1A303F8C571CA3BB9B8E196'),
(10, 'Ujj', 'Péter', 'újságíró', '1988. 09. 07. 0:00:00', 'peter.ujj@alapjarat.hu', 'peter.ujj', '5683D90F1A450D143D1E94F09E1DED5C351A94671E1F79A03098DFE1A301AB3F'),
(12, 'Tóth', 'Balázs', 'főszerkesztő', '1980. 06. 05. 0:00:00', 'balazs.toth@alapjarat.hu', 'balazs.toth', 'D421C9AAB23ABB44C6681DCFDC90172072702FAD6E45A0E5D3038A31FADED159'),
(13, 'Háfra', 'Zsolt', 'fotós', '1994. 10. 08. 0:00:00', 'zsolt.hafra@alapjarat.hu', 'zsolt.hafra', '88D33D686FEDB0BCAAFF63EEE113563123DCA553E6C923A0897E166703C4F36C');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`id`),
  ADD KEY `registered_by` (`registered_by`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `cars`
--
ALTER TABLE `cars`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
