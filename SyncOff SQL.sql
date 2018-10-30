USE MASTER
GO
DROP DATABASE SyncOff
GO
CREATE DATABASE SyncOff
GO
USE SyncOff
GO

CREATE TABLE Funcionarios (
    matricula varchar (100) NOT NULL,
	nmFuncionario varchar (100) NOT NULL,
	nascFuncionario varchar (100) NOT NULL,
	departamentoFunc varchar (100) NOT NULL
	);
	
CREATE TABLE Departamentos (
	departamento varchar (100) NOT NULL
	);
	
INSERT INTO Departamentos (departamento) VALUES ('Marketing')
INSERT INTO Departamentos (departamento) VALUES ('Comercial')
INSERT INTO Departamentos (departamento) VALUES ('Operacional')
INSERT INTO Departamentos (departamento) VALUES ('Vendas')
INSERT INTO Departamentos (departamento) VALUES ('Tecnologia')
INSERT INTO Departamentos (departamento) VALUES ('Administrativo')
INSERT INTO Departamentos (departamento) VALUES ('Financeiro')

SELECT * FROM Funcionarios
SELECT * FROM Departamentos