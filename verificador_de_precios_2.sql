-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-09-2021 a las 21:33:45
-- Versión del servidor: 10.4.20-MariaDB
-- Versión de PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `verificador_de_precios_2`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `producto_codigo` bigint(13) UNSIGNED NOT NULL,
  `producto_nombre` varchar(255) NOT NULL,
  `producto_cantidad` smallint(9) UNSIGNED NOT NULL,
  `producto_precio` double(10,2) UNSIGNED NOT NULL,
  `producto_imagen` varchar(255) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`producto_codigo`, `producto_nombre`, `producto_cantidad`, `producto_precio`, `producto_imagen`) VALUES
(501, 'Coca-cola', 20, 17.90, 'https://m.media-amazon.com/images/I/5156FefjlqL._SX425_.jpg'),
(502, 'Takis Fuego', 14, 18.90, 'https://www.barcel.com.mx/sites/default/files/takis_fuego.png'),
(503, 'Dr Pepper', 12, 20.90, 'https://munchiezonline.co.za/wp-content/uploads/2021/07/Dr-Pepper.png'),
(504, 'Cheetos', 14, 14.90, 'https://modeloramanow.vtexassets.com/arquivos/ids/155400/4.png'),
(505, 'Chips', 15, 17.90, 'https://www.barcel.com.mx/sites/default/files/chips-jalapeno-v2.png'),
(506, 'Doritos', 12, 17.90, 'https://www.doritos.com/sites/doritos.com/files/2018-08/new-nacho-cheese.png'),
(507, 'Tostitos', 14, 17.90, 'https://cdn.shopify.com/s/files/1/0394/1027/0253/products/976486541-1585078504935_600x600.png'),
(508, 'Paketaxo', 15, 24.90, 'https://paketaxo.com.mx/images/home/paketaxo_quexo.png'),
(509, 'Maruchan', 22, 11.90, 'https://maruchan.com.mx/web/wp-content/uploads/2020/11/camaronlimonhabanero.png'),
(510, '7UP', 18, 14.90, 'https://www.100centena.com/pub/media/catalog/product/cache/07a142c8a19d573ee4b03489790d6e90/n/d/ndzmytmzmg-1000x1000.png'),
(511, 'Gansito', 14, 12.90, 'https://i0.wp.com/www.casagamovi.cl/wp-content/uploads/2020/07/gansiro-marinela.png'),
(512, 'Principe', 12, 13.90, 'https://marinelausa.com/sites/default/files/BBUSA_Principe_84g_RND-third.png'),
(513, 'Polvorones', 12, 13.90, 'https://s.cornershopapp.com/product-images/383117.png'),
(514, 'Barritas', 11, 14.90, 'https://res.cloudinary.com/walmart-labs/image/upload/w_960,dpr_auto,f_auto,q_auto:best/gr/images/product-images/img_large/00750100013305L.jpg'),
(515, 'Cremax', 17, 26.90, 'https://lapatroncita.mx/wp-content/uploads/2020/04/cremax_niefve_fresa.jpg'),
(516, 'Oreo', 14, 14.90, 'https://freshmarketbqto.com/wp-content/uploads/2021/03/PQmKjR5x-n-removebg-preview.png'),
(517, 'Emperador', 11, 13.90, 'https://gamesa.com.mx/recetas/storage/app/uploads/public/5ff/61c/24b/5ff61c24b2995763435832.png'),
(518, 'Polvorones', 14, 13.90, 'https://s.cornershopapp.com/product-images/383117.png'),
(519, 'Arcoiris', 15, 14.90, 'https://cdn.shopify.com/s/files/1/0706/6309/products/work235676_1142x.jpg'),
(520, 'Canelitas', 15, 14.90, 'https://lagranbodega.vteximg.com.br/arquivos/ids/215407-600-600/7501030491644_1.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `numero_de_empleado` int(11) NOT NULL,
  `nombre` varchar(51) DEFAULT NULL,
  `apellido1` varchar(51) DEFAULT NULL,
  `apellido2` varchar(51) DEFAULT NULL,
  `celular` bigint(12) DEFAULT NULL,
  `curp` varchar(24) NOT NULL,
  `rfc` varchar(20) NOT NULL,
  `nss` varchar(11) NOT NULL,
  `correo` varchar(254) NOT NULL,
  `direccion` varchar(254) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`numero_de_empleado`, `nombre`, `apellido1`, `apellido2`, `celular`, `curp`, `rfc`, `nss`, `correo`, `direccion`) VALUES
