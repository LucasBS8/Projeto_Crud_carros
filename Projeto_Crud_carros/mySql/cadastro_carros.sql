create database cadastro_carros;

use cadastro_carros;

create table carros(
id_carro SERIAL primary key,
codigo_crv int (15) not null,
marca char(10) not null,
modelo char(20) not null,
cor char (10) not null,
placa char(8) not null,
renavam int (15) not null,
status_carro char(5) not null,
macaco bool not null,
instrucoes bool not null,
reserva bool not null
);

create table marcas(
id_marca SERIAL primary key,
nome char(20) not null
);

create table cores(
id_cor SERIAL primary key,
nome char(20) not null
);

SELECT 
    id_carro as 'ID', codigo_crv as 'CRV',marca,modelo,cor,placa,renavam,status_carro as 'status',macaco,instrucoes as 'instruções',reserva as 'chave reserva'
FROM
    carros;
    