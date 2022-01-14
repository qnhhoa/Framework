-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 14, 2022 at 04:28 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cosmetic`
--

-- --------------------------------------------------------

--
-- Table structure for table `blog`
--

CREATE TABLE `blog` (
  `ID` int(7) NOT NULL,
  `title` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `author` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `photo` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `content` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `link_post` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `blog`
--

INSERT INTO `blog` (`ID`, `title`, `author`, `photo`, `content`, `link_post`) VALUES
(2, 'Makeup Tutorial: GLITTER EYES', 'Wendy Rowe', 'https://imagizer.imageshack.com/img924/174/jF17jl.jpg', 'Ready to sparkle this party season? It’s the eyes that have it! Follow my latest video tutorial for the perfect glittering eye makeup to get you through the season in style. If you’re anything like me, Christmas Day and New Year’s Eve call for glitter and sparkle! For this week’s YouTube tutorial, I’ve ....', 'https://wendyrowe.com/makeup/glitter-eyes'),
(3, 'My Winter Wardrobe Wishlist', 'Anna', 'https://imageshack.com/i/poQO0Pjap', 'The pieces that I’m filling up my basket with. I have to preface this post by saving that if you watched my recent haul video then you will know that I definitely don’t need to buy anymore clothes anytime soon (I mean baby clothes don’t count, right?),...', 'https://www.theannaedit.com/my-winter-wardrobe-wishlist'),
(4, '3 MULTIPURPOSE BEAUTY PRODUCTS', 'Amber', 'https://imageshack.com/i/podwscY3p', 'On our last day on our way towards the airport we stopped off at this alpaca farm! We were just looking at them through the fence but then the owner came out and invited us to come back and meet the alpacas. She introduced us to all of them by name which I thought was so cool (there were literally SO many!)...', 'https://amberfillerup.com/3-multipurpose-beauty-products'),
(5, 'LLAMAS AND APPLE PICKING', 'Amber', 'https://imagizer.imageshack.com/img923/1278/ilyZJ5.png', 'Today, I am talking about my 3 top beauty products that are a must for me. If I could say I need all my beauty items then I absolutely would, lol! But, let\'s just narrow this down to 3 items that are versatile and can really enhance your beauty for when you are on the go and limited with products....', 'https://amberfillerup.com/llamas-and-apple-picking');

-- --------------------------------------------------------

--
-- Table structure for table `cthd`
--

CREATE TABLE `cthd` (
  `ID` int(7) NOT NULL,
  `MaHD` int(7) NOT NULL,
  `SpID` int(7) NOT NULL,
  `SL` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `cthd`
--

INSERT INTO `cthd` (`ID`, `MaHD`, `SpID`, `SL`) VALUES
(33, 65, 63, 1),
(37, 70, 68, 1),
(42, 75, 5, 1),
(43, 76, 69, 1),
(44, 76, 66, 1),
(45, 77, 50, 1),
(46, 78, 68, 1),
(47, 78, 67, 1),
(63, 136, 3, 1),
(64, 136, 6, 1),
(65, 137, 66, 1),
(66, 138, 19, 1),
(70, 140, 40, 1),
(71, 141, 4, 1),
(72, 142, 40, 1),
(73, 143, 65, 1),
(74, 144, 40, 1),
(75, 145, 40, 1),
(76, 146, 6, 1),
(77, 146, 40, 2),
(78, 147, 40, 3),
(79, 147, 41, 1),
(80, 148, 40, 2);

-- --------------------------------------------------------

--
-- Table structure for table `dangnhap`
--

CREATE TABLE `dangnhap` (
  `Username` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Password` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `HoTen` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SDT` varchar(11) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DiaChi` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cRole` int(1) NOT NULL,
  `Email` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `picture` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `dangnhap`
--

INSERT INTO `dangnhap` (`Username`, `Password`, `HoTen`, `SDT`, `DiaChi`, `cRole`, `Email`, `picture`) VALUES
('104353224208067050500', '', 'Quỳnh Hoa Phan Phạm', '73839399', 'TP HCM', 0, '19520814@gm.uit.edu.vn', ''),
('112604892139527679327', '', 'Huỳnh Tân', '', '', 1, 'hihitanne@gmail.com', ''),
('114534760135627553360', '', 'Hướng Nguyễn Thị Cẩm', '', '', 1, '19521594@gm.uit.edu.vn', 'https://lh3.googleusercontent.com/a-/AOh14GglxDMuJ0iPa6eFAlVMm3fWumrXyGRXfYLuxl0x=s96-c'),
('118256469645939714626', '', 'Hướng Nguyễn', '', '', 1, 'nguyenhuong04032001@gmail.com', 'https://lh3.googleusercontent.com/a-/AOh14GiUj3k9d7cXGlo6mKHF24yz21v5Q4nbW7QBTcP_=s96-c'),
('huongne', '123', 'Nguyen Thi Cam Huong', '073738', 'Thu Duc', 1, 'huong@gmail.com', ''),
('lenhan', '123', 'Le Nhan', '63738', 'SG', 1, 'nhan@gmail.com', ''),
('lili', '123', 'hihi', '8939', 'HN', 1, '678@gmail.com', ''),
('nguyenhuong', '123', 'NguyenThiCamHuong', '12345678901', 'Tanuyen', 1, 'huo@gmail.com', ''),
('nhi0106', '123', 'Phuong Nhi', '0637373', 'SG', 1, 'nhi@gmail.com', ''),
('qnhhoa', '123', 'Phan Phạm Quỳnh Hoa', '0363882', 'TPHCM', 0, '19521520@gm.uit.edu.vn', ''),
('tuitenhuong', '123', 'nguyenthicamhuong', '1234567', 'bd', 1, 'h@gmail.com', '');

-- --------------------------------------------------------

--
-- Table structure for table `danhgia`
--

CREATE TABLE `danhgia` (
  `ID` int(7) NOT NULL,
  `Username` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SpID` int(7) NOT NULL,
  `Rating` float NOT NULL,
  `Comment` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `danhgia`