(1, 'ANGEL NEYSER', 'VELASCO', 'ZEBADUA', 6622678079, 'VEZA761001HCSLBN01', 'VEZA7610012Z7', '605-94-7096', 'tbenyoussef00m@btcmod.com', 'INDUSTRIAS NO. 3715 NO. B, ZONA INDUSTRIAL, 78395'),
(2, 'AARON URIEL', 'MACARENO', 'FLORES', 6625225874, 'MAFA670701HPLCLR01', 'MAFA670701ERA', '150-79-1916', 'rmunteanu.dumitr1@jomcs.com', 'ALLENDE NO. 163 S/N, COLIMA CENTRO, 28000'),
(3, 'MARISOL', 'PEREZ', 'SANCHEZ', 6625889857, 'PESM880113MQTRNR05', 'PESM880113111', '290-67-4317', 'bzadjali98t@manm.site', 'JUAREZ NO. 45 LOC NO. 16, PLAZA PAPAGAYO, 77720'),
(4, 'COINTA', 'AMBROCIO', 'CRUZ', 6571851367, 'AOCC620208MVZMRN02', 'AOCC620208QV5', '568-33-6511', 'wmohamed.elalamy@cxmyal.com', 'FILOMENO MEDINA NO 83, CENTRO, 28000'),
(5, 'JOAQUIN', 'VARGAS', 'CAMACHO', 6627493383, 'VACJ810831HCMRMQ04', 'VACJ8108315L5', '525-07-6833', 'cmanoeljoj@codm.community', 'VENUSTIANO CARRANZA NO. 2002 NO. A, CENTRO, 31000'),
(6, 'ERIKA', 'VALLE', 'SANCHEZ', 6626921535, 'VASE830711MDFLNR05', 'VASE830711MD9', '568-60-0781', 'wandre0005m@readx.site', 'SUCRE NO. 188 S/N, MODERNA, 03510'),
(7, 'MARLEN', 'CASTRO', 'LOPEZ', 6625090290, 'CALM871222MBCSPR05', 'CALM8712229ZA', '250-47-6226', '0torolokoramacht@googleappsmail.com', 'AV 14 PTE NO. 520, CIUDAD DELICIAS CENTRO, 33000'),
(8, 'JAVIER', 'MENDOZA', 'MEJIA', 6628217977, 'MEMJ660806HHGNJV07', 'MEMJ660806368', '966-97-8039', '3omar.awawdeh97z@tubidu.com', 'BLOCK NO. 2 NO. BODEGA 6, CENTRAL DE ABASTOS, 58218'),
(9, 'SILVIA', 'GUZMAN', 'LOPEZ', 6625191961, 'GULS750117MDFZPL03', 'GULS750117PY6', '166-03-1582', 'tgreen-20113@tapiitudulu.com', 'CALLE 14 94 A, BUENAVISTA, 87350'),
(10, 'EDITH', 'RIOS', 'MARTINEZ', 6629360292, 'RIME740706MOCSRD08', 'RIME7407061W7', '860-77-2905', 'akidilanakarshv@azwo.site', 'BUENAVENTURA MERLIN 601, SAN BERNARDINO, 50080'),
(11, 'LILIANA JESSICA', 'ABARCA', 'BARRIOS', 6627936465, 'AABL760811MMSBRL02', 'AABL7608112JA', '445-05-1443', '2shaurya.kapoor.k@ponili.cf', 'INDEPENDENCIA NO. 5806, HIDALGO, 88160'),
(12, 'FERNANDO', 'MENDIOLA', 'ULLOA', 6623616189, 'MEUF830915HDFNLR00', 'MEUF830915GI6', '948-28-4064', 'mking.ahmad.921r@litg.site', 'ARENAL NO. 6, PUEBLO DE LA MAGDALENA PETLACALCO'),
(13, 'CONCEPCION', 'RAMIREZ', 'SAN MARTIN', 6620728907, 'RASC800802MPLMNN09', 'RASC800802CR1', '609-25-9106', '0lindirbw@docf.site', 'BLVD FCO I MADERO 137 OTE ALTO, CENTRO, 80000'),
(14, 'AREMY SARAI', 'CUPUL', 'CAUICH', 6623828346, 'CUCA930506MQRPCR06', 'CUCA930506', '662-17-4196', '8jizette_0809900@refee.site', 'Carr. Juárez Porvenir y Camino Escudero, Cp.32530'),
(15, 'MARCELINO', 'ZAZUETA', 'NAVARRETE', 6627517763, 'ZANM741029HSRZVR02', 'ZANM7410291T4', '421-25-7247', 'chamz@kitchentvs.ru', '5 DE MAYO NO. 322 NO. A, AGUASCALIENTES CENTRO, 20000');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD UNIQUE KEY `producto_codigo` (`producto_codigo`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`numero_de_empleado`),
  ADD UNIQUE KEY `numero_de_empleado` (`numero_de_empleado`),
  ADD UNIQUE KEY `curp` (`curp`),
  ADD UNIQUE KEY `rfc` (`rfc`),
  ADD UNIQUE KEY `nss` (`nss`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
