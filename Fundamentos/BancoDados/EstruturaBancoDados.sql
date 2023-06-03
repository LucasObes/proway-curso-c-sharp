-- Criação da tabela
CREATE TABLE jogos(
    id INT PRIMARY KEY IDENTITY (1, 1),
    categoria VARCHAR(40),
    nome VARCHAR(100)
);

-- DOUBLE: decimal
-- BIT: 1, 0 -> boolean
-- DATE: data
-- DATETIME2: data de hora

-- Consultar a quantidade de registros da tabela: SELECT COUNT (o que eu quero) FROM tabela_nom

-- Posso consultar todos os campos da tabela de jogos (* ja busca todos)
SELECT id, categoria, nome FROM jogos;