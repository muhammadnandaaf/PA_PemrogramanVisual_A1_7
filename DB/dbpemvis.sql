-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2023 at 01:09 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbpemvis`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbakun`
--

CREATE TABLE `tbakun` (
  `idUser` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `telepon` int(15) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbakun`
--

INSERT INTO `tbakun` (`idUser`, `username`, `telepon`, `email`, `password`) VALUES
(1, 'nanda', 2147483647, 'nanda@gmail.com', 'nanda123'),
(2, 'tes', 123, 'tes', 'tes123'),
(3, 'user', 1234, 'user@gmail.com', 'user123'),
(4, 'fikri', 12345, 'fikri@gmail.com', 'fikri123');

-- --------------------------------------------------------

--
-- Table structure for table `tbkue`
--

CREATE TABLE `tbkue` (
  `idKue` int(11) NOT NULL,
  `namaKue` varchar(100) NOT NULL,
  `jenisKue` varchar(100) NOT NULL,
  `hargaKue` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbkue`
--

INSERT INTO `tbkue` (`idKue`, `namaKue`, `jenisKue`, `hargaKue`) VALUES
(1, 'Nastar', 'Kue Kering', 150000),
(2, 'Putri Salju', 'Kue Kering', 200000),
(4, 'kastengel', 'Kue Kering', 115000),
(5, 'kuecoklat', 'Kue Kering', 4),
(6, 'bingka', 'Kue Basah', 15000),
(7, 'Kue Asam', 'Kue Basah', 10000);

-- --------------------------------------------------------

--
-- Table structure for table `tbpesanan`
--

CREATE TABLE `tbpesanan` (
  `idPesanan` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `kueId` int(11) NOT NULL,
  `namaKue` varchar(50) NOT NULL,
  `jumlahPesanan` int(11) NOT NULL,
  `totalHarga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbpesanan`
--

INSERT INTO `tbpesanan` (`idPesanan`, `userId`, `kueId`, `namaKue`, `jumlahPesanan`, `totalHarga`) VALUES
(3, 2, 1, 'Nastar', 1, 150000),
(4, 3, 4, 'kastengel', 1, 115000),
(6, 3, 5, 'kuecoklat', 2, 40),
(8, 3, 7, 'Kue Asam', 5, 50000),
(10, 2, 5, 'kuecoklat', 1, 4),
(11, 3, 2, 'Putri Salju', 2, 400000);

-- --------------------------------------------------------

--
-- Table structure for table `tbtransaksi`
--

CREATE TABLE `tbtransaksi` (
  `idTransaksi` int(11) NOT NULL,
  `idPesanan` int(11) NOT NULL,
  `idUser` int(11) NOT NULL,
  `totalBayar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbtransaksi`
--

INSERT INTO `tbtransaksi` (`idTransaksi`, `idPesanan`, `idUser`, `totalBayar`) VALUES
(1, 4, 3, 1100000),
(2, 3, 2, 150000),
(3, 10, 2, 4),
(4, 11, 3, 400000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbakun`
--
ALTER TABLE `tbakun`
  ADD PRIMARY KEY (`idUser`);

--
-- Indexes for table `tbkue`
--
ALTER TABLE `tbkue`
  ADD PRIMARY KEY (`idKue`);

--
-- Indexes for table `tbpesanan`
--
ALTER TABLE `tbpesanan`
  ADD PRIMARY KEY (`idPesanan`),
  ADD KEY `userId` (`userId`),
  ADD KEY `kueId` (`kueId`);

--
-- Indexes for table `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  ADD PRIMARY KEY (`idTransaksi`),
  ADD KEY `idPesanan` (`idPesanan`),
  ADD KEY `idUser` (`idUser`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbakun`
--
ALTER TABLE `tbakun`
  MODIFY `idUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbkue`
--
ALTER TABLE `tbkue`
  MODIFY `idKue` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbpesanan`
--
ALTER TABLE `tbpesanan`
  MODIFY `idPesanan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  MODIFY `idTransaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbpesanan`
--
ALTER TABLE `tbpesanan`
  ADD CONSTRAINT `tbpesanan_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `tbakun` (`idUser`),
  ADD CONSTRAINT `tbpesanan_ibfk_2` FOREIGN KEY (`kueId`) REFERENCES `tbkue` (`idKue`);

--
-- Constraints for table `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  ADD CONSTRAINT `tbtransaksi_ibfk_1` FOREIGN KEY (`idPesanan`) REFERENCES `tbpesanan` (`idPesanan`),
  ADD CONSTRAINT `tbtransaksi_ibfk_2` FOREIGN KEY (`idUser`) REFERENCES `tbakun` (`idUser`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