--

INSERT INTO `danhgia` (`ID`, `Username`, `SpID`, `Rating`, `Comment`) VALUES
(1, 'qnhhoa', 7, 5, 'Great!'),
(2, 'nhi0106', 7, 4, ''),
(3, 'lenhan', 7, 3.5, ''),
(41, '114534760135627553360', 50, 4, ''),
(42, '118256469645939714626', 67, 2, ''),
(43, 'tuitenhuong', 68, 5, ''),
(44, 'qnhhoa', 4, 5, ''),
(45, 'qnhhoa', 4, 3, ''),
(46, 'huongne', 4, 4, ''),
(50, 'qnhhoa', 66, 4, ''),
(52, 'qnhhoa', 1, 4.55, ''),
(53, 'qnhhoa', 1, 4.55, ''),
(54, 'qnhhoa', 1, 5, ''),
(55, 'qnhhoa', 6, 3.5, ''),
(56, 'qnhhoa', 3, 5, ''),
(57, 'qnhhoa', 56, 4, '');

-- --------------------------------------------------------

--
-- Table structure for table `donhang`
--

CREATE TABLE `donhang` (
  `MaHD` int(7) NOT NULL,
  `Trangthai` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `NgayHD` datetime NOT NULL DEFAULT current_timestamp(),
  `NgayNH` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `donhang`
--

INSERT INTO `donhang` (`MaHD`, `Trangthai`, `NgayHD`, `NgayNH`) VALUES
(10, 'Pickup', '2021-12-18 14:34:59', '2021-12-23'),
(12, 'Delivered', '2021-12-18 13:48:51', '2021-12-09'),
(13, 'Pickup', '2021-12-19 13:27:12', '2021-12-22'),
(70, 'Pickup', '2021-12-20 01:50:19', '2021-12-23'),
(75, 'Pickup', '2021-12-20 02:03:56', '2021-12-23'),
(76, 'Pickup', '2021-12-20 23:52:57', '2021-12-23'),
(77, 'Pickup', '2021-12-21 02:07:27', '2021-12-24'),
(78, 'Pickup', '2021-12-21 02:39:20', '2021-12-24'),
(128, 'Pickup', '2022-01-13 13:06:58', '2022-01-16'),
(129, 'Pickup', '2022-01-13 13:07:42', '2022-01-16'),
(130, 'Pickup', '2022-01-13 13:07:59', '2022-01-16'),
(131, 'Pickup', '2022-01-13 13:09:19', '2022-01-16'),
(132, 'Pickup', '2022-01-13 13:10:00', '2022-01-16'),
(133, 'Pickup', '2022-01-13 13:16:18', '2022-01-16'),
(134, 'Pickup', '2022-01-13 13:18:13', '2022-01-16'),
(135, 'Pickup', '2022-01-13 13:24:20', '2022-01-16'),
(136, 'Pickup', '2022-01-13 13:25:10', '2022-01-16'),
(137, 'Pickup', '2022-01-13 13:47:58', '2022-01-16'),
(138, 'Pickup', '2022-01-13 14:17:58', '2022-01-16'),
(140, 'Pickup', '2022-01-13 21:44:22', '2022-01-16'),
(141, 'Pickup', '2022-01-13 21:46:29', '2022-01-16'),
(142, 'Pickup', '2022-01-13 21:47:26', '2022-01-16'),
(143, 'Pickup', '2022-01-13 21:56:20', '2022-01-16'),
(144, 'Pickup', '2022-01-13 21:56:57', '2022-01-16'),
(145, 'Pickup', '2022-01-13 21:59:51', '2022-01-16'),
(146, 'Pickup', '2022-01-14 08:44:34', '2022-01-17'),
(147, 'Pickup', '2022-01-14 08:59:32', '2022-01-17'),
(148, 'On process', '2022-01-14 09:04:24', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `hoadon`
--

CREATE TABLE `hoadon` (
  `MaHD` int(11) NOT NULL,
  `Username` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Address` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `PhoneNumber` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Fullname` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Note` varchar(1000) COLLATE utf8mb4_unicode_ci NOT NULL,
  `TongTien` int(100) NOT NULL,
  `Method` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `hoadon`
--

INSERT INTO `hoadon` (`MaHD`, `Username`, `Address`, `PhoneNumber`, `Fullname`, `Note`, `TongTien`, `Method`) VALUES
(10, 'nhi0106', 'HN', '06748', 'Nguyen Thi Phuong Nhi', '', 40, 'Cash on delivery'),
(12, 'qnhhoa', 'SG', '03738', 'Quynh Hoa', '', 45, 'Momo wallet'),
(13, 'huongne', 'SG', '03737', 'Nguyen Thi Cam Huong', '', 40, 'Momo Wallet'),
(23, '118256469645939714626', 'Tanuyen', '0939393939', 'NguyenThiCamHuong', 'dsss', 133, 'cash'),
(24, 'huongne', 'Tanuyen', '0939393939', 'NguyenThiCamHuong', 'dsss', 34, 'cash'),
(65, '114534760135627553360', 'Tanuyen', '0939393939', 'NguyenThiCamHuong', '', 17, 'momo'),
(70, 'tuitenhuong', 'Tanuyen', '0939393939', 'NguyenThiCamHuong', '', 75, 'cash'),
(75, '114534760135627553360', 'Tanuyen', '0939393939', 'huonghuong', '', 90, 'momo'),
(76, '114534760135627553360', 'Tanuyen', '0939393939', 'huonghuong', '', 89, 'cash'),
(77, '114534760135627553360', 'Thu Duc', '0939393939', 'qweqe', '', 35, 'shopeepay'),
(78, '118256469645939714626', 'Thu Duc', '0939393939', 'QuynhHoa', '', 100, 'cash'),
(96, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'shopeepay'),
(108, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'shopeepay'),
(109, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', 'qwq', 122, 'cash'),
(110, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', 'qwq', 122, 'cash'),
(111, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', 'qwq', 122, 'cash'),
(128, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'cash'),
(129, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'cash'),
(130, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'cash'),
(131, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'cash'),
(132, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'cash'),
(133, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'cash'),
(134, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'cash'),
(135, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'cash'),
(136, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 122, 'cash'),
(137, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 55, 'momo'),
(138, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 89, 'momo'),
(140, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 34, 'cash'),
(141, '104353224208067050500', 'Thu duc district', '918743787', 'Phan Pham Quỳnh Hoa', '', 70, 'momo'),
(142, '104353224208067050500', 'Thu duc district', '918743787', 'Phan Pham Quỳnh Hoa', '', 34, 'momo'),
(143, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 28, 'shopeepay'),
(144, '104353224208067050500', 'Thu duc district', '819332447', 'Phạm Thị Kim Huế', '', 34, 'cash'),
(145, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 34, 'shopeepay'),
(146, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 126, 'cash'),
(147, 'qnhhoa', 'TPHCM', '363882', 'Phan Phạm Quỳnh Hoa', '', 128, 'cash'),
(148, 'qnhhoa', 'TPHCM', '363882', '', '', 132, 'zalopay');

-- --------------------------------------------------------

--
-- Table structure for table `loaisp`
--

CREATE TABLE `loaisp` (
  `MaLSP` int(7) NOT NULL,
  `TenLSP` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `loaisp`
--

INSERT INTO `loaisp` (`MaLSP`, `TenLSP`) VALUES
(1, 'Skin care'),
(2, 'Body care'),
(3, 'Hair care'),
(4, 'Makeup');

-- --------------------------------------------------------

--
-- Table structure for table `nhacc`
--

CREATE TABLE `nhacc` (
  `BrandID` int(7) NOT NULL,
  `TenNcc` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `GioiThieu` varchar(1000) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Quocgia` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `photo` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `nhacc`
--

INSERT INTO `nhacc` (`BrandID`, `TenNcc`, `GioiThieu`, `Quocgia`, `photo`) VALUES
(1, 'LA ROCHE-POSAY', 'Discover award-winning skincare with La Roche-Posay. Designed and recommended by dermatologists across the world, the brand provides the answers to your skincare concerns. Try the Effaclar Cleansing Gel to help combat acne or reach for the Pure Vitamin C10 Serum to brighten up your complexion. Whatever your skincare need, La Roche-Posay has you covered.', 'France', ''),
(2, 'Innisfree', 'Launched in 2000, Innisfree is a natural beauty Korean skincare brand sold in more than 1788 stores worldwide. The product range includes, toners, lotions, masks, sun care, eye related products and more.', 'Korea', 'hii'),
(3, 'DEAR DAHLIA', 'Dear Dahlia is a luxury vegan beauty brand that offers 100% vegan and cruelty-free products. We believe in timeless beauty that is classic but never ordinary.', 'Korea', ''),
(4, 'BURBERRY BEAUTY', 'Burberry makeup is loved by celebrities and supermodels including Rosie Huntington-Whiteley, and with good reason. Their expert formulations have been inspired by the runway, utilising the best ingredients with trend-led colours to create products you can wear both for everyday and for the evening. Now everyone can capture that beautifully British “Burberry glow” from the comfort of their own home.', 'England', ''),
(5, 'DIOR', 'When Christian Dior created his fashion house in 1946, he wanted women to rediscover joy, elegance and beauty. In a span of ten years, he empowered women by revolutionising conventional definitions of elegance and femininity. Today, his namesake label is synonymous with French luxury, appearing on haute couture, makeup, skincare and fragrances.', 'France', ''),
(6, 'GUCCI', 'The influential, innovative and progressive spirit that has established Gucci as a leader in luxury since 1921 carries through its beauty line from fine fragrances to makeup as part of the Kering Group. Gucci believes everyone should be able to wear makeup however they want to, as a way to reveal your true self, to be yourself, or whoever you want to be.', 'Italy', ''),
(7, 'ESTÉE LAUDER', 'Building her brand on the simple notion that “Every woman can be beautiful,” Estée Lauder’s vision, determination and revolutionary formulas have changed the face of the beauty business. From countless innovations and industry firsts, the brand continues to reinvent the world of beauty and inspire women with its unparalleled high-performance skincare, foundation, makeup and fragrance products.', 'England', ''),
(14, 'Moroccanoil', '', '', ''),
(15, 'KEVIN.MURPHY', '', '', ''),
(16, 'Senka', '', 'Japan', ''),
(17, 'Neutrogena', '', 'USA', ''),
(18, 'L\'Oréal', '', 'France', ''),
(19, 'SEPHORA', '', 'USA', ''),
(20, 'CIRCA', '', '', ''),
(21, 'BIOSSANCE', '', '', ''),
(22, 'JOANNA VARGAS', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `sanpham`
--

CREATE TABLE `sanpham` (
  `SpID` int(7) NOT NULL,
  `TenSP` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Photo` varchar(1000) COLLATE utf8mb4_unicode_ci NOT NULL,
  `MoTa` varchar(1000) COLLATE utf8mb4_unicode_ci NOT NULL,
  `MaLSP` int(7) NOT NULL,
  `GiaSP` int(11) NOT NULL,
  `SL` int(11) NOT NULL,
  `BrandID` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `sanpham`
--

INSERT INTO `sanpham` (`SpID`, `TenSP`, `Photo`, `MoTa`, `MaLSP`, `GiaSP`, `SL`, `BrandID`) VALUES
(1, 'CICAPLAST BAUME B5 FOR DRY SKIN IRRITATIONS', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img923/2801/ouo13v.jpg\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img923/2801/ouo13v.jpg\"},{\"photo\":\"https://imagizer.imageshack.com/img923/2801/ouo13v.jpg\"}]}', 'This multi-purpose soothing cream for cracked, chapped, chafed skin and dry skin irritations helps to hydrate and soothe. Non-greasy, skin protectant helps to protect & relieve dry, rough skin. Hydrating therapeutic cream protects chafed skin due to diaper rash and helps seal out wetness, while helping to treat & prevent diaper rash. Suitable for adults, children and babies 1 week and up.', 1, 15, 200, 1),
(3, 'Skin Paradise Blooming Cushion Foundation 14ml', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/6629/dgtpXK.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/6629/dgtpXK.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/6629/dgtpXK.png\"}]}', 'A lightweight cushion foundation that combines expert wear and finish of a liquid foundation with the convenience of a cushion pact.', 4, 64, 200, 3),
(4, 'Skin Paradise Sheer Silk Foundation', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img922/1003/nko5qY.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img922/1003/nko5qY.png\"},{\"photo\":\"https://imagizer.imageshack.com/img922/1003/nko5qY.png\"}]}', 'A luminous liquid silk foundation available in collective spectrum of 35 shades in warm, cool, and neutral undertones with a natural airbrush effect', 4, 78, 200, 3),
(5, 'Ultimate Glow Cushion Foundation', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/484/Hu8eac.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/484/Hu8eac.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/484/Hu8eac.png\"}]}', 'A luxurious serum foundation for a multidimensional, youthful glow day or night.', 4, 90, 10, 4),
(6, 'Lip Paradise Effortless Matte Lipstick 3.2g', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/4330/5gC67w.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/4330/5gC67w.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/4330/5gC67w.png\"}]}', 'A full-coverage and true-matte finish lipstick formulated with Cacao Seed Butter and natural, hydrating ingredients.', 4, 58, 50, 3),
(7, 'Essential Glow Face Palette 7g', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img923/4870/GAR5s6.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img923/4870/GAR5s6.png\"},{\"photo\":\"https://imagizer.imageshack.com/img923/4870/GAR5s6.png\"}]}', 'A three-in-one face palette in radiant tones, to instantly sculpt, colour and highlight.', 4, 98, 200, 4),
(8, 'Bright Glow Foundation', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/6272/NpTnSo.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/6272/NpTnSo.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/6272/NpTnSo.png\"}]}', 'Discover Bright Glow Foundation, a skin brightening foundation for a radiant, lit-from-within complexion and flawless translucency.', 4, 98, 10, 4),
(9, 'Skin Paradise Pore Perfecting Primer 35 ml', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/5323/mlrjnw.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/5323/mlrjnw.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/5323/mlrjnw.png\"}]}', 'A pore-perfecting primer that creates a smooth, even surface, minimising the look of visible pores, fine lines and imperfections.', 4, 57, 200, 3),
(10, 'Light Glow Blush', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/9127/4C5keq.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/9127/4C5keq.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/9127/4C5keq.png\"}]}', 'A blendable, lightweight powder blush that enhances the cheeks.\r\nWhat it does:\r\n', 4, 72, 50, 4),
(11, 'Kisses Matte Lipstick 3.3g', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img923/9115/k2T3RP.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img923/9115/k2T3RP.png\"},{\"photo\":\"https://imagizer.imageshack.com/img923/9115/k2T3RP.png\"}]}', 'A matte lipstick designed to make a lasting impact.', 4, 56, 20, 4),
(12, 'Burberry Kisses Sheer Lipstick', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img923/3717/eegN2g.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img923/3717/eegN2g.png\"},{\"photo\":\"https://imagizer.imageshack.com/img923/3717/eegN2g.png\"}]}', 'Introducing Burberry Kisses Sheer, an ultra-lightweight and hydrating lipstick that delivers sheer, buildable colour and shine.', 4, 50, 15, 4),
(13, 'Ultimate Lift Mascara 8ml', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img922/8946/U0h5mC.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img922/8946/U0h5mC.png\"},{\"photo\":\"https://imagizer.imageshack.com/img922/8946/U0h5mC.png\"}]}', 'A mascara that combines volume, curl and length for an instant lifting effect that lasts all day.', 4, 56, 20, 4),
(14, 'Show Iconic Overcurl Eye Makeup Set (Limited Edition)', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/545/QXKNJO.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/545/QXKNJO.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/545/QXKNJO.png\"}]}', 'A box decorated with the Dior Atelier des Rêves Motifs, housing the Diorshow Maximizer 3d Mascara Primer-Serum and the Diorshow Iconic Overcurl Mascara', 4, 58, 20, 5),
(15, 'Mono Couleur Couture High-Color Eyeshadow 2g', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img923/9115/k2T3RP.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img923/9115/k2T3RP.png\"},{\"photo\":\"https://imagizer.imageshack.com/img923/9115/k2T3RP.png\"}]}', 'A long-wear eyeshadow palette with bold colours and spectacular effects.', 4, 52, 20, 5),
(16, 'Dior Lip Sugar Scrub 4g', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img923/5333/6sPIDL.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img923/5333/6sPIDL.png\"},{\"photo\":\"https://imagizer.imageshack.com/img923/5333/6sPIDL.png\"}]}', 'An exfoliating and nurturing stick with grains of sugar that melt away for incredibly soft lips and a naturally glossy look.', 4, 55, 50, 5),
(17, 'Rouge Dior Ultra Care Flower Oil Lipstick', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/7919/4aeE5e.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/7919/4aeE5e.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/7919/4aeE5e.png\"}]}', 'Dior\'s first lipstick infused with flower oil.', 4, 59, 30, 5),
(18, 'Vernis Nail Lacquer Nail Polish 10ml', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img922/1030/sX0T7X.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img922/1030/sX0T7X.png\"},{\"photo\":\"https://imagizer.imageshack.com/img922/1030/sX0T7X.png\"}]}', 'An emblematic ultra-shiny Dior nail lacquer that coats nails in a long-wear couture colour.', 4, 41, 50, 5),
(19, 'Hydra Life Micellar Water No Rinse Cleanser 200ml', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/8956/AWZk7z.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/8956/AWZk7z.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/8956/AWZk7z.png\"}]}', 'A new-generation no-rinse micellar cleansing water by Dior that removes face and eye makeup and tones in a single step. \"A new-generation* micellar water that offers a concentration of powerful makeup removal properties and a fresh, comforting texture', 1, 65, 200, 5),
(20, 'Rouge De Beaute Brillant Lipstick 1.8g', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/9566/fvYkWi.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/9566/fvYkWi.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/9566/fvYkWi.png\"}]}', 'A lipstick that deeply moisturises for over 24 hours, with long-lasting and with high shine power.', 4, 64, 100, 6),
(40, 'Hydrating Styling Cream', '{\"PhotoMain\":\"https://i.upimg.com/bio_Gce5W\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/Fb24RF5Xlb\"},{\"photo\":\"https://i.upimg.com/BRB7pmnpc\"},{\"photo\":\"https://i.upimg.com/KwwjC9vn9\"}]}', 'Moroccanoil® Hydrating Styling Cream conditions, hydrates and tames frizzy hair. This leave-in, moisture-rich styling cream creates a soft, natural feel. Perfect for blow-drying, smoothing flyaways and refreshing styles the next day, this nourishing, argan oil-infused hair styling cream adds shine and definition with a soft hold.', 3, 34, 100, 14),
(41, 'Dry Shampoo Light Tones', '{\"PhotoMain\":\"https://i.upimg.com/62wB7eXC0\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/gszIp1ebdo\"},{\"photo\":\"https://i.upimg.com/Bu1-HlcH3m\"},{\"photo\":\"https://i.upimg.com/k4_UYPD5V\"}, {\"photo\":\"https://i.upimg.com/-ZAXXxq9rW\"}]}', 'Hair color is personal. Dry shampoo should be too. By popular demand, Moroccanoil® launches its first-ever dry shampoo in two formulas, for Light Hair Tones and for Dark Hair Tones.\r\nMoroccanoil Dry Shampoo Light Tones contains ultra-fine rice starch that absorbs oil, buildup and odor, leaving hair instantly cleansed and refreshed. UV-protecting, argan oil-infused formula contains subtle violet undertones to balance brassiness in blonde hair and bring out the best in light tones.\r\n', 3, 26, 100, 14),
(42, 'Curl Defining Cream', '{\"PhotoMain\":\"https://i.upimg.com/w36VS4Le8\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/hDsVr7xm4I\"},{\"photo\":\"https://i.upimg.com/BuFKMCqsu\"},{\"photo\":\"https://i.upimg.com/wyO18TbcBH\"}]}', 'Easily activate and define curls while hydrating hair. Moroccanoil® Curl Defining Cream is one of our most popular products for curly hair. This argan oil-infused curl definer features an advanced heat-activated technology that provides a curl memory factor to fight frizz and create well-defined, natural-looking, bouncy curls that last.\r\n- Brand: Moroccanoil\r\n', 3, 35, 100, 14),
(43, 'Restorative Hair Mask', '{\"PhotoMain\":\"https://i.upimg.com/QSowHYlFQ4\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/EMYFqXtUr\"},{\"photo\":\"https://i.upimg.com/rLCHfKctH\"},{\"photo\":\"https://i.upimg.com/0QmLrGEsjd\"},{\"photo\":\"https://i.upimg.com/IRQeRR67CK\"}]}', 'For damaged hair in need of repair, Moroccanoil® Restorative Hair Mask is a 5–7-minute treatment for use on hair damaged by chemical treatments or heat styling. Its high-performance formula contains argan oil, shea butter, and keratin proteins that help fortify hair, increase elasticity, and promote a healthier look and feel.', 3, 64, 50, 14),
(44, 'Moisture Repair Conditioner', '{\"PhotoMain\":\"https://i.upimg.com/u2zjPV2EdR\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/QXWFR1qKJ\"},{\"photo\":\"https://i.upimg.com/UFAA8WFLM\"},{\"photo\":\"https://i.upimg.com/ncKL75oAH\"},{\"photo\":\"https://i.upimg.com/3wICgt0Mye\"}]}', 'Restore damaged hair caused by color, chemical processing or heat styling. Moroccanoil® Moisture Repair Conditioner gently and effectively detangles and conditions the hair to leave it hydrated, manageable and strong. Its highly concentrated, reparative formula restores hair\'s health, moisture and elasticity with antioxidant-rich argan oil, reconstructive keratin and fatty acids. Color-safe. Sulfate-free, phosphate-free and paraben-free.', 3, 24, 100, 14),
(45, 'Moroccanoil Treatment Light', '{\"PhotoMain\":\"https://i.upimg.com/cy3Dw56vj\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/IHQMXnw7t\"},{\"photo\":\"https://imagizer.imageshack.com/img924/3443/ABhPW7.jpg\"},{\"photo\":\"https://i.upimg.com/g5bKTiuLF\"},{\"photo\":\"https://i.upimg.com/jxHiLLMvI\"}]}', 'DISCOVER THE ORIGINAL Enjoy healthy, silky, shiny hair that\'s full of life. Moroccanoil® Treatment Light is specifically formulated for the delicate needs of light-colored (including platinum and white) and fine hair. The original foundation for hairstyling, Moroccanoil Treatment Light can be used as a conditioning, styling and finishing tool all in one. Infused with antioxidant-rich argan oil and shine-boosting vitamins, this nourishing treatment detangles, speeds up drying time and boosts shine—leaving hair smooth and more manageable than ever before. Outshine the rest.', 3, 44, 200, 14),
(46, 'Dry Body Oil', '{\"PhotoMain\":\"https://i.upimg.com/n-fppyz-9\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/Mdqnlq7Zgs\"},{\"photo\":\"https://i.upimg.com/CiKvlpkbDK\"},{\"photo\":\"https://i.upimg.com/ortaGoWdc\"}]}', 'Instant moisture that achieves soft, silky results, Moroccanoil Body™ Dry Body Oil Fragrance Originale infuses skin with the antioxidant-rich, nourishing properties of argan oil rich in essential fatty acids, as well as olive and avocado oils. The weightless formula absorbs quickly to lock in moisture, while soothing dry areas and improving overall skin texture and tone. Delicately fragranced with the signature Moroccanoil scent, Fragrance Originale. Paraben-free.', 3, 48, 100, 14),
(47, 'Dry Texture Spray', '{\"PhotoMain\":\"https://i.upimg.com/CsKWrfCBr\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/yWDDrczcwe\"},{\"photo\":\"https://i.upimg.com/dniqPiGW8\"},{\"photo\":\"https://i.upimg.com/szqT1dYOb\"}]}', 'A dry argan-oil infused texture spray for effortless, undone styles with long-lasting hold. Use Moroccanoil® Dry Texture Spray as a finishing spray for styles with carefree, textured volume. Can also be used as a prep spray to provide foundational grip needed for no-slip braids and updos. A particle matrix of high-performance resins and zeolite form a bond between hairs for a texturized hold with a dry, gritty finish.', 3, 28, 50, 14),
(49, 'EVER.SMOOTH', '{\"PhotoMain\":\"https://i.upimg.com/PZTlqQtMf\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/G8dn_Q5qL\"},{\"photo\":\"https://i.upimg.com/2OoHd9-lq\"},{\"photo\":\"https://i.upimg.com/imcAyanENu\"}]}', 'Create the smoothest blowout EVER-y time with EVER.SMOOTH, our heat-activated style extender that started a BLOW.DRY revolution. Thanks to its remarkable smoothing technology featuring Long Chain Polymers and a Wood Bark Complex, EVER.SMOOTH cuts blow dry time and extends the life of your style. Activated by the heat of your blow dryer, this weightless spray creates the ultimate silky, smooth blowout with softness, volume and humidity resistance for a frizz-free finish.', 3, 29, 50, 15),
(50, 'YOUNG.AGAIN', '{\"PhotoMain\":\"https://i.upimg.com/FN-aTWwTQ\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/MRdLXbI1f\"},{\"photo\":\"https://i.upimg.com/0PyvzP5pR\"},{\"photo\":\"https://i.upimg.com/wbfM2XNncL\"}]}', 'Turn back time on ageing hair and feel YOUNG.AGAIN. This weightless leave-in treatment oil is the ultimate daily indulgence for damaged and ageing hair, formulated with anti-ageing Immortelle to deliver deep conditioning and shine-boosting benefits while protecting the hair against environmental stressors and heat damage.', 3, 35, 20, 15),
(51, 'STIMULATE-ME WASH', '{\"PhotoMain\":\"https://i.upimg.com/dgqcuuAlW8\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/PdUaTnI7PX\"},{\"photo\":\"https://i.upimg.com/ZMWDqIIKj\"},{\"photo\":\"https://i.upimg.com/rRLoeSa6W\"}]}', 'Your hair won’t be the only thing stimulated by this refreshing and invigorating shampoo…so will your senses. Bursting with a revitalising blend of Camphor Crystals, Bergamot and Black Pepper, STIMULATE-ME.WASH awakens and clarifies the hair and scalp while boosting strength for anyone with thinning, brittle or weak hair.', 3, 27, 50, 15),
(52, 'MAXI.WASH', '{\"PhotoMain\":\"https://i.upimg.com/HQFbg1PyAv\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/-nkQcEAbE\"},{\"photo\":\"https://i.upimg.com/jQENGyzdi\"},{\"photo\":\"https://i.upimg.com/_e7IBkcXhm\"}]}', 'Give hair a much-needed detox. Our detoxifying shampoo gently, yet effectively removes unwanted product and mineral build-up from the hair without stripping it of its natural oils. A soothing blend of Tea Tree, Thyme and Rosemary essential oils purify and restore balance for clean, clear and refreshed strands. It’s the ideal pre-wash or pre-colour treatment shampoo that prepares hair to receive MAXI benefits from any regimen.', 3, 24, 20, 15),
(53, 'NIGHT.RIDER', '{\"PhotoMain\":\"https://i.upimg.com/rXbHtd8i5\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/YDviLta3a\"},{\"photo\":\"https://i.upimg.com/I2BkJLgm1Y\"},{\"photo\":\"https://i.upimg.com/OoX0evWSwV\"}]}', 'Buckle up and hold onto your style with the strongest of our hardworking moulding pastes. NIGHT.RIDER delivers rough, matte texture and strong hold for short or choppy styles. Natural Beeswax moulds and sets the hair while sealing in moisture to prevent breakage. Work it quickly, as it starts setting upon contact, and get ready to take your hair on a ride that will last all night.', 3, 25, 50, 15),
(54, 'SESSION.SPRAY', '{\"PhotoMain\":\"https://i.upimg.com/hl1egR_FD\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/OVdSp_UPSs\"},{\"photo\":\"https://i.upimg.com/-SJt2iKHo\"},{\"photo\":\"https://i.upimg.com/JMBCdr7yjE\"}]}', 'Whether you’re in the salon, on set, or at home, SESSION.SPRAY is your secret weapon to make your finished look last. Our strong hold finishing spray features special moulding resins that provide firm, weightless hold plus excellent humidity resistance for a style that stays put under all conditions. Better yet, it’s enriched with natural oils that smell delightful and help protect the integrity of the hair. It brushes out with ease, leaving no trace of flakiness behind.', 3, 23, 50, 15),
(55, 'PLUMPING.RINSE', '{\"PhotoMain\":\"https://i.upimg.com/1JaOMPwIO\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/i6ThuzepF\"},{\"photo\":\"https://i.upimg.com/QQHMpjZBx\"},{\"photo\":\"https://i.upimg.com/ESQgnvxd0q\"}]}', 'Experience luxurious moisture packed with plumping benefits. Our PLUMPING.RINSE hydrates the hair with Shea Butter and conditioning agents while Rice Amino Acids help strengthen and densify every strand from root to tip. Thin, fine or ageing hair is transformed into thicker, fuller locks with incredible shine and silky soft texture.', 3, 21, 50, 15),
(56, 'Dewy glow jelly cream', '{\"PhotoMain\":\"https://imageshack.com/i/pod7uukAj\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/orAV0rUbf\"},{\"photo\":\"https://imagizer.imageshack.com/img922/7893/lzO11T.png\"},{\"photo\":\"https://i.upimg.com/orAV0rUbf\"},{\"photo\":\"https://i.upimg.com/F967yS_WjE\"}]}', 'Jeju Cherry Blossom helps boost skin radiance.\r\nInfused with Betaine, a moisturizing ingredient derived from sugar beets that creates a protective layer to prevent hydration loss.\r\nJelly texture absorbs instantly into skin without any sticky residue\r\n', 1, 24, 100, 2),
(57, 'Innisfree My real squeeze mask', '{\"PhotoMain\":\"https://i.upimg.com/U7uJQHrzB\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/ohsxGACYl\"},{\"photo\":\"https://i.upimg.com/6jUDJMj96\"},{\"photo\":\"https://i.upimg.com/3CSKaTnvW\"},{\"photo\":\"https://i.upimg.com/nOvtHcOcW\"}]}', 'My Real Squeeze Masks come in 3 levels of hydration:\r\n- Water base: Light & Fresh\r\n- Essence base: Deeply Hydrating\r\n- Cream base: Intensely Nourishing\r\nBiodegradable: Made from 100% eucalyptus fibers\r\n', 1, 1, 500, 2),
(58, 'Dewwy glow jam cleanser', '{\"PhotoMain\":\"https://i.upimg.com/OqXgjvI_28\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/d33SkUg2wN\"},{\"photo\":\"https://i.upimg.com/wayHTUYazh\"},{\"photo\":\"https://i.upimg.com/aL45tceNv\"}]}', 'Radiance-boosting Cherry Blossom Leaf Extract\r\nBeet-derived, hydrating Betaine\r\nMicellar cleansing complex provides deep and thorough cleanse\r\nSmells divinely of naturally derived Cherry Blossom scent!\r\n', 1, 13, 200, 2),
(59, 'Hydrating cleansing foam', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/8081/fdMPkp.jpg\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img923/5485/d0U5q9.jpg\"},{\"photo\":\"https://imagizer.imageshack.com/img924/6597/ZA7bHY.jpg\"}]}', 'Lather up this creamy foam infused with hydrating green tea grown on innisfree\'s USDA-certified organic (Control Union Certifications CUC) fields on Jeju Island, Korea for skin that feels clean, soft, and hydrated. A naturally-derived surfactant from green tea root gives this cleanser its rich, micro-fine bubbles.', 1, 10, 200, 2),
(60, 'Pore clearing facial foam', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/1001/XzU7Ql.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/7972/4LElo1.jpg\"},{\"photo\":\"https://imagizer.imageshack.com/img923/60/SXuOok.jpg\"}]}', 'Lather up this refreshing foam cleanser and instantly feel the micro-bubbles whisk away impurities. Our Jeju Volcanic Cluster are particles smaller than pores to help banish sebum for a clearer, less shiny complexion.', 1, 12, 300, 2),
(61, 'Shiseido Senka Perfect Whip Collagen in 120g', '{\"PhotoMain\":\"https://i.upimg.com/hi2PAYaxF\",\"PhotoList\":[{\"photo\":\"https://i.upimg.com/xmGy1JwDT\"},{\"photo\":\"https://i.upimg.com/y79We5XFo\"},{\"photo\":\"https://i.upimg.com/fsF4uUa4aj\"}]}', 'New addition to Shiseido\'s Perfect Whip line, now with collagen and double hyaluronic acid.\r\nDense, rich and creamy lather goes deep into pores and removes dirt effectively.\r\nContains Collagen and Double Hyaluronic Acid so your skin is left soft and smooth.\r\nCleanser foams up easily for easy and even distribution. Hyaluronic acid locks in moisture.\r\n', 1, 12, 200, 16),
(63, 'Neutrogena triple age repair moisturizer', '{\"PhotoMain\":\"https://i.upimg.com/gJlv4mL8i\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/853/D2Kjau.jpg\"},{\"photo\":\"https://imagizer.imageshack.com/img922/6567/doW38P.jpg\"}]}', 'Its unique formula contains powerful anti-wrinkle Hexinol technology to help boost skin\'s ability to improve its appearance, elasticity and firmness, as well as glycerin to deeply hydrate skin\r\nAnti-aging face & neck lotion contains vitamin C to gently help diffuse the look of dark spots while evening out skin tone to fight the signs of aging and improve overall radiance of skin\r\n', 1, 17, 100, 17),
(64, 'L’Oreal Paris Skincare Revitalift', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img923/5812/BuxwLn.jpg\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img922/60/9rkOhS.jpg\"},{\"photo\":\"https://imagizer.imageshack.com/img924/9263/wTtebz.jpg\"}]}', 'Moisturizer with Retinol: Formulated with 3 top recommended ingredients: Pro-Retinol, Hyaluronic Acid and Vitamin C; Pro Retinol reduces wrinkles and firms skin; Hyaluronic Acid hydrates and plumps skin; Vitamin C boosts radiance and evens tone\r\n', 1, 15, 100, 18),
(65, 'Shimmering Dry Oil • 125ml', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img922/6527/RsxxQy.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img922/2822/FYcrBG.png\"},{\"photo\":\"https://imagizer.imageshack.com/img922/2822/FYcrBG.png\"}]}', 'Made with 90% ingredients from natural origin, this Sephora Collection shimmering dry oil for the body contains marula oil and natural shimmering pigments. It nourishes and illuminates the skin with an irresistible golden glow, while enabling you to get dressed immediately after application.', 2, 28, 100, 19),
(66, 'Buff Ryder Exfoliating Body Scrub 170g', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/272/oiYUVQ.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/622/OrpN6h.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/622/OrpN6h.png\"}]}', 'This tropical-inspired skin treat buffs the rough and brings the smooth. A gentle, effective blend of exfoliants and fruit enzymes form this indulgent body scrub that refines, renews, and leaves skin silky and smooth. Rich shea butter and conditioning oils add a nourishing touch. Sugar, salt, and superfine sand form a gentle, but effective, exfoliating emulsion, while decadent oils deeply nourish and soften. Your skin is left feeling smooth, polished, and pampered—straight from the shower.', 2, 55, 100, 19),
(67, 'Blood Orange Hand Wash', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/4079/ugBPfP.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img922/3608/Giyt7u.png\"},{\"photo\":\"https://imagizer.imageshack.com/img922/1290/TdeV0M.png\"}]}', 'This fragrance has the zest of Lemon and Grapefruit balanced by sweet Jasmine. This beautifully uncomplicated fragrance is made with love to live in harmony with your home, providing a scented backdrop for whatever your day brings.', 2, 25, 50, 20),
(68, 'Squalane + Caffeine Toning Body Cream', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img924/1602/u3lYPM.jpg\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/6581/wykoEW.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/8172/e3hU92.jpg\"}]}', 'This clean body moisturiser extends the benefits of the best skincare ingredients caffeine and niacinamide to the entire body, enhanced by vegan sugarcane-derived squalane to enhance penetration. Caffeine sourced from green coffee beans gives skin a smoother appearance. Niacinamide improves skin texture and supports the moisture barrier. Sugarcane-derived squalane mimics skin’s natural lipids to instantly moisturise and soothe. Available in a fragrance-free formula or in a Soft Citrus scent with uplifting aromatherapeutic essential oils.', 2, 75, 50, 21),
(69, 'Ritual Bar Cleanser', '{\"PhotoMain\":\"https://imagizer.imageshack.com/img923/4967/IP1xkM.png\",\"PhotoList\":[{\"photo\":\"https://imagizer.imageshack.com/img924/8155/XBj7Tw.png\"},{\"photo\":\"https://imagizer.imageshack.com/img924/8155/XBj7Tw.png\"}]}', 'An invigorating green tea soap that energizes while washing away impurities and smoothing skin from head to toe. This nourishing face and body cleanser leaves skin looking smoother and calmer.', 2, 34, 50, 22);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `blog`
--
ALTER TABLE `blog`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `cthd`
--
ALTER TABLE `cthd`
  ADD UNIQUE KEY `ID` (`ID`),
  ADD KEY `fk_cthd_sp` (`SpID`),
  ADD KEY `MaHD` (`MaHD`);

--
-- Indexes for table `dangnhap`
--
ALTER TABLE `dangnhap`
  ADD PRIMARY KEY (`Username`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `danhgia`
--
ALTER TABLE `danhgia`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_rt_sp` (`SpID`),
  ADD KEY `sk_dguser` (`Username`);

--
-- Indexes for table `donhang`
--
ALTER TABLE `donhang`
  ADD PRIMARY KEY (`MaHD`),
  ADD UNIQUE KEY `NgayHD` (`NgayHD`);

--
-- Indexes for table `hoadon`
--
ALTER TABLE `hoadon`
  ADD PRIMARY KEY (`MaHD`),
  ADD KEY `hoadon_ibfk_1` (`Username`);

--
-- Indexes for table `loaisp`
--
ALTER TABLE `loaisp`
  ADD PRIMARY KEY (`MaLSP`);

--
-- Indexes for table `nhacc`
--
ALTER TABLE `nhacc`
  ADD PRIMARY KEY (`BrandID`);

--
-- Indexes for table `sanpham`
--
ALTER TABLE `sanpham`
  ADD PRIMARY KEY (`SpID`),
  ADD KEY `sp_ibfk_1` (`MaLSP`),
  ADD KEY `sp_ibfk_2` (`BrandID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `blog`
--
ALTER TABLE `blog`
  MODIFY `ID` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `cthd`
--
ALTER TABLE `cthd`
  MODIFY `ID` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=82;

--
-- AUTO_INCREMENT for table `danhgia`
--
ALTER TABLE `danhgia`
  MODIFY `ID` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `hoadon`
--
ALTER TABLE `hoadon`
  MODIFY `MaHD` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=149;

--
-- AUTO_INCREMENT for table `loaisp`
--
ALTER TABLE `loaisp`
  MODIFY `MaLSP` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `nhacc`
--
ALTER TABLE `nhacc`
  MODIFY `BrandID` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `sanpham`
--
ALTER TABLE `sanpham`
  MODIFY `SpID` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cthd`
--
ALTER TABLE `cthd`
  ADD CONSTRAINT `fk_cthd` FOREIGN KEY (`MaHD`) REFERENCES `hoadon` (`MaHD`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_cthd_sp` FOREIGN KEY (`SpID`) REFERENCES `sanpham` (`SpID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `danhgia`
--
ALTER TABLE `danhgia`
  ADD CONSTRAINT `fk_rt_sp` FOREIGN KEY (`SpID`) REFERENCES `sanpham` (`SpID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `sk_dguser` FOREIGN KEY (`Username`) REFERENCES `dangnhap` (`Username`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `donhang`
--
ALTER TABLE `donhang`
  ADD CONSTRAINT `fk_hddh` FOREIGN KEY (`MaHD`) REFERENCES `hoadon` (`MaHD`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `hoadon`
--
ALTER TABLE `hoadon`
  ADD CONSTRAINT `hoadon_ibfk_1` FOREIGN KEY (`Username`) REFERENCES `dangnhap` (`Username`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sanpham`
--
ALTER TABLE `sanpham`
  ADD CONSTRAINT `sp_ibfk_1` FOREIGN KEY (`MaLSP`) REFERENCES `loaisp` (`MaLSP`),
  ADD CONSTRAINT `sp_ibfk_2` FOREIGN KEY (`BrandID`) REFERENCES `nhacc` (`BrandID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
