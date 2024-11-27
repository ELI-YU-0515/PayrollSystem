-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Nov 26, 2024 at 04:12 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payroll_systemdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `emp_details`
--

CREATE TABLE `emp_details` (
  `internal_id` int(11) NOT NULL,
  `ref_id` int(2) NOT NULL,
  `emp_img` varchar(256) NOT NULL,
  `emp_fname` varchar(20) DEFAULT NULL,
  `emp_mname` varchar(20) DEFAULT NULL,
  `emp_lname` varchar(20) DEFAULT NULL,
  `emp_age` int(2) DEFAULT NULL,
  `emp_sex` varchar(6) DEFAULT NULL,
  `emp_address` varchar(100) DEFAULT NULL,
  `emp_mobile` varchar(11) DEFAULT NULL,
  `emp_position` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `emp_details`
--

INSERT INTO `emp_details` (`internal_id`, `ref_id`, `emp_img`, `emp_fname`, `emp_mname`, `emp_lname`, `emp_age`, `emp_sex`, `emp_address`, `emp_mobile`, `emp_position`) VALUES
(11, 10002, 'IMAGE', 'MARWYN', 'JAMES', 'MALALUAN', 20, 'Male', 'SA NOVALICHES RIN', '09999999999', 'PROJECT MANAGER'),
(12, 10003, 'IMAGE', 'PRINCESS', 'CARMELLA', 'DIZON', 20, 'Female', 'SA ROAD 20', '09888888888', 'HR'),
(13, 10004, 'IMAGE', 'ELIJAH REGAN', 'CAROLINO', 'BRONCANO', 50, 'Male', 'SA BAHAY NILA', '09669466040', 'HR'),
(14, 10005, 'IMAGE', 'KURT', 'SOMETHING', 'CARPESO', 20, 'Male', 'SA BAHAY NILA', '0966-666-66', 'TEAM MANAGER');

-- --------------------------------------------------------

--
-- Table structure for table `emp_salary`
--

CREATE TABLE `emp_salary` (
  `internal_id` int(11) NOT NULL,
  `ref_id` int(2) DEFAULT NULL,
  `log_date` date DEFAULT NULL,
  `emp_position` varchar(15) NOT NULL,
  `hours_worked` int(11) DEFAULT NULL,
  `hourly_rate` decimal(6,2) DEFAULT NULL,
  `emp_sss` decimal(6,2) DEFAULT NULL,
  `emp_phic` decimal(6,2) DEFAULT NULL,
  `emp_pagibig` decimal(6,2) DEFAULT NULL,
  `emp_TIncome` decimal(9,2) DEFAULT NULL,
  `emp_TDeduc` decimal(9,2) DEFAULT NULL,
  `emp_NetPay` decimal(9,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `emp_salary`
--

INSERT INTO `emp_salary` (`internal_id`, `ref_id`, `log_date`, `emp_position`, `hours_worked`, `hourly_rate`, `emp_sss`, `emp_phic`, `emp_pagibig`, `emp_TIncome`, `emp_TDeduc`, `emp_NetPay`) VALUES
(7, 10003, '2024-11-30', 'HR', 80, 400.00, 1440.00, 1120.00, 400.00, 32000.00, 2960.00, 29040.00),
(9, 10004, '2024-11-15', 'HR', 60, 600.00, 1620.00, 1260.00, 400.00, 36000.00, 3280.00, 32720.00),
(10, 10004, '2024-11-24', 'HR', 60, 400.00, 1080.00, 840.00, 400.00, 24000.00, 2320.00, 21680.00),
(11, 10002, '2024-11-24', 'PROJECT MANAGER', 40, 600.00, 960.00, 720.00, 300.00, 24000.00, 1980.00, 22020.00),
(12, 10005, '2024-11-15', 'TEAM MANAGER', 70, 350.00, 857.50, 612.50, 200.00, 24500.00, 1670.00, 22830.00);

-- --------------------------------------------------------

--
-- Table structure for table `payroll_register`
--

CREATE TABLE `payroll_register` (
  `user_fname` varchar(20) NOT NULL,
  `user_lname` varchar(20) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(8) NOT NULL,
  `user_type` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payroll_register`
--

INSERT INTO `payroll_register` (`user_fname`, `user_lname`, `username`, `password`, `user_type`) VALUES
('Elizar', 'Yu', '', '', ''),
('Elizar', 'Yu', 'elizaryu', '12345', 'admin'),
('', '', '', '', ''),
('', '', '', '', ''),
('ELIJAH', 'BRONCANO', 'elijah', '123456', 'admin');

-- --------------------------------------------------------

--
-- Stand-in structure for view `vw_employee_summary`
-- (See below for the actual view)
--
CREATE TABLE `vw_employee_summary` (
`internal_id` int(11)
,`ref_id` int(2)
,`emp_full_name` varchar(44)
,`emp_position` varchar(15)
,`log_date` date
,`hours_worked` int(11)
,`hourly_rate` decimal(6,2)
,`emp_sss` decimal(6,2)
,`emp_phic` decimal(6,2)
,`emp_pagibig` decimal(6,2)
,`emp_TIncome` decimal(9,2)
,`emp_TDeduc` decimal(9,2)
,`emp_netpay` decimal(9,2)
);

-- --------------------------------------------------------

--
-- Structure for view `vw_employee_summary`
--
DROP TABLE IF EXISTS `vw_employee_summary`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_employee_summary`  AS SELECT `es`.`internal_id` AS `internal_id`, `ed`.`ref_id` AS `ref_id`, concat(`ed`.`emp_fname`,' ',case when `ed`.`emp_mname` is not null and `ed`.`emp_mname` <> '' then concat(substr(`ed`.`emp_mname`,1,1),'. ') else '' end,`ed`.`emp_lname`) AS `emp_full_name`, `ed`.`emp_position` AS `emp_position`, `es`.`log_date` AS `log_date`, `es`.`hours_worked` AS `hours_worked`, `es`.`hourly_rate` AS `hourly_rate`, `es`.`emp_sss` AS `emp_sss`, `es`.`emp_phic` AS `emp_phic`, `es`.`emp_pagibig` AS `emp_pagibig`, `es`.`emp_TIncome` AS `emp_TIncome`, `es`.`emp_TDeduc` AS `emp_TDeduc`, `es`.`emp_NetPay` AS `emp_netpay` FROM (`emp_details` `ed` join `emp_salary` `es` on(`ed`.`ref_id` = `es`.`ref_id`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `emp_details`
--
ALTER TABLE `emp_details`
  ADD PRIMARY KEY (`internal_id`);

--
-- Indexes for table `emp_salary`
--
ALTER TABLE `emp_salary`
  ADD PRIMARY KEY (`internal_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `emp_details`
--
ALTER TABLE `emp_details`
  MODIFY `internal_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `emp_salary`
--
ALTER TABLE `emp_salary`
  MODIFY `internal_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
