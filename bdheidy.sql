-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-04-2024 a las 03:20:25
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdheidy`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentabancaria`
--

CREATE TABLE `cuentabancaria` (
  `id_cuen` int(11) NOT NULL,
  `id_per` int(11) DEFAULT NULL,
  `numero_cuenta` varchar(20) DEFAULT NULL,
  `saldo` decimal(10,2) DEFAULT NULL,
  `tipo_cuenta` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cuentabancaria`
--

INSERT INTO `cuentabancaria` (`id_cuen`, `id_per`, `numero_cuenta`, `saldo`, `tipo_cuenta`) VALUES
(1, 1, '1234567890', 1500.00, 'Ahorro'),
(2, 2, '9876543210', 2500.00, 'Corriente'),
(3, 3, '5678901234', 500.00, 'Cheques'),
(4, 1, '00000', 0.00, 'cheque'),
(6, 1, '999999', 100.00, NULL),
(7, 1, '999999', 100.00, NULL),
(9, 1, '5555', 3333.00, NULL),
(12, 1, '5555', 33331.00, NULL),
(13, 2, '00000', 123333.00, NULL),
(14, 2, '00000', 99999999.99, 'corriente'),
(18, 16, '12345678', 90.00, 'ahorro'),
(19, 1, '5555', 33331.00, 'ahorro'),
(20, 1, '5555', 33331.00, 'ahorro'),
(21, 1, '5555', 33331.00, 'ahorro'),
(22, 1, '5555', 3333.00, 'corriente'),
(23, 16, '12345678', 1230.00, 'ahorro'),
(24, 16, '12345678', 1230.00, 'cheques');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE `persona` (
  `id_per` int(11) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `edad` int(11) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`id_per`, `nombre`, `apellido`, `edad`, `direccion`) VALUES
(1, 'Juan', 'García', 30, 'Calle Principal 123'),
(2, 'María', 'Martínez', 25, 'Avenida Central 456'),
(3, 'Pedro', 'López', 40, 'Plaza Mayor 789'),
(6, 'Nicole ', 'calisaya', 22, 'san pedro'),
(7, 'Nicole ', 'calisaya', 22, 'san pedro'),
(15, 'maria', 'calisaya', 32, 'alberto gutierrez'),
(16, 'leo', 'iriarte', 45, 'sopocachi');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transaccionesbancarias`
--

CREATE TABLE `transaccionesbancarias` (
  `id_transac` int(11) NOT NULL,
  `id_cuen` int(11) DEFAULT NULL,
  `tipo_transaccion` varchar(10) DEFAULT NULL,
  `monto` decimal(10,2) DEFAULT NULL,
  `fecha_transaccion` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `transaccionesbancarias`
--

INSERT INTO `transaccionesbancarias` (`id_transac`, `id_cuen`, `tipo_transaccion`, `monto`, `fecha_transaccion`) VALUES
(1, 1, 'Depósito', 500.00, '2024-04-15'),
(2, 2, 'Depósito', 1000.00, '2024-04-16'),
(3, 3, 'Retiro', 200.00, '2024-04-17');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cuentabancaria`
--
ALTER TABLE `cuentabancaria`
  ADD PRIMARY KEY (`id_cuen`),
  ADD KEY `id_per` (`id_per`);

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`id_per`);

--
-- Indices de la tabla `transaccionesbancarias`
--
ALTER TABLE `transaccionesbancarias`
  ADD PRIMARY KEY (`id_transac`),
  ADD KEY `id_cuen` (`id_cuen`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cuentabancaria`
--
ALTER TABLE `cuentabancaria`
  MODIFY `id_cuen` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de la tabla `persona`
--
ALTER TABLE `persona`
  MODIFY `id_per` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de la tabla `transaccionesbancarias`
--
ALTER TABLE `transaccionesbancarias`
  MODIFY `id_transac` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cuentabancaria`
--
ALTER TABLE `cuentabancaria`
  ADD CONSTRAINT `cuentabancaria_ibfk_1` FOREIGN KEY (`id_per`) REFERENCES `persona` (`id_per`);

--
-- Filtros para la tabla `transaccionesbancarias`
--
ALTER TABLE `transaccionesbancarias`
  ADD CONSTRAINT `transaccionesbancarias_ibfk_1` FOREIGN KEY (`id_cuen`) REFERENCES `cuentabancaria` (`id_cuen`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
