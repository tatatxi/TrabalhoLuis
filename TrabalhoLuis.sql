-- criando base de dados
CREATE DATABASE trabalhoLuis

use trabalhoLuis

create table clientes
(
codigo integer primary key,
nome varchar(100),
veiculo varchar(100),
placa varchar(100),
email varchar(100)
)

create table oleos
(
codigo integer primary key,
nome varchar(100),
categoria varchar(100),
tipo varchar(100),
fabricante varchar(100),
valor decimal(10,2)
)

insert into oleos values(1010, 'F1 Master', 'Sintetico verde', 'OW20SN', 'Ipiranga' , 34.90)
insert into oleos values(1011, 'F1 Master', 'Sintetico' , '5W40508', 'Ipiranga', 43.90)
insert into oleos values(1012, 'F1 Master', 'Sintetico', '5W40502', 'Ipiranga', 45.90)
insert into oleos values(1013, 'F1 Master', 'Sintetico', '5W30SN', 'Ipiranga', 33.90)
insert into oleos values(1014, 'F1 Master', 'Sintetico', '10W40SM', 'Ipiranga', 32.00)
insert into oleos values(1015, 'F1 Master', 'Sintetico', '5W30SN/RC', 'Ipiranga', 50.00)
insert into oleos values(1016, 'F1 Master', 'Performace', '15W40 SL', 'Ipiranga', 29.00)
insert into oleos values(1017, 'F1 Master', 'Performace', '15W50 SL CI/4', 'Ipiranga', 32.00)
insert into oleos values(1110, 'Supra MX', 'Sintetico Racing', '5W30', 'Supra', 28.00)
insert into oleos values(1111, 'Supra MX', 'Semi Sintetico', '15W40', 'Supra', 33.00)
drop table oleos

create table usuarios
(
codigo integer primary key identity(1,1),
email varchar(100),
senha varchar(100)
)

bulk insert clientes
from 'C:\Users\niick\Documents\Trabalho Luis\Clientes.txt'
with(
	CODEPAGE='ACP',
	FIELDTERMINATOR = ';',
	firstrow = 2
)

bulk insert oleos
from 'C:\Users\niick\Documents\Trabalho Luis\Oleos.txt'
with(
	CODEPAGE='ACP',
	FIELDTERMINATOR = ';',
	firstrow = 2
)

bulk insert usuarios
from 'C:\Users\niick\Documents\Trabalho Luis\usuarios.txt'
with(
	CODEPAGE='ACP',
	FIELDTERMINATOR   = ';',
	firstrow = 2
)

select * from clientes;

select * from oleos;

select * from usuarios;

create table controleTroca(
codigo int primary key identity(1,1),
data_troca datetime,
nome_cliente varchar(100),
nome_oleo varchar(100),
categoria_oleo varchar(100),
tipo_oleo varchar(100),
fabricante varchar(100),
valor_oleo decimal(10,3),
qtd_oleo decimal(10,3),
vlr_total decimal(10,2),
email_cliente varchar(100))