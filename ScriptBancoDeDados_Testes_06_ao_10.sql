Create database Teste

Use Teste

-- Teste 06:

CREATE TABLE ALUNOS (

nome varchar (40) not null,
notasemestre1 decimal(5,2),
notasemestre2 decimal(5,2),
ano int not null

);

ALTER TABLE ALUNOS
ADD id int not null;

-- Teste 07:

INSERT INTO ALUNOS (id, nome, notasemestre1, notasemestre2, ano)
VALUES
(1, 'João', 5, 10, 2022),
(2,'João', 7, 5, 2023),
(3, 'Carlos', 3, 7, 2022),
(4, 'João', 2, 10, 2023),
(5, 'Vinicius', 4.5, 6, 2022),
(6, 'Vinicius', 3.1, 7.7, 2022);

select * from ALUNOS 

-- Test 08 logo abaixo!

select nome as Nomes, notasemestre1 as 'Nota do Primeiro Semestre', notasemestre1 as 'Nota do Segundo Semestre', AVG(notasemestre1 + notasemestre2)/2 AS 'Média Anual', ano AS Ano, iif (AVG(notasemestre1 + notasemestre2)/2 >= 6.5, 'Aprovado', 'Reprovado') as Status from ALUNOS group by nome, notasemestre1,ano

-- Test 09:

select nome as Nomes, notasemestre1 as 'Nota do Primeiro Semestre', notasemestre1 as 'Nota do Segundo Semestre', AVG(notasemestre1 + notasemestre2)/2 AS 'Média Anual', ano AS Ano, iif (AVG(notasemestre1 + notasemestre2)/2 >= 6.5, 'Aprovado', 'Reprovado') as Status from ALUNOS group by nome, notasemestre1,ano Having AVG(notasemestre1 + notasemestre2)/2 > 6

-- Test 10, os dados inseridos através do WF serão recebidos por essa tabela especifica:

CREATE TABLE DADOSWF (

nome varchar (40) not null,
notasemestre1 decimal(5,2),
notasemestre2 decimal(5,2),

);

select * from DADOSWF

