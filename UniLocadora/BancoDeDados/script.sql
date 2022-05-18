-- Nome do banco de dados: unilocadora_4manha
-- 
-- 

-- tabela de clientes
CREATE TABLE cliente(
    id_cliente INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    data_nasc DATE NOT NULL,
    cpf VARCHAR(11)
);

-- tabela de veículos:
create table veiculo (
	placa varchar(7) PRIMARY KEY,
    fabricante varchar(30) not null,
    modelo varchar(20) not null,
    ano int not null,
    cor varchar(20) not null
);

-- tabela de locações:
CREATE TABLE locacao(
	nr_locacao INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente INT NOT NULL,
    placa VARCHAR(7) NOT NULL,
    data_locacao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    data_devolucao DATETIME,
    	CONSTRAINT fk_locacao_cliente FOREIGN KEY (id_cliente)
    		REFERENCES cliente(id_cliente),
    	CONSTRAINT fk_locacao_veiculo FOREIGN KEY (placa)
    		REFERENCES veiculo(placa)
);