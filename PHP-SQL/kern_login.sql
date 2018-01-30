-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2017 at 04:09 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `test`
--

-- --------------------------------------------------------

--
-- Table structure for table `kern_login`
--

CREATE TABLE `kern_login` (
  `user` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `securityLevel` varchar(20) NOT NULL,
  `userID` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kern_login`
--

INSERT INTO `kern_login` (`user`, `password`, `securityLevel`, `userID`) VALUES
('gary.kappenman', 'garyGuest', 'Guest', 1),
('nathan.kerkvliet', 'nathanAdmin', 'Admin', 2),
('jane.doe', 'janeGuest', 'Guest', 3),
('jon.smith', 'jonGuest', 'Guest', 4),
('Guest', 'Guest', 'Guest', 5),
('gary.kappenman', 'garyAdmin', 'Admin', 6);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kern_login`
--
ALTER TABLE `kern_login`
  ADD PRIMARY KEY (`userID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `kern_login`
--
ALTER TABLE `kern_login`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
