-- Criando Banco de Dados
drop database bdExemplo;
Create database bdExemplo;
use bdExemplo;
create table Usuario(
Id int primary key auto_increment,
Nome varchar(50) not null,
Email varchar(50) not null,
Senha varchar(50) not null  
)

-- Consultando os dados do banco
select * from Usuario;	
insert into Usuario values(1,'Kaka', 'kakazindlas@gmail.com', 'kaka2008');