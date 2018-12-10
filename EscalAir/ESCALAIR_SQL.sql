USE master;

GO

DROP DATABASE EscalAir;

GO

CREATE DATABASE EscalAir;

GO

USE EscalAir;

GO

SET DATEFORMAT ymd;

GO

CREATE TABLE Administrador (
	id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(60),
	senha VARCHAR(60)
);

CREATE TABLE Aviao(	
	id INT PRIMARY KEY IDENTITY(1,1),
	tipo VARCHAR(50)
);

CREATE TABLE Cargos (
	id INT PRIMARY KEY IDENTITY(1,1),
	descricao VARCHAR(30)
);

CREATE TABLE Empresa (
	id INT PRIMARY KEY IDENTITY(1,1),
	nomeEmpresa VARCHAR(30)
);

CREATE TABLE Usuario(
	id INT PRIMARY KEY IDENTITY(1,1),
	cht VARCHAR(30) NOT NULL,
	primeiroNome VARCHAR(30) NOT NULL,
	sobrenome VARCHAR(30) NOT NULL,
	cpf VARCHAR(30) NOT NULL,
	dataNascimento DATETIME NOT NULL,
	cargo INT,
	idEmpresa INT,
	senha VARCHAR(64),
	FOREIGN KEY (cargo) REFERENCES Cargos(id),
	FOREIGN KEY (idEmpresa) REFERENCES Empresa(id)
);

CREATE TABLE Endereco (
	id INT PRIMARY KEY IDENTITY(1,1),
	idUsuario INT,
	estado VARCHAR(30),
	cidade VARCHAR(30),
	bairro VARCHAR(30),
	rua VARCHAR(30),
	numero INT,
	FOREIGN KEY (idUsuario) REFERENCES Usuario(id)
);

CREATE TABLE Telefone (
	idTelefone INT PRIMARY KEY IDENTITY(1,1),
	idUsuario INT,
	telefone VARCHAR(30),
	FOREIGN KEY (idUsuario) REFERENCES Usuario(id)
);

CREATE TABLE Tripulacao(
	id INT PRIMARY KEY IDENTITY(1,1),
	idPiloto INT,
	idCopiloto INT,
	idComissarioChefe INT,
	idComissarioUm INT,
	idComissarioDois INT,
	FOREIGN KEY (idPiloto) REFERENCES Usuario(id),
	FOREIGN KEY (idCopiloto) REFERENCES Usuario(id),
	FOREIGN KEY (idComissarioChefe) REFERENCES Usuario(id),
	FOREIGN KEY (idComissarioUm) REFERENCES Usuario(id),
	FOREIGN KEY (idComissarioDois) REFERENCES Usuario(id),
);

CREATE TABLE Voo(
	id INT PRIMARY KEY IDENTITY(1,1),
	aviaoId INT,
	origem VARCHAR(100),
	destino VARCHAR(100),
	horaPartida DATETIME,
	horaChegada DATETIME,
	numeroPassageiros INT,
	tripulacaoId INT,
	FOREIGN KEY (aviaoId) REFERENCES Aviao(id),
	FOREIGN KEY (tripulacaoId) REFERENCES Tripulacao(id)
);

INSERT INTO 
	Administrador (nome, senha)
VALUES
('admin', 'admin');

INSERT INTO 
	Aviao (tipo)
VALUES 
('Boeing 747-500'), 
('Airbus A330');

INSERT INTO 
	Cargos (descricao)
VALUES
('Piloto'),
('Copiloto'),
('Comissário(a) chefe'),
('Comissário(a)');

INSERT INTO
	Empresa (nomeEmpresa)
VALUES
('Gol'),
('Azul'),
('LATAM'),
('American Airlines');

INSERT INTO 
	Usuario (cht,  sobrenome, primeiroNome, cpf, dataNascimento, cargo, idEmpresa, senha) 
