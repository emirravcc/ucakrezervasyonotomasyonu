-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 07 Oca 2026, 15:16:47
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `ucakotomasyondb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `deneyimler`
--

CREATE TABLE `deneyimler` (
  `id` int(11) NOT NULL,
  `ad_soyad` varchar(255) NOT NULL,
  `eposta_adresi` varchar(255) NOT NULL,
  `telefon_numarasi` varchar(15) DEFAULT NULL,
  `sefer_numarasi` int(11) NOT NULL,
  `deneyim` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `deneyimler`
--

INSERT INTO `deneyimler` (`id`, `ad_soyad`, `eposta_adresi`, `telefon_numarasi`, `sefer_numarasi`, `deneyim`) VALUES
(2, 'ALİ BARAN DİNÇ', 'abd@gmail.com', '0 555 111 33 22', 7, 'deneme mesajı');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `koltuklar`
--

CREATE TABLE `koltuklar` (
  `id` int(11) NOT NULL,
  `sefer_id` int(11) NOT NULL,
  `koltuk_no` varchar(10) NOT NULL,
  `durum` tinyint(1) NOT NULL,
  `tip` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `koltuklar`
--

INSERT INTO `koltuklar` (`id`, `sefer_id`, `koltuk_no`, `durum`, `tip`) VALUES
(1, 4, 'A1', 0, 'Gidiş'),
(2, 4, 'A2', 0, 'Gidiş'),
(3, 4, 'A3', 0, 'Gidiş'),
(4, 4, 'A4', 0, 'Gidiş'),
(5, 4, 'A5', 0, 'Gidiş'),
(6, 4, 'A6', 0, 'Gidiş'),
(7, 4, 'A7', 0, 'Gidiş'),
(8, 4, 'A8', 0, 'Gidiş'),
(9, 4, 'B1', 0, 'Gidiş'),
(10, 4, 'B2', 0, 'Gidiş'),
(11, 4, 'B3', 0, 'Gidiş'),
(12, 4, 'B4', 0, 'Gidiş'),
(13, 4, 'B5', 0, 'Gidiş'),
(14, 4, 'B6', 0, 'Gidiş'),
(15, 4, 'B7', 0, 'Gidiş'),
(16, 4, 'B8', 0, 'Gidiş'),
(17, 4, 'C1', 0, 'Gidiş'),
(18, 4, 'C2', 0, 'Gidiş'),
(19, 4, 'C3', 0, 'Gidiş'),
(20, 4, 'C4', 0, 'Gidiş'),
(21, 4, 'C5', 0, 'Gidiş'),
(22, 4, 'C6', 0, 'Gidiş'),
(23, 4, 'C7', 0, 'Gidiş'),
(24, 4, 'C8', 0, 'Gidiş'),
(25, 4, 'D1', 0, 'Gidiş'),
(26, 4, 'D2', 0, 'Gidiş'),
(27, 4, 'D3', 0, 'Gidiş'),
(28, 4, 'D4', 0, 'Gidiş'),
(29, 4, 'D5', 0, 'Gidiş'),
(30, 4, 'D6', 0, 'Gidiş'),
(31, 4, 'D7', 0, 'Gidiş'),
(32, 4, 'D8', 0, 'Gidiş'),
(33, 4, 'E1', 0, 'Gidiş'),
(34, 4, 'E2', 0, 'Gidiş'),
(35, 4, 'E3', 0, 'Gidiş'),
(36, 4, 'E4', 0, 'Gidiş'),
(37, 4, 'E5', 0, 'Gidiş'),
(38, 4, 'E6', 0, 'Gidiş'),
(39, 4, 'E7', 0, 'Gidiş'),
(40, 4, 'E8', 0, 'Gidiş'),
(41, 4, 'F1', 0, 'Gidiş'),
(42, 4, 'F2', 0, 'Gidiş'),
(43, 4, 'F3', 0, 'Gidiş'),
(44, 4, 'F4', 0, 'Gidiş'),
(45, 4, 'F5', 0, 'Gidiş'),
(46, 4, 'F6', 0, 'Gidiş'),
(47, 4, 'F7', 0, 'Gidiş'),
(48, 4, 'F8', 0, 'Gidiş'),
(97, 6, 'A1', 0, 'Gidiş'),
(98, 6, 'A2', 0, 'Gidiş'),
(99, 6, 'A3', 0, 'Gidiş'),
(100, 6, 'A4', 0, 'Gidiş'),
(101, 6, 'A5', 0, 'Gidiş'),
(102, 6, 'A6', 0, 'Gidiş'),
(103, 6, 'A7', 0, 'Gidiş'),
(104, 6, 'A8', 0, 'Gidiş'),
(105, 6, 'B1', 0, 'Gidiş'),
(106, 6, 'B2', 0, 'Gidiş'),
(107, 6, 'B3', 0, 'Gidiş'),
(108, 6, 'B4', 0, 'Gidiş'),
(109, 6, 'B5', 0, 'Gidiş'),
(110, 6, 'B6', 0, 'Gidiş'),
(111, 6, 'B7', 0, 'Gidiş'),
(112, 6, 'B8', 0, 'Gidiş'),
(113, 6, 'C1', 0, 'Gidiş'),
(114, 6, 'C2', 0, 'Gidiş'),
(115, 6, 'C3', 0, 'Gidiş'),
(116, 6, 'C4', 0, 'Gidiş'),
(117, 6, 'C5', 0, 'Gidiş'),
(118, 6, 'C6', 0, 'Gidiş'),
(119, 6, 'C7', 0, 'Gidiş'),
(120, 6, 'C8', 0, 'Gidiş'),
(121, 6, 'D1', 0, 'Gidiş'),
(122, 6, 'D2', 0, 'Gidiş'),
(123, 6, 'D3', 0, 'Gidiş'),
(124, 6, 'D4', 0, 'Gidiş'),
(125, 6, 'D5', 0, 'Gidiş'),
(126, 6, 'D6', 0, 'Gidiş'),
(127, 6, 'D7', 0, 'Gidiş'),
(128, 6, 'D8', 0, 'Gidiş'),
(129, 6, 'E1', 0, 'Gidiş'),
(130, 6, 'E2', 0, 'Gidiş'),
(131, 6, 'E3', 0, 'Gidiş'),
(132, 6, 'E4', 0, 'Gidiş'),
(133, 6, 'E5', 0, 'Gidiş'),
(134, 6, 'E6', 0, 'Gidiş'),
(135, 6, 'E7', 0, 'Gidiş'),
(136, 6, 'E8', 0, 'Gidiş'),
(137, 6, 'F1', 0, 'Gidiş'),
(138, 6, 'F2', 0, 'Gidiş'),
(139, 6, 'F3', 0, 'Gidiş'),
(140, 6, 'F4', 0, 'Gidiş'),
(141, 6, 'F5', 0, 'Gidiş'),
(142, 6, 'F6', 0, 'Gidiş'),
(143, 6, 'F7', 0, 'Gidiş'),
(144, 6, 'F8', 0, 'Gidiş'),
(145, 7, 'A1', 0, 'Gidiş'),
(146, 7, 'A2', 0, 'Gidiş'),
(147, 7, 'A3', 0, 'Gidiş'),
(148, 7, 'A4', 0, 'Gidiş'),
(149, 7, 'A5', 0, 'Gidiş'),
(150, 7, 'A6', 0, 'Gidiş'),
(151, 7, 'A7', 0, 'Gidiş'),
(152, 7, 'A8', 0, 'Gidiş'),
(153, 7, 'B1', 0, 'Gidiş'),
(154, 7, 'B2', 0, 'Gidiş'),
(155, 7, 'B3', 0, 'Gidiş'),
(156, 7, 'B4', 0, 'Gidiş'),
(157, 7, 'B5', 0, 'Gidiş'),
(158, 7, 'B6', 0, 'Gidiş'),
(159, 7, 'B7', 0, 'Gidiş'),
(160, 7, 'B8', 0, 'Gidiş'),
(161, 7, 'C1', 0, 'Gidiş'),
(162, 7, 'C2', 0, 'Gidiş'),
(163, 7, 'C3', 0, 'Gidiş'),
(164, 7, 'C4', 0, 'Gidiş'),
(165, 7, 'C5', 0, 'Gidiş'),
(166, 7, 'C6', 0, 'Gidiş'),
(167, 7, 'C7', 0, 'Gidiş'),
(168, 7, 'C8', 0, 'Gidiş'),
(169, 7, 'D1', 0, 'Gidiş'),
(170, 7, 'D2', 0, 'Gidiş'),
(171, 7, 'D3', 0, 'Gidiş'),
(172, 7, 'D4', 0, 'Gidiş'),
(173, 7, 'D5', 0, 'Gidiş'),
(174, 7, 'D6', 0, 'Gidiş'),
(175, 7, 'D7', 0, 'Gidiş'),
(176, 7, 'D8', 0, 'Gidiş'),
(177, 7, 'E1', 0, 'Gidiş'),
(178, 7, 'E2', 0, 'Gidiş'),
(179, 7, 'E3', 0, 'Gidiş'),
(180, 7, 'E4', 0, 'Gidiş'),
(181, 7, 'E5', 0, 'Gidiş'),
(182, 7, 'E6', 0, 'Gidiş'),
(183, 7, 'E7', 0, 'Gidiş'),
(184, 7, 'E8', 0, 'Gidiş'),
(185, 7, 'F1', 0, 'Gidiş'),
(186, 7, 'F2', 0, 'Gidiş'),
(187, 7, 'F3', 0, 'Gidiş'),
(188, 7, 'F4', 0, 'Gidiş'),
(189, 7, 'F5', 0, 'Gidiş'),
(190, 7, 'F6', 0, 'Gidiş'),
(191, 7, 'F7', 0, 'Gidiş'),
(192, 7, 'F8', 0, 'Gidiş'),
(193, 8, 'A1', 0, 'Gidiş'),
(194, 8, 'A2', 0, 'Gidiş'),
(195, 8, 'A3', 0, 'Gidiş'),
(196, 8, 'A4', 0, 'Gidiş'),
(197, 8, 'A5', 0, 'Gidiş'),
(198, 8, 'A6', 0, 'Gidiş'),
(199, 8, 'A7', 0, 'Gidiş'),
(200, 8, 'A8', 0, 'Gidiş'),
(201, 8, 'B1', 0, 'Gidiş'),
(202, 8, 'B2', 0, 'Gidiş'),
(203, 8, 'B3', 0, 'Gidiş'),
(204, 8, 'B4', 0, 'Gidiş'),
(205, 8, 'B5', 0, 'Gidiş'),
(206, 8, 'B6', 0, 'Gidiş'),
(207, 8, 'B7', 0, 'Gidiş'),
(208, 8, 'B8', 0, 'Gidiş'),
(209, 8, 'C1', 0, 'Gidiş'),
(210, 8, 'C2', 0, 'Gidiş'),
(211, 8, 'C3', 0, 'Gidiş'),
(212, 8, 'C4', 0, 'Gidiş'),
(213, 8, 'C5', 0, 'Gidiş'),
(214, 8, 'C6', 0, 'Gidiş'),
(215, 8, 'C7', 0, 'Gidiş'),
(216, 8, 'C8', 0, 'Gidiş'),
(217, 8, 'D1', 0, 'Gidiş'),
(218, 8, 'D2', 0, 'Gidiş'),
(219, 8, 'D3', 0, 'Gidiş'),
(220, 8, 'D4', 0, 'Gidiş'),
(221, 8, 'D5', 0, 'Gidiş'),
(222, 8, 'D6', 0, 'Gidiş'),
(223, 8, 'D7', 0, 'Gidiş'),
(224, 8, 'D8', 0, 'Gidiş'),
(225, 8, 'E1', 0, 'Gidiş'),
(226, 8, 'E2', 0, 'Gidiş'),
(227, 8, 'E3', 0, 'Gidiş'),
(228, 8, 'E4', 0, 'Gidiş'),
(229, 8, 'E5', 0, 'Gidiş'),
(230, 8, 'E6', 0, 'Gidiş'),
(231, 8, 'E7', 0, 'Gidiş'),
(232, 8, 'E8', 0, 'Gidiş'),
(233, 8, 'F1', 0, 'Gidiş'),
(234, 8, 'F2', 0, 'Gidiş'),
(235, 8, 'F3', 0, 'Gidiş'),
(236, 8, 'F4', 0, 'Gidiş'),
(237, 8, 'F5', 0, 'Gidiş'),
(238, 8, 'F6', 0, 'Gidiş'),
(239, 8, 'F7', 0, 'Gidiş'),
(240, 8, 'F8', 0, 'Gidiş'),
(241, 9, 'A1', 1, 'Gidiş'),
(242, 9, 'A2', 0, 'Gidiş'),
(243, 9, 'A3', 0, 'Gidiş'),
(244, 9, 'A4', 0, 'Gidiş'),
(245, 9, 'A5', 0, 'Gidiş'),
(246, 9, 'A6', 0, 'Gidiş'),
(247, 9, 'A7', 0, 'Gidiş'),
(248, 9, 'A8', 0, 'Gidiş'),
(249, 9, 'B1', 1, 'Gidiş'),
(250, 9, 'B2', 0, 'Gidiş'),
(251, 9, 'B3', 1, 'Gidiş'),
(252, 9, 'B4', 0, 'Gidiş'),
(253, 9, 'B5', 0, 'Gidiş'),
(254, 9, 'B6', 0, 'Gidiş'),
(255, 9, 'B7', 0, 'Gidiş'),
(256, 9, 'B8', 0, 'Gidiş'),
(257, 9, 'C1', 0, 'Gidiş'),
(258, 9, 'C2', 1, 'Gidiş'),
(259, 9, 'C3', 0, 'Gidiş'),
(260, 9, 'C4', 1, 'Gidiş'),
(261, 9, 'C5', 0, 'Gidiş'),
(262, 9, 'C6', 0, 'Gidiş'),
(263, 9, 'C7', 0, 'Gidiş'),
(264, 9, 'C8', 0, 'Gidiş'),
(265, 9, 'D1', 1, 'Gidiş'),
(266, 9, 'D2', 0, 'Gidiş'),
(267, 9, 'D3', 0, 'Gidiş'),
(268, 9, 'D4', 0, 'Gidiş'),
(269, 9, 'D5', 0, 'Gidiş'),
(270, 9, 'D6', 0, 'Gidiş'),
(271, 9, 'D7', 0, 'Gidiş'),
(272, 9, 'D8', 0, 'Gidiş'),
(273, 9, 'E1', 0, 'Gidiş'),
(274, 9, 'E2', 0, 'Gidiş'),
(275, 9, 'E3', 1, 'Gidiş'),
(276, 9, 'E4', 0, 'Gidiş'),
(277, 9, 'E5', 0, 'Gidiş'),
(278, 9, 'E6', 0, 'Gidiş'),
(279, 9, 'E7', 0, 'Gidiş'),
(280, 9, 'E8', 0, 'Gidiş'),
(281, 9, 'F1', 1, 'Gidiş'),
(282, 9, 'F2', 0, 'Gidiş'),
(283, 9, 'F3', 0, 'Gidiş'),
(284, 9, 'F4', 0, 'Gidiş'),
(285, 9, 'F5', 0, 'Gidiş'),
(286, 9, 'F6', 0, 'Gidiş'),
(287, 9, 'F7', 0, 'Gidiş'),
(288, 9, 'F8', 1, 'Gidiş'),
(289, 10, 'A1', 0, 'Gidiş'),
(290, 10, 'A2', 0, 'Gidiş'),
(291, 10, 'A3', 0, 'Gidiş'),
(292, 10, 'A4', 0, 'Gidiş'),
(293, 10, 'A5', 0, 'Gidiş'),
(294, 10, 'A6', 0, 'Gidiş'),
(295, 10, 'A7', 0, 'Gidiş'),
(296, 10, 'A8', 0, 'Gidiş'),
(297, 10, 'B1', 0, 'Gidiş'),
(298, 10, 'B2', 1, 'Gidiş'),
(299, 10, 'B3', 1, 'Gidiş'),
(300, 10, 'B4', 0, 'Gidiş'),
(301, 10, 'B5', 0, 'Gidiş'),
(302, 10, 'B6', 0, 'Gidiş'),
(303, 10, 'B7', 0, 'Gidiş'),
(304, 10, 'B8', 0, 'Gidiş'),
(305, 10, 'C1', 1, 'Gidiş'),
(306, 10, 'C2', 0, 'Gidiş'),
(307, 10, 'C3', 0, 'Gidiş'),
(308, 10, 'C4', 0, 'Gidiş'),
(309, 10, 'C5', 0, 'Gidiş'),
(310, 10, 'C6', 0, 'Gidiş'),
(311, 10, 'C7', 0, 'Gidiş'),
(312, 10, 'C8', 0, 'Gidiş'),
(313, 10, 'D1', 0, 'Gidiş'),
(314, 10, 'D2', 0, 'Gidiş'),
(315, 10, 'D3', 0, 'Gidiş'),
(316, 10, 'D4', 0, 'Gidiş'),
(317, 10, 'D5', 0, 'Gidiş'),
(318, 10, 'D6', 0, 'Gidiş'),
(319, 10, 'D7', 0, 'Gidiş'),
(320, 10, 'D8', 0, 'Gidiş'),
(321, 10, 'E1', 0, 'Gidiş'),
(322, 10, 'E2', 0, 'Gidiş'),
(323, 10, 'E3', 0, 'Gidiş'),
(324, 10, 'E4', 0, 'Gidiş'),
(325, 10, 'E5', 0, 'Gidiş'),
(326, 10, 'E6', 0, 'Gidiş'),
(327, 10, 'E7', 0, 'Gidiş'),
(328, 10, 'E8', 0, 'Gidiş'),
(329, 10, 'F1', 0, 'Gidiş'),
(330, 10, 'F2', 0, 'Gidiş'),
(331, 10, 'F3', 0, 'Gidiş'),
(332, 10, 'F4', 0, 'Gidiş'),
(333, 10, 'F5', 0, 'Gidiş'),
(334, 10, 'F6', 0, 'Gidiş'),
(335, 10, 'F7', 0, 'Gidiş'),
(336, 10, 'F8', 0, 'Gidiş'),
(337, 11, 'A1', 0, 'Gidiş'),
(338, 11, 'A1', 0, 'Dönüş'),
(339, 11, 'A2', 0, 'Gidiş'),
(340, 11, 'A2', 0, 'Dönüş'),
(341, 11, 'A3', 0, 'Gidiş'),
(342, 11, 'A3', 0, 'Dönüş'),
(343, 11, 'A4', 0, 'Gidiş'),
(344, 11, 'A4', 0, 'Dönüş'),
(345, 11, 'A5', 0, 'Gidiş'),
(346, 11, 'A5', 0, 'Dönüş'),
(347, 11, 'A6', 0, 'Gidiş'),
(348, 11, 'A6', 0, 'Dönüş'),
(349, 11, 'A7', 0, 'Gidiş'),
(350, 11, 'A7', 0, 'Dönüş'),
(351, 11, 'A8', 0, 'Gidiş'),
(352, 11, 'A8', 0, 'Dönüş'),
(353, 11, 'B1', 0, 'Gidiş'),
(354, 11, 'B1', 0, 'Dönüş'),
(355, 11, 'B2', 0, 'Gidiş'),
(356, 11, 'B2', 0, 'Dönüş'),
(357, 11, 'B3', 0, 'Gidiş'),
(358, 11, 'B3', 0, 'Dönüş'),
(359, 11, 'B4', 0, 'Gidiş'),
(360, 11, 'B4', 0, 'Dönüş'),
(361, 11, 'B5', 0, 'Gidiş'),
(362, 11, 'B5', 0, 'Dönüş'),
(363, 11, 'B6', 0, 'Gidiş'),
(364, 11, 'B6', 0, 'Dönüş'),
(365, 11, 'B7', 0, 'Gidiş'),
(366, 11, 'B7', 0, 'Dönüş'),
(367, 11, 'B8', 0, 'Gidiş'),
(368, 11, 'B8', 0, 'Dönüş'),
(369, 11, 'C1', 0, 'Gidiş'),
(370, 11, 'C1', 0, 'Dönüş'),
(371, 11, 'C2', 0, 'Gidiş'),
(372, 11, 'C2', 0, 'Dönüş'),
(373, 11, 'C3', 0, 'Gidiş'),
(374, 11, 'C3', 0, 'Dönüş'),
(375, 11, 'C4', 0, 'Gidiş'),
(376, 11, 'C4', 0, 'Dönüş'),
(377, 11, 'C5', 0, 'Gidiş'),
(378, 11, 'C5', 0, 'Dönüş'),
(379, 11, 'C6', 0, 'Gidiş'),
(380, 11, 'C6', 0, 'Dönüş'),
(381, 11, 'C7', 0, 'Gidiş'),
(382, 11, 'C7', 0, 'Dönüş'),
(383, 11, 'C8', 0, 'Gidiş'),
(384, 11, 'C8', 0, 'Dönüş'),
(385, 11, 'D1', 0, 'Gidiş'),
(386, 11, 'D1', 0, 'Dönüş'),
(387, 11, 'D2', 0, 'Gidiş'),
(388, 11, 'D2', 0, 'Dönüş'),
(389, 11, 'D3', 0, 'Gidiş'),
(390, 11, 'D3', 0, 'Dönüş'),
(391, 11, 'D4', 0, 'Gidiş'),
(392, 11, 'D4', 0, 'Dönüş'),
(393, 11, 'D5', 0, 'Gidiş'),
(394, 11, 'D5', 0, 'Dönüş'),
(395, 11, 'D6', 0, 'Gidiş'),
(396, 11, 'D6', 0, 'Dönüş'),
(397, 11, 'D7', 0, 'Gidiş'),
(398, 11, 'D7', 0, 'Dönüş'),
(399, 11, 'D8', 0, 'Gidiş'),
(400, 11, 'D8', 0, 'Dönüş'),
(401, 11, 'E1', 0, 'Gidiş'),
(402, 11, 'E1', 0, 'Dönüş'),
(403, 11, 'E2', 0, 'Gidiş'),
(404, 11, 'E2', 0, 'Dönüş'),
(405, 11, 'E3', 0, 'Gidiş'),
(406, 11, 'E3', 0, 'Dönüş'),
(407, 11, 'E4', 0, 'Gidiş'),
(408, 11, 'E4', 0, 'Dönüş'),
(409, 11, 'E5', 0, 'Gidiş'),
(410, 11, 'E5', 0, 'Dönüş'),
(411, 11, 'E6', 0, 'Gidiş'),
(412, 11, 'E6', 0, 'Dönüş'),
(413, 11, 'E7', 0, 'Gidiş'),
(414, 11, 'E7', 0, 'Dönüş'),
(415, 11, 'E8', 0, 'Gidiş'),
(416, 11, 'E8', 0, 'Dönüş'),
(417, 11, 'F1', 0, 'Gidiş'),
(418, 11, 'F1', 0, 'Dönüş'),
(419, 11, 'F2', 0, 'Gidiş'),
(420, 11, 'F2', 0, 'Dönüş'),
(421, 11, 'F3', 0, 'Gidiş'),
(422, 11, 'F3', 0, 'Dönüş'),
(423, 11, 'F4', 0, 'Gidiş'),
(424, 11, 'F4', 0, 'Dönüş'),
(425, 11, 'F5', 0, 'Gidiş'),
(426, 11, 'F5', 0, 'Dönüş'),
(427, 11, 'F6', 0, 'Gidiş'),
(428, 11, 'F6', 0, 'Dönüş'),
(429, 11, 'F7', 0, 'Gidiş'),
(430, 11, 'F7', 0, 'Dönüş'),
(431, 11, 'F8', 0, 'Gidiş'),
(432, 11, 'F8', 0, 'Dönüş');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanıcılar`
--

CREATE TABLE `kullanıcılar` (
  `id` int(11) NOT NULL,
  `kullanıcıAdı` text DEFAULT NULL,
  `epostaAdresi` text DEFAULT NULL,
  `parola` text DEFAULT NULL,
  `tc` text DEFAULT NULL,
  `isim` text DEFAULT NULL,
  `soyAd` text DEFAULT NULL,
  `cinsiyet` text DEFAULT NULL,
  `telefon` text DEFAULT NULL,
  `doğumTarihi` datetime DEFAULT NULL,
  `admin` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `kullanıcılar`
--

INSERT INTO `kullanıcılar` (`id`, `kullanıcıAdı`, `epostaAdresi`, `parola`, `tc`, `isim`, `soyAd`, `cinsiyet`, `telefon`, `doğumTarihi`, `admin`) VALUES
(1, 'admin', 'admin@gmail.com', 'admin', '11111111111', 'Ali', 'Erkek', 'Erkek', '05056336031', '2000-01-19 16:31:02', 'true'),
(3, 'emiravci', 'emiravci@gmail.com', 'emiravci', '10042020100', 'Emir', 'Avcı', 'Erkek', '0 530 627 85 49', '2006-08-03 00:00:00', 'false'),
(5, 'abd', 'alibaran@gmail.com', 'abd', '12345678900', 'Ali Baran', 'Dinç', 'Erkek', '0 505 111 22 33', '2025-01-02 00:00:00', 'false');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `seferler`
--

CREATE TABLE `seferler` (
  `id` int(11) NOT NULL,
  `nereden` text DEFAULT NULL,
  `nereye` text DEFAULT NULL,
  `seferTipi` text DEFAULT NULL,
  `tarihGidiş` datetime DEFAULT NULL,
  `tarihDönüş` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `seferler`
--

INSERT INTO `seferler` (`id`, `nereden`, `nereye`, `seferTipi`, `tarihGidiş`, `tarihDönüş`) VALUES
(3, 'İstanbul', 'Ankara', 'Gidiş', '2024-12-17 23:45:39', NULL),
(4, 'Ağrı', 'Amasya', 'Gidiş', '2025-01-10 00:00:00', '0001-01-01 00:00:00'),
(6, 'Adana', 'Adıyaman', 'Gidiş', '2025-01-04 00:00:00', '0001-01-01 00:00:00'),
(7, 'Adıyaman', 'Afyonkarahisar', 'Gidiş', '2025-01-05 00:00:00', '0001-01-01 00:00:00'),
(8, 'Amasya', 'Ankara', 'Gidiş', '2025-01-03 16:00:00', '0001-01-01 00:00:00'),
(9, 'Adıyaman', 'Ankara', 'Gidiş', '2025-01-25 00:00:00', NULL),
(10, 'Gaziantep', 'İstanbul', 'Gidiş', '2025-01-14 00:00:00', NULL),
(11, 'Gaziantep', 'İstanbul', 'Gidiş-Dönüş', '2025-01-14 00:00:00', '2025-01-15 00:00:00');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ödemeler`
--

CREATE TABLE `ödemeler` (
  `ödeme_id` int(11) NOT NULL,
  `sefer_id` int(11) NOT NULL,
  `koltuk_no` varchar(10) NOT NULL,
  `ödeme_tutarı` decimal(10,2) NOT NULL,
  `ödeme_tarihi` datetime DEFAULT current_timestamp(),
  `müşteri_id` int(11) NOT NULL,
  `ödeme_durumu` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `ödemeler`
--

INSERT INTO `ödemeler` (`ödeme_id`, `sefer_id`, `koltuk_no`, `ödeme_tutarı`, `ödeme_tarihi`, `müşteri_id`, `ödeme_durumu`) VALUES
(1, 9, 'B3', 3100.00, '2025-01-03 15:18:11', 1, 1),
(2, 9, 'C2', 4850.00, '2025-01-03 15:41:12', 1, 1),
(3, 9, 'D1', 3100.00, '2025-01-04 12:44:35', 1, 1),
(4, 9, 'F8', 4850.00, '2025-01-04 12:49:31', 1, 1),
(5, 9, 'F1', 3100.00, '2025-01-04 13:05:48', 1, 1),
(6, 9, 'E3', 3100.00, '2025-01-06 16:13:29', 1, 1),
(7, 10, 'B2', 3100.00, '2025-01-13 14:14:31', 5, 1),
(8, 10, 'C1', 4850.00, '2025-01-13 14:14:43', 5, 1),
(9, 10, 'B3', 3100.00, '2025-01-13 14:41:57', 1, 1);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `deneyimler`
--
ALTER TABLE `deneyimler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `koltuklar`
--
ALTER TABLE `koltuklar`
  ADD PRIMARY KEY (`id`),
  ADD KEY `sefer_id` (`sefer_id`);

--
-- Tablo için indeksler `kullanıcılar`
--
ALTER TABLE `kullanıcılar`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `seferler`
--
ALTER TABLE `seferler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `ödemeler`
--
ALTER TABLE `ödemeler`
  ADD PRIMARY KEY (`ödeme_id`),
  ADD KEY `sefer_id` (`sefer_id`),
  ADD KEY `müşteri_id` (`müşteri_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `deneyimler`
--
ALTER TABLE `deneyimler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `koltuklar`
--
ALTER TABLE `koltuklar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=433;

--
-- Tablo için AUTO_INCREMENT değeri `kullanıcılar`
--
ALTER TABLE `kullanıcılar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `seferler`
--
ALTER TABLE `seferler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Tablo için AUTO_INCREMENT değeri `ödemeler`
--
ALTER TABLE `ödemeler`
  MODIFY `ödeme_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `koltuklar`
--
ALTER TABLE `koltuklar`
  ADD CONSTRAINT `koltuklar_ibfk_1` FOREIGN KEY (`sefer_id`) REFERENCES `seferler` (`id`);

--
-- Tablo kısıtlamaları `ödemeler`
--
ALTER TABLE `ödemeler`
  ADD CONSTRAINT `ödemeler_ibfk_1` FOREIGN KEY (`sefer_id`) REFERENCES `seferler` (`id`),
  ADD CONSTRAINT `ödemeler_ibfk_2` FOREIGN KEY (`müşteri_id`) REFERENCES `kullanıcılar` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
