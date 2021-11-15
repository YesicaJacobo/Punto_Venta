-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 15-11-2021 a las 01:26:07
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
(520, 'Canelitas', 15, 14.90, 'https://lagranbodega.vteximg.com.br/arquivos/ids/215407-600-600/7501030491644_1.jpg'),
(101, 'Cafe chico', 0, 22.00, NULL),
(102, 'Cafe mediano', 0, 28.00, NULL),
(103, 'Cafe grande', 0, 35.00, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `numero_de_empleado` int(11) NOT NULL,
  `nombre` varchar(51) DEFAULT NULL,
  `apellido1` varchar(51) DEFAULT NULL,
  `apellido2` varchar(51) DEFAULT NULL,
  `rol` int(254) NOT NULL,
  `pws` int(255) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`numero_de_empleado`, `nombre`, `apellido1`, `apellido2`, `rol`, `pws`) VALUES
(1, 'ANGEL NEYSER', 'VELASCO', 'ZEBADUA', 1, 12345),
(2, 'AARON URIEL', 'MACARENO', 'FLORES', 1, 12345),
(3, 'MARISOL', 'PEREZ', 'SANCHEZ', 1, 12345),
(4, 'COINTA', 'AMBROCIO', 'CRUZ', 1, 12345),
(5, 'JOAQUIN', 'VARGAS', 'CAMACHO', 1, 12345),
(6, 'ERIKA', 'VALLE', 'SANCHEZ', 1, 12345),
(7, 'MARLEN', 'CASTRO', 'LOPEZ', 1, 12345),
(8, 'JAVIER', 'MENDOZA', 'MEJIA', 1, 12345),
(9, 'SILVIA', 'GUZMAN', 'LOPEZ', 1, 12345),
(10, 'EDITH', 'RIOS', 'MARTINEZ', 1, 12345),
(11, 'Salma Judith', 'Iturbe', 'Grijalva', 2, 12345),
(12, 'Yesica Irasema', 'Jacobo', 'Viruel', 2, 12345),
(13, 'Denia Candelaria', 'Lomas', 'Armenta', 2, 12345),
(14, 'Jose Humberto', 'Abril', 'Garcia', 2, 12345);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `idventa` int(11) NOT NULL,
  `fechaventa` date NOT NULL,
  `horaventa` time NOT NULL,
  `operadorVenta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`idventa`, `fechaventa`, `horaventa`, `operadorVenta`) VALUES
(1, '2021-11-08', '18:02:32', 1),
(2, '2021-11-08', '18:05:32', 1),
(3, '2021-11-08', '18:06:32', 1),
(4, '2021-11-09', '18:09:32', 2),
(5, '2021-11-09', '18:11:32', 2),
(6, '2021-11-09', '18:13:32', 3),
(7, '2021-11-09', '18:02:32', 3),
(8, '2021-11-09', '18:09:58', 4),
(9, '2021-11-10', '12:10:26', 4),
(10, '2021-11-11', '10:49:19', 1),
(11, '2021-11-11', '13:41:52', 1),
(12, '2021-11-14', '14:10:53', 1),
(13, '2021-11-14', '16:35:51', 5),
(14, '2021-11-14', '16:44:55', 5),
(15, '2021-11-14', '16:59:07', 9),
(16, '2021-11-14', '17:10:56', 10),
(17, '2021-11-14', '17:19:05', 8);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_detalle`
--

CREATE TABLE `ventas_detalle` (
  `id_venta` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precio_producto` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ventas_detalle`
--

INSERT INTO `ventas_detalle` (`id_venta`, `id_producto`, `cantidad`, `precio_producto`) VALUES
(1, 502, 2, 18.9),
(1, 503, 1, 20.9),
(2, 506, 1, 17.9),
(3, 507, 1, 17.9),
(4, 502, 2, 18.9),
(4, 503, 1, 20.9),
(4, 506, 1, 17.9),
(4, 507, 1, 17.9),
(5, 507, 1, 17.9),
(5, 506, 1, 17.9),
(6, 506, 1, 17.9),
(6, 507, 1, 17.9),
(7, 506, 1, 17.9),
(8, 506, 1, 17.9),
(9, 505, 1, 17.9),
(9, 506, 1, 17.9),
(9, 507, 1, 17.9),
(10, 506, 1, 17.9),
(10, 502, 2, 18.9),
(10, 503, 1, 20.9),
(11, 506, 1, 17.9),
(11, 507, 1, 17.9),
(11, 103, 2, 35),
(12, 502, 1, 18.9),
(12, 102, 1, 28),
(12, 509, 1, 11.9),
(12, 101, 1, 22),
(12, 103, 1, 35),
(13, 509, 1, 11.9),
(13, 508, 1, 24.9),
(13, 511, 1, 12.9),
(13, 103, 1, 35),
(13, 102, 1, 28),
(14, 509, 1, 11.9),
(14, 501, 1, 17.9),
(15, 520, 2, 14.9),
(16, 509, 1, 11.9),
(17, 508, 1, 24.9),
(17, 509, 1, 11.9),
(17, 511, 2, 12.9),
(17, 516, 1, 14.9),
(17, 103, 1, 35),
(17, 514, 1, 14.9);

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
  ADD UNIQUE KEY `numero_de_empleado` (`numero_de_empleado`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD UNIQUE KEY `idventa` (`idventa`),
  ADD KEY `operadorVenta` (`operadorVenta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `idventa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
