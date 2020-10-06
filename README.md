# Exemplo da implementação do MVC usando O .NET Core (Console)

## SQL
CREATE DATABASE ESTUDO1;

USE ESTUDO1;

CREATE TABLE PESSOA(
	id bigint not null primary key,
	nome varchar(50) not null,
	telefone varchar(11) not null
);
