-- Criando Banco de Dados
Create database bdExemplo;
use bdExemplo;
create table Usuarios(
Id int primary key auto_increment,
Nome varchar(50) not null,
Email varchar(50) not null,
Senha varchar(50) not null  
)

-- Consultando os dados do banco
select * from Usuarios;	