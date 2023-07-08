CREATE TABLE produtos (
	id INT PRIMARY KEY IDENTITY (1, 1),
	nome VARCHAR(100),
	quantidade INT,
	preco_unitario DECIMAL(13,2)
);

SELECT * FROM produtos;

CREATE TABLE clientes(
	id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(100) NOT NULL,
	cpf VARCHAR(14) NOT NULL,

	estado VARCHAR(2) NOT NULL,
	cidade VARCHAR(100) NOT NULL,
	bairro VARCHAR(40) NOT NULL,
	logradouro VARCHAR(50) NOT NULL,
	numero VARCHAR(10) NOT NULL,
	complemento TEXT
);

ALTER TABLE clientes ADD data_nascimento DATETIME2 NOT NULL;
ALTER TABLE clientes ADD cep CHAR(9) NOT NULL;

CREATE TABLE PEDIDOS(
	id INT PRIMARY KEY IDENTITY (1,1),
	id_cliente INT NOT NULL,
	total DECIMAL(13,2) DEFAULT 0,
	data_efetivacao DATETIME2,

	-- FOREIGN KEY: chave estrangeira, ou seja, dependnecia de um registro de uma tabela para outro registro de tabela
	-- Pedidos coluna (id_cliente) referencia a tabela clientes coluna (id)
	-- FOREING KEY --> PK (primary key)
	-- FOREING KEY(nome_coluna) REFERENCES nome_tabela_referencia(nome_coluna_pk)
	FOREIGN KEY(id_cliente) REFERENCES clientes(id)
);

CREATE TABLE CARRINHO(
	id INT PRIMARY KEY IDENTITY(1,1),
	id_pedido INT NOT NULL,
	id_produto INT NOT NULL,
	quantidade INT NOT NULL,

	FOREIGN KEY(id_pedido) REFERENCES pedidos(id),
	FOREIGN KEY(id_produto) REFERENCES produtos(id)
);

ALTER TABLE PEDIDOS ADD STATUS INT NOT NULL;

-- INNER JOIN: capacidade de eu utilizar informações de mais de uma tabela dentro de uma busca no banco de dados
-- SELECT pedidos.id, clientes.nome, pedidos.status FROM pedidos INNER JOIN clientes on (pedidos.id_cliente = cliente.id)