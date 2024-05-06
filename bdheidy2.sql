-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-05-2024 a las 00:38:06
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
-- Base de datos: `bdheidy2`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentabancarias`
--

CREATE TABLE `cuentabancarias` (
  `cuentabancaria_id` int(11) NOT NULL,
  `numero_cuenta` varchar(100) NOT NULL,
  `saldo` int(11) NOT NULL,
  `persona_id` int(11) DEFAULT NULL,
  `tipo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cuentabancarias`
--

INSERT INTO `cuentabancarias` (`cuentabancaria_id`, `numero_cuenta`, `saldo`, `persona_id`, `tipo`) VALUES
(38, '1111', 10, 358, 'cuenta corriente'),
(40, '333221', 1500, 357, 'cuenta ahorros'),
(41, '332211', 500, 357, 'cuenta cheques');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personas`
--

CREATE TABLE `personas` (
  `persona_id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `ap_paterno` varchar(100) NOT NULL,
  `ap_materno` varchar(100) NOT NULL,
  `correo` varchar(100) NOT NULL,
  `rol` varchar(100) NOT NULL,
  `departamento` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `personas`
--

INSERT INTO `personas` (`persona_id`, `nombre`, `ap_paterno`, `ap_materno`, `correo`, `rol`, `departamento`) VALUES
(357, 'heidy', 'arancibia', 'calisaya', 'heidy36@gmail.com', 'Director bancario', 'Cochabamba'),
(358, 'Noemi', 'Calisaya', 'Arancibia', 'noemi@gmail.com', 'Cliente', 'Cochabamba'),
(359, 'Carla', 'Arancibia', 'Arancibia', 'noemi@gmail.com', 'Cliente', 'Pando'),
(361, 'Laura', 'Chuquimia', 'Carlo', 'laura@gmail.com', 'Titular', 'Potosi'),
(365, 'Francisco', 'Tarqui', 'calisaya', 'frank@gmail.com', 'Cliente', 'Beni');

--
-- Disparadores `personas`
--
DELIMITER $$
CREATE TRIGGER `eliminar_persona` BEFORE DELETE ON `personas` FOR EACH ROW BEGIN
    DELETE FROM cuentaBancarias WHERE persona_id = OLD.persona_id;
    DELETE FROM transaccionBancaria WHERE cuenta_origen=OLD.persona_id;
    DELETE FROM transaccionBancaria WHERE cuenta_destino=OLD.persona_id;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transaccionbancaria`
--

CREATE TABLE `transaccionbancaria` (
  `transaccion_id` int(11) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `monto` int(11) NOT NULL,
  `cuenta_origen` int(11) DEFAULT NULL,
  `cuenta_destino` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cuentabancarias`
--
ALTER TABLE `cuentabancarias`
  ADD PRIMARY KEY (`cuentabancaria_id`),
  ADD KEY `persona_id` (`persona_id`);

--
-- Indices de la tabla `personas`
--
ALTER TABLE `personas`
  ADD PRIMARY KEY (`persona_id`);

--
-- Indices de la tabla `transaccionbancaria`
--
ALTER TABLE `transaccionbancaria`
  ADD PRIMARY KEY (`transaccion_id`),
  ADD KEY `cuenta_origen` (`cuenta_origen`),
  ADD KEY `cuenta_destino` (`cuenta_destino`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cuentabancarias`
--
ALTER TABLE `cuentabancarias`
  MODIFY `cuentabancaria_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT de la tabla `personas`
--
ALTER TABLE `personas`
  MODIFY `persona_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=368;

--
-- AUTO_INCREMENT de la tabla `transaccionbancaria`
--
ALTER TABLE `transaccionbancaria`
  MODIFY `transaccion_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cuentabancarias`
--
ALTER TABLE `cuentabancarias`
  ADD CONSTRAINT `cuentabancaria_ibfk_1` FOREIGN KEY (`persona_id`) REFERENCES `personas` (`persona_id`);

--
-- Filtros para la tabla `transaccionbancaria`
--
ALTER TABLE `transaccionbancaria`
  ADD CONSTRAINT `transaccionbancaria_ibfk_1` FOREIGN KEY (`cuenta_origen`) REFERENCES `cuentabancarias` (`cuentabancaria_id`),
  ADD CONSTRAINT `transaccionbancaria_ibfk_2` FOREIGN KEY (`cuenta_destino`) REFERENCES `cuentabancarias` (`cuentabancaria_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
