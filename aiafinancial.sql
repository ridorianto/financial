-- phpMyAdmin SQL Dump
-- version 3.1.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Aug 23, 2015 at 06:32 PM
-- Server version: 5.1.30
-- PHP Version: 5.2.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `aiafinancial`
--

-- --------------------------------------------------------

--
-- Table structure for table `dataagen`
--

CREATE TABLE IF NOT EXISTS `dataagen` (
  `kd_agen` char(10) NOT NULL,
  `nm_agen` varchar(35) NOT NULL,
  `jk` varchar(10) NOT NULL,
  `tmpt_lahir` varchar(30) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `status` varchar(20) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `keterangan` varchar(200) NOT NULL,
  `kd_pimpinan` char(10) NOT NULL,
  `tgl_daftar` date NOT NULL,
  PRIMARY KEY (`kd_agen`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dataagen`
--

INSERT INTO `dataagen` (`kd_agen`, `nm_agen`, `jk`, `tmpt_lahir`, `tgl_lahir`, `no_telp`, `status`, `alamat`, `keterangan`, `kd_pimpinan`, `tgl_daftar`) VALUES
('KDAA-002', 'Surti Suharja', 'Wanita', 'Tegal', '1980-07-09', '09872435678', 'Menikah', 'Jl.Kesuma Pemuda', 'Agen Tetap', 'KDPI-002', '2012-07-09'),
('KDAA-001', 'Udin Sedunia', 'Pria', 'Rantau', '1993-07-09', '095478967892', 'Lajang', 'Jl.Pembangunan', 'Agen Lepas', 'KDPI-001', '2014-07-09');

-- --------------------------------------------------------

--
-- Table structure for table `datanasabah`
--

CREATE TABLE IF NOT EXISTS `datanasabah` (
  `no_daftar` char(10) NOT NULL,
  `kd_agen` char(10) NOT NULL,
  `no_polis` varchar(30) NOT NULL,
  `nm_nasabah` varchar(35) NOT NULL,
  `jk` varchar(10) NOT NULL,
  `tmpt_lahir` varchar(30) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `wrg_negara` varchar(15) NOT NULL,
  `status` varchar(20) NOT NULL,
  `pekerjaan` varchar(30) NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `penerima_faedah` varchar(35) NOT NULL,
  `kd_produk` char(10) NOT NULL,
  `premi` varchar(30) NOT NULL,
  `kd_jnspembayaran` char(10) NOT NULL,
  `dana_per_bayar` int(30) NOT NULL,
  `lama_asuransi` varchar(30) NOT NULL,
  `nm_bank` varchar(30) NOT NULL,
  `no_rek` varchar(30) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `keterangan` varchar(200) NOT NULL,
  `tgl_daftar` date NOT NULL,
  `lama_jdnasabah` int(30) NOT NULL,
  `total_dana` int(50) NOT NULL,
  PRIMARY KEY (`no_daftar`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `datanasabah`
--

INSERT INTO `datanasabah` (`no_daftar`, `kd_agen`, `no_polis`, `nm_nasabah`, `jk`, `tmpt_lahir`, `tgl_lahir`, `wrg_negara`, `status`, `pekerjaan`, `no_telp`, `penerima_faedah`, `kd_produk`, `premi`, `kd_jnspembayaran`, `dana_per_bayar`, `lama_asuransi`, `nm_bank`, `no_rek`, `alamat`, `keterangan`, `tgl_daftar`, `lama_jdnasabah`, `total_dana`) VALUES
('NDDN-001', 'KDAA-001', 'A2350-4355R6', 'Sabaruddin', 'Pria', 'Ujung Kulon', '1990-07-09', 'WNI', 'Lajang', 'Wiraswasta', '0986325363', 'udin', 'KJPA-001', '200000', 'KJPB-001', 500000, '12', 'Mandiri', '098762-1232-9', 'Jl.Purowdadi', 'Testing udin', '2013-05-09', 2, 3050000),
('NDDN-002', 'KDAA-002', 'A2350-4355R7', 'Kabayan', 'Pria', 'Pekanbaru', '1990-07-09', 'WNI', 'Menikah', 'Dosen', '0852411811', 'test', 'KJPA-001', '200000', 'KJPB-001', 500000, '10', 'Mandiri', '0988-239239', 'Jl.Purwodadi', 'testing', '2014-05-09', 1, 2000000);

-- --------------------------------------------------------

--
-- Table structure for table `datapimpinan`
--

CREATE TABLE IF NOT EXISTS `datapimpinan` (
  `kd_pimpinan` char(10) NOT NULL,
  `nm_pimpinan` varchar(35) NOT NULL,
  `jk` varchar(10) NOT NULL,
  `tmpt_lahir` varchar(30) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `status` varchar(20) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `keterangan` varchar(200) NOT NULL,
  PRIMARY KEY (`kd_pimpinan`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `datapimpinan`
--

INSERT INTO `datapimpinan` (`kd_pimpinan`, `nm_pimpinan`, `jk`, `tmpt_lahir`, `tgl_lahir`, `no_telp`, `status`, `alamat`, `keterangan`) VALUES
('KDPI-001', 'Rido Rianto', 'Pria', 'Rantau', '1993-04-19', '085265662986', 'Lajang', 'Jl.Purwodadi', 'Pimpinan Aktif'),
('KDPI-002', 'Kabayan', 'Pria', 'Bagan Batu', '1995-02-28', '098762536333', 'Lajang', 'Jl.Pembangunana', 'Personalia');

-- --------------------------------------------------------

--
-- Table structure for table `jenisklaim`
--

CREATE TABLE IF NOT EXISTS `jenisklaim` (
  `kd_jnsklaim` char(10) NOT NULL,
  `jnsklaim` varchar(50) NOT NULL,
  PRIMARY KEY (`kd_jnsklaim`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jenisklaim`
--

INSERT INTO `jenisklaim` (`kd_jnsklaim`, `jnsklaim`) VALUES
('KJKN-001', 'Pendidikan');

-- --------------------------------------------------------

--
-- Table structure for table `jenispembayaran`
--

CREATE TABLE IF NOT EXISTS `jenispembayaran` (
  `kd_jnspembayaran` char(10) NOT NULL,
  `jnspembayaran` varchar(50) NOT NULL,
  PRIMARY KEY (`kd_jnspembayaran`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jenispembayaran`
--

INSERT INTO `jenispembayaran` (`kd_jnspembayaran`, `jnspembayaran`) VALUES
('KJPB-001', 'Tahunan'),
('KJPB-002', 'Bulanan');

-- --------------------------------------------------------

--
-- Table structure for table `jenispenarikan`
--

CREATE TABLE IF NOT EXISTS `jenispenarikan` (
  `kd_jnspenarikan` char(10) NOT NULL,
  `jnspenarikan` varchar(50) NOT NULL,
  PRIMARY KEY (`kd_jnspenarikan`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jenispenarikan`
--

INSERT INTO `jenispenarikan` (`kd_jnspenarikan`, `jnspenarikan`) VALUES
('KJPD-001', 'Tunai');

-- --------------------------------------------------------

--
-- Table structure for table `jenisproduk`
--

CREATE TABLE IF NOT EXISTS `jenisproduk` (
  `kd_produk` char(10) NOT NULL,
  `nm_produk` varchar(50) NOT NULL,
  PRIMARY KEY (`kd_produk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jenisproduk`
--

INSERT INTO `jenisproduk` (`kd_produk`, `nm_produk`) VALUES
('KJPA-001', 'Kesehatan');

-- --------------------------------------------------------

--
-- Table structure for table `jenissetoran`
--

CREATE TABLE IF NOT EXISTS `jenissetoran` (
  `kd_jnssetor` char(10) NOT NULL,
  `jnssetor` varchar(50) NOT NULL,
  PRIMARY KEY (`kd_jnssetor`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jenissetoran`
--

INSERT INTO `jenissetoran` (`kd_jnssetor`, `jnssetor`) VALUES
('KJSN-001', 'Cek');

-- --------------------------------------------------------

--
-- Table structure for table `klaimnasabah`
--

CREATE TABLE IF NOT EXISTS `klaimnasabah` (
  `kd_klaim` char(10) NOT NULL,
  `kd_jnsklaim` char(10) NOT NULL,
  `no_daftar` char(10) NOT NULL,
  `tgl_klaim` date NOT NULL,
  `keterangan` varchar(200) NOT NULL DEFAULT '',
  PRIMARY KEY (`kd_klaim`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `klaimnasabah`
--

INSERT INTO `klaimnasabah` (`kd_klaim`, `kd_jnsklaim`, `no_daftar`, `tgl_klaim`, `keterangan`) VALUES
('KKAN-001', 'KJKN-001', 'NDDN-002', '2015-07-10', 'Klaim Asuransi Kesehatan Anak'),
('KKAN-002', 'KJKN-001', 'NDDN-001', '2013-05-10', 'Klaim Asuransi Pendidikan');

-- --------------------------------------------------------

--
-- Table structure for table `penarikannasabah`
--

CREATE TABLE IF NOT EXISTS `penarikannasabah` (
  `kd_penarikan` char(10) NOT NULL,
  `kd_jnsklaim` char(10) NOT NULL,
  `kd_jnspenarikan` char(10) NOT NULL,
  `no_daftar` char(10) NOT NULL,
  `jml_dana` int(8) NOT NULL,
  `tgl_penarikan` date NOT NULL,
  `keterangan` varchar(200) NOT NULL,
  `sisa_danaseluruh` int(10) NOT NULL,
  PRIMARY KEY (`kd_penarikan`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penarikannasabah`
--

INSERT INTO `penarikannasabah` (`kd_penarikan`, `kd_jnsklaim`, `kd_jnspenarikan`, `no_daftar`, `jml_dana`, `tgl_penarikan`, `keterangan`, `sisa_danaseluruh`) VALUES
('KPDN-001', 'KJKN-001', 'KJPD-001', 'NDDN-001', 250000, '2013-07-11', 'kesehatan', 2550000);

-- --------------------------------------------------------

--
-- Table structure for table `setorannasabah`
--

CREATE TABLE IF NOT EXISTS `setorannasabah` (
  `kd_setor` char(10) NOT NULL,
  `kd_jnsklaim` char(10) NOT NULL,
  `kd_jnssetor` char(10) NOT NULL,
  `no_daftar` char(10) NOT NULL,
  `jml_dana` int(8) NOT NULL,
  `tgl_setor` date NOT NULL,
  `keterangan` varchar(200) NOT NULL,
  `jml_danaseluruh` int(10) NOT NULL,
  PRIMARY KEY (`kd_setor`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `setorannasabah`
--

INSERT INTO `setorannasabah` (`kd_setor`, `kd_jnsklaim`, `kd_jnssetor`, `no_daftar`, `jml_dana`, `tgl_setor`, `keterangan`, `jml_danaseluruh`) VALUES
('KSNA-001', 'KJKN-001', 'KJSN-001', 'NDDN-001', 500000, '2014-07-10', 'Stor Asuransi Anak', 3050000),
('KSNA-002', 'KJKN-001', 'KJSN-001', 'NDDN-002', 500000, '2015-05-10', 'Setor Asuransi', 2000000);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `kd_user` char(10) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(50) NOT NULL,
  `level` varchar(10) NOT NULL,
  PRIMARY KEY (`kd_user`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`kd_user`, `username`, `password`, `level`) VALUES
('KDUA-001', 'admin', 'admin', 'Admin'),
('KDUA-002', 'agen', 'agen', 'Agen');
