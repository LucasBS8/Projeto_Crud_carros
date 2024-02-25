-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26/10/2023 às 03:44
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cadastro_carros`
--
CREATE DATABASE `cadastro_carros`;
USE `cadastro_carros`;
-- --------------------------------------------------------

--
-- Estrutura para tabela `carros`
--

CREATE TABLE `carros` (
  `id_carro` bigint(20) UNSIGNED NOT NULL,
  `codigo_crv` int(15) NOT NULL,
  `marca` char(10) NOT NULL,
  `modelo` char(20) NOT NULL,
  `cor` char(10) NOT NULL,
  `placa` char(8) NOT NULL,
  `renavam` int(15) NOT NULL,
  `status_carro` char(5) NOT NULL,
  `macaco` tinyint(1) NOT NULL,
  `instrucoes` tinyint(1) NOT NULL,
  `reserva` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `carros`
--

INSERT INTO `carros` (`id_carro`, `codigo_crv`, `marca`, `modelo`, `cor`, `placa`, `renavam`, `status_carro`, `macaco`, `instrucoes`, `reserva`) VALUES
(1, 202300012, 'Caoa Chery', 'modelo1', 'preto', 'fds 3233', 123414444, 'usado', 1, 0, 1),
(2, 202300041, 'Fiat', 'modelo2', 'vermelho', 'dhh 3231', 214156714, 'novo', 0, 1, 0),
(3, 462522646, 'Renault', 'modelo3', 'branco', 'ert 5466', 276483464, 'usado', 0, 0, 1),
(4, 454126161, 'Caoa Chery', 'modelo4', 'branco', 'dfd 3534', 533331551, 'usado', 1, 0, 1),
(5, 542131563, 'Hyundai', 'modelo 5', 'azul', 'jtr 4422', 809977488, 'novo', 1, 0, 0);

-- --------------------------------------------------------

--
-- Estrutura para tabela `cores`
--

CREATE TABLE `cores` (
  `id_cor` bigint(20) UNSIGNED NOT NULL,
  `nome` char(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cores`
--

INSERT INTO `cores` (`id_cor`, `nome`) VALUES
(1, 'preto'),
(2, 'branco'),
(3, 'prata'),
(4, 'rosa'),
(5, 'azul'),
(6, 'vermelho'),
(7, 'roxo');

-- --------------------------------------------------------

--
-- Estrutura para tabela `marcas`
--

CREATE TABLE `marcas` (
  `id_marca` bigint(20) UNSIGNED NOT NULL,
  `nome` char(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `marcas`
--

INSERT INTO `marcas` (`id_marca`, `nome`) VALUES
(1, 'Caoa Chery'),
(2, 'Hyundai'),
(3, 'Mercedes Benz'),
(4, 'Fiat'),
(5, 'Renault'),
(6, 'Alfa Romeo');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `carros`
--
ALTER TABLE `carros`
  ADD PRIMARY KEY (`id_carro`);

--
-- Índices de tabela `cores`
--
ALTER TABLE `cores`
  ADD PRIMARY KEY (`id_cor`);

--
-- Índices de tabela `marcas`
--
ALTER TABLE `marcas`
  ADD PRIMARY KEY (`id_marca`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `carros`
--
ALTER TABLE `carros`
  MODIFY `id_carro` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `cores`
--
ALTER TABLE `cores`
  MODIFY `id_cor` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `marcas`
--
ALTER TABLE `marcas`
  MODIFY `id_marca` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
