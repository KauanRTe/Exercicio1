use Ex1

create table Produto(
	ProdutoId int identity(1,1),
	Nome nvarchar(64),
	Estoque int,
	Valor nvarchar(32),
	Cnpj bit)