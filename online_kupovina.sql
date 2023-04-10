-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 15, 2022 at 08:00 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `online_kupovina`
--

-- --------------------------------------------------------

--
-- Table structure for table `korisnik`
--

CREATE TABLE `korisnik` (
  `id` int(20) NOT NULL,
  `ime` varchar(255) NOT NULL,
  `prezime` varchar(255) NOT NULL,
  `korisnicko_ime` varchar(255) NOT NULL,
  `lozinka` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `korisnik`
--

INSERT INTO `korisnik` (`id`, `ime`, `prezime`, `korisnicko_ime`, `lozinka`) VALUES
(1, 'Kristina', 'Trajkovic', 'kristina00', 'kristina00'),
(4, 'Jelena', 'Ristic', 'jelena00', 'jelena00');

-- --------------------------------------------------------

--
-- Table structure for table `korpa`
--

CREATE TABLE `korpa` (
  `id_korisnika` int(11) NOT NULL,
  `id_proizvoda` int(11) NOT NULL,
  `kolicina` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `korpa`
--

INSERT INTO `korpa` (`id_korisnika`, `id_proizvoda`, `kolicina`) VALUES
(1, 1, 1),
(1, 6, 1),
(1, 5, 3),
(4, 4, 1),
(4, 12, 3),
(4, 10, 1);

-- --------------------------------------------------------

--
-- Table structure for table `proizvodi`
--

CREATE TABLE `proizvodi` (
  `id_proizvoda` int(11) NOT NULL,
  `vrsta` varchar(255) NOT NULL,
  `cena` int(255) NOT NULL,
  `tezina` varchar(255) NOT NULL,
  `naziv_proizvoda` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `proizvodi`
--

INSERT INTO `proizvodi` (`id_proizvoda`, `vrsta`, `cena`, `tezina`, `naziv_proizvoda`) VALUES
(1, 'mlecni proizvodi', 150, '1l', 'jogurt'),
(2, 'mlecni proizvodi', 120, '1l', 'mleko'),
(3, 'mlecni proizvodi', 220, '700g', 'kisela pavlaka'),
(4, 'mlecni proizvodi', 110, '200g', 'pavlaka za kuvanje'),
(5, 'voce', 110, '1kg', 'limun'),
(6, 'voce', 150, '1kg', 'banana'),
(7, 'smrznuti proizvodi', 184, '400g', 'Smrznuta visnja Premia'),
(8, 'smrznuti proizvodi', 500, '500g', 'Smrznuta paella'),
(9, 'smrznuti proizvodi', 80, '450g', 'Smrznuta boranija zelena'),
(10, 'smrznuti proizvodi', 130, '105g', 'Desert plazma casica'),
(11, 'smrznuti proizvodi', 269, '600g', 'Kroasan sa kakao kremom '),
(12, 'smrznuti proizvodi', 200, '1kg', 'Smrznuti Zu-zu');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `korisnik`
--
ALTER TABLE `korisnik`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `proizvodi`
--
ALTER TABLE `proizvodi`
  ADD PRIMARY KEY (`id_proizvoda`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `korisnik`
--
ALTER TABLE `korisnik`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `proizvodi`
--
ALTER TABLE `proizvodi`
  MODIFY `id_proizvoda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