VALUES 
('1234', 'Bueno', 'Roberto', '596.584.756-0', CAST(N'1992-06-06 00:00:00.000' AS DATETIME), 1, 2, '1234'),
('56789-9', 'Cortina', 'Luis', '554.789.658-3', CAST(N'1997-01-06 00:00:00.000' AS DATETIME), 2, 2, '1234'),
('10111-2', 'Bueno', 'Mariana', '256.968.745-7', CAST(N'1995-02-20 00:00:00.000' AS DATETIME), 3, 2, '1234'),
('13141-5', 'Rodrigues', 'Rebecca', '448.789.856-1', CAST(N'1986-07-10 00:00:00.000' AS DATETIME),  4, 2, '1234'),
('16171-8', 'Pires', 'Gabriela', '587.658.968-4', CAST(N'1988-04-02 00:00:00.000' AS DATETIME), 4, 2, '1234');

INSERT INTO
	Endereco (idUsuario, estado, cidade, bairro, rua, numero)
VALUES
(1, 'São Paulo', 'Campinas', 'Joaquim Egídio', 'Rua A', 10),
(2, 'São Paulo', 'Campinas', 'Parque das Oliveiras', 'Rua B', 11),
(3, 'São Paulo', 'Campinas', 'Cambuí', 'Rua C', 13),
(4, 'São Paulo', 'Campinas', 'Taquaral', 'Rua D', 14),
(5, 'São Paulo', 'Campinas', 'Centro', 'Rua E', 15);


INSERT INTO Telefone(idUsuario, telefone) VALUES 
(1, '+551932323595'),
(2, '+551932386788'),
(3, '+551932356345'),
(4, '+551938786322'),
(5, '+551935566544');

INSERT INTO 
	Tripulacao (idPiloto, idCopiloto, idComissarioChefe, idComissarioUm, idComissarioDois)
VALUES 
	(1, 2, 3, 4, 5),
	(1, 2, 3, 4, 5);

INSERT INTO 
	Voo(aviaoId, origem, destino, horaPartida, horaChegada, numeroPassageiros, tripulacaoId)
VALUES
(1, 'São Paulo', 'Bariloche', CAST(N'2017-12-12 12:32' AS DATETIME),  CAST(N'2017-12-12 18:32' AS DATETIME), 139, 1),
(2, 'Aracaju', 'Havana', CAST(N'2017-12-12 12:32' AS DATETIME), CAST(N'2017-12-12 18:32' AS DATETIME), 13, 2);

GO 

CREATE PROCEDURE CarregarVoo(@id INT)
AS
BEGIN
SELECT 
a.tipo AS 'Avião',
v.origem AS 'Origem',
v.horaPartida AS 'Hora de Partida',
v.destino AS 'Destino',
v.horaChegada AS 'Hora de Chegada',
CONCAT(piloto.primeiroNome, ' ', piloto.sobrenome)  AS 'Piloto',
CONCAT(copiloto.primeiroNome, ' ', copiloto.sobrenome) AS 'Copiloto',
CONCAT(comissarioChefe.primeiroNome, ' ', comissarioChefe.sobrenome) AS 'Comissário(a) Chefe',
CONCAT(comissarioUm.primeiroNome, ' ', comissarioUm.sobrenome) AS 'Comissário(a) 1',
CONCAT(comissarioDois.primeiroNome, ' ', comissarioDois.sobrenome) AS 'Comissário(a) 2'

FROM Aviao a
INNER JOIN Voo v ON a.id = v.aviaoId
INNER JOIN Tripulacao t ON t.id = v.tripulacaoId
INNER JOIN Usuario piloto ON piloto.id = t.idPiloto
INNER JOIN Usuario copiloto ON copiloto.id = t.idCopiloto
INNER JOIN Usuario comissarioChefe ON comissarioChefe.id = t.idComissarioChefe
INNER JOIN Usuario comissarioUm ON comissarioUm.id = t.idComissarioUm
INNER JOIN Usuario comissarioDois ON comissarioDois.id = t.idComissarioDois
WHERE v.id = @id;

END;

