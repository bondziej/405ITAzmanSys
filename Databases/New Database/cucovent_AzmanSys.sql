-- phpMyAdmin SQL Dump
-- version 4.6.6
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 19, 2019 at 10:35 PM
-- Server version: 5.6.35
-- PHP Version: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cucovent_azmansys`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbooking`
--

CREATE TABLE `tblbooking` (
  `BookingID` int(11) NOT NULL,
  `CusID` int(11) NOT NULL,
  `FlightID` int(11) NOT NULL,
  `Booking_DateTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Total_BookingCost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tblbooking`
--

INSERT INTO `tblbooking` (`BookingID`, `CusID`, `FlightID`, `Booking_DateTime`, `Total_BookingCost`) VALUES
(1, 0, 6, '2019-12-12 01:29:18', 600),
(2, 1, 6, '2019-12-12 01:29:18', 700),
(3, 2, 6, '2019-12-12 01:29:18', 600),
(6, 1, 6, '2019-12-12 01:29:18', 500),
(7, 1, 7, '2019-12-12 01:29:18', 900),
(8, 5, 5, '2019-12-12 01:29:18', 900),
(9, 3, 6, '2019-12-26 01:29:18', 600);

-- --------------------------------------------------------

--
-- Table structure for table `tblcustomer`
--

CREATE TABLE `tblcustomer` (
  `CusID` int(11) NOT NULL,
  `CusFName` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CusLName` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CusTelNum` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CusNationality` varchar(250) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tblcustomer`
--

INSERT INTO `tblcustomer` (`CusID`, `CusFName`, `CusLName`, `CusTelNum`, `CusNationality`) VALUES
(1, 'Josiah', 'Anyinsah-Bondzie', '065096506', 'Ghanaian'),
(5, 'Josiah', 'Anyinsah', '4054535435', 'Ghanaian'),
(6, 'Ben', 'Clinton', '04594353434', 'American'),
(7, 'James', 'Smith', '075645645646', 'British'),
(8, 'Benjamin', 'Franklin', '0435435887', 'American'),
(9, 'Stephen', 'Carter', '02312313232', 'Canadian');

-- --------------------------------------------------------

--
-- Table structure for table `tblflight`
--

CREATE TABLE `tblflight` (
  `FlightID` int(11) NOT NULL,
  `F_Depar_DateTime` datetime NOT NULL,
  `F_Arrival_DateTime` datetime NOT NULL,
  `F_Departure_City` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `F_Arrival_City` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `F_Price` float NOT NULL,
  `Child_Price` int(11) NOT NULL,
  `Infant_Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tblflight`
--

INSERT INTO `tblflight` (`FlightID`, `F_Depar_DateTime`, `F_Arrival_DateTime`, `F_Departure_City`, `F_Arrival_City`, `F_Price`, `Child_Price`, `Infant_Price`) VALUES
(3, '2019-12-12 12:35:01', '2019-12-12 12:35:01', 'London', 'Accra', 500, 200, 90),
(4, '2019-12-12 12:35:01', '2019-12-28 12:35:01', 'London', 'New York', 1200, 0, 0),
(5, '2019-12-12 12:35:01', '2019-12-28 12:35:01', 'London', 'Toronto', 1200, 0, 0),
(6, '2019-12-19 12:35:01', '2019-12-19 12:35:01', 'London', 'Accra', 500, 200, 90);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbooking`
--
ALTER TABLE `tblbooking`
  ADD PRIMARY KEY (`BookingID`);

--
-- Indexes for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  ADD PRIMARY KEY (`CusID`),
  ADD UNIQUE KEY `CusID` (`CusID`);

--
-- Indexes for table `tblflight`
--
ALTER TABLE `tblflight`
  ADD PRIMARY KEY (`FlightID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbooking`
--
ALTER TABLE `tblbooking`
  MODIFY `BookingID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  MODIFY `CusID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `tblflight`
--
ALTER TABLE `tblflight`
  MODIFY `FlightID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
