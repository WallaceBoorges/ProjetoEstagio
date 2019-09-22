CREATE DATABASE ProjetoEstagio
GO

USE ProjetoEstagio
GO

CREATE TABLE itensvenda (
    itensVenda_cod int IDENTITY(1,1) PRIMARY KEY,
    itensVenda_qtde float,
    itensVenda_valor money,
    venda_cod int,
    produto_cod int
);

CREATE TABLE venda (
    venda_cod int IDENTITY(1,1) PRIMARY KEY,
    venda_data datetime,
    venda_nfiscal int,
    venda_total money,
    venda_nparcelas int,
    venda_status int,
    cliente_cod int,
    tipoPag_cod int,
    fun_cod int
);

CREATE TABLE parcelascompra (
    parcelasCompra_cod int IDENTITY(1,1) PRIMARY KEY,
    parcelasCompra_valor money,
    parcelasCompra_datapagto date,
    parcelasCompra_vecto date,
    compra_cod int
);

CREATE TABLE fornecedor (
    fornecedor_cod int IDENTITY(1,1) PRIMARY KEY,
    fornecedor_nome varchar(95),
    fornecedor_rsocial varchar(95),
    fornecedor_ie varchar(95),
    fornecedor_cnpj varchar(50) UNIQUE,
    fornecedor_fone varchar(20),
    fornecedor_cel varchar(16),
    fornecedor_email varchar(95),
    endereco_cod int
);

CREATE TABLE tipopagamento (
    tipoPag_cod int IDENTITY(1,1) PRIMARY KEY,
    tipoPag_nome varchar(95)
);

CREATE TABLE produto (
    produto_cod int IDENTITY(1,1) PRIMARY KEY,
    produto_nome varchar(95),
    produto_descricao text,
    produto_valorpago money,
    produto_valorvenda money,
    produto_qtde float,
    uniMedida_cod int,
    categoria_cod int,
    subCategoria_cod int
);

CREATE TABLE parcelasvenda (
    venda_cod int,
    parcelasVenda_cod int IDENTITY(1,1) PRIMARY KEY,
    parcelasVenda_valor money,
    parcelasVenda_datapagto date,
    parcelasVenda_tadavecto date
);

CREATE TABLE compra (
    compra_cod int IDENTITY(1,1) PRIMARY KEY,
    compra_data datetime,
    compra_nfiscal int,
    compra_total money,
    compra_nparcelas int,
    compra_status int,
    fornecedor_cod int,
    tipoPag_cod int
);

CREATE TABLE subcategoria (
    subCategoria_cod int IDENTITY(1,1) PRIMARY KEY,
    subCategoria_nome varchar(95) UNIQUE,
    categoria_cod int
);

CREATE TABLE categoria (
    categoria_cod int IDENTITY(1,1) PRIMARY KEY,
    categoria_nome varchar(95) UNIQUE
);

CREATE TABLE undmedida (
    uniMedida_cod int IDENTITY(1,1) PRIMARY KEY,
    uniMedida_nome varchar(95) UNIQUE
);

CREATE TABLE itenscompra (
    itensCompra_cod int IDENTITY(1,1) PRIMARY KEY,
    itensCompra_qtde float,
    itensCompra_valor money,
    compra_cod int,
    produto_cod int
);

CREATE TABLE cliente (
    cliente_cod int IDENTITY(1,1) PRIMARY KEY,
    cliente_nome varchar(95),
    cliente_tipo int,
    cliente_cpfcnpj varchar(50) UNIQUE,
    cliente_rg varchar(20),
    cliente_rsocial varchar(95),
    cliente_cel varchar(16),
    cliente_email varchar(95),
    cliente_fone varchar(20),
    endereco_cod int
);

CREATE TABLE funcionario (
    fun_cod int IDENTITY(1,1) PRIMARY KEY,
    fun_nome varchar(95),
    fun_usuario varchar(20),
    fun_senha varchar(20),
    fun_cpf varchar(14),
    fun_rg varchar(20),
    fun_orgaoemissor varchar(95),
    fun_rgemissao date,
    fun_datanascimento date,
    fun_sexo varchar(10),
    fun_estadocivil varchar(20),
    fun_celular varchar(16),
    fun_funcaoexercida varchar(95),
    fun_admissao date,
    fun_demissao date,
    fun_salariobase money,
    fun_banconome varchar(95),
    fun_bancoagencia varchar(20),
    fun_bancoconta varchar(30),
    endereco_cod int,
    UNIQUE (fun_cpf, fun_rg, fun_usuario)
);

CREATE TABLE endereco (
    endereco_cod int IDENTITY(1,1) PRIMARY KEY,
    endereco_cep varchar(20),
    endereco_logradouro varchar(95),
    endereco_bairro varchar(95),
    endereco_numero varchar(10),
    endereco_cidade varchar(95),
    endereco_estado varchar(95)
);
 
ALTER TABLE itensvenda ADD CONSTRAINT FK_itensvenda_venda
    FOREIGN KEY (venda_cod)
    REFERENCES venda (venda_cod)
    ON DELETE CASCADE ON UPDATE CASCADE;
 
ALTER TABLE itensvenda ADD CONSTRAINT FK_itensvenda_produto
    FOREIGN KEY (produto_cod)
    REFERENCES produto (produto_cod)
    ON DELETE NO ACTION ON UPDATE CASCADE;
 
ALTER TABLE venda ADD CONSTRAINT FK_venda_tipopagamento
    FOREIGN KEY (tipoPag_cod)
    REFERENCES tipopagamento (tipoPag_cod)
    ON DELETE NO ACTION ON UPDATE CASCADE;
 
ALTER TABLE venda ADD CONSTRAINT FK_venda_cliente
    FOREIGN KEY (cliente_cod)
    REFERENCES cliente (cliente_cod)
    ON DELETE CASCADE ON UPDATE CASCADE;
 
ALTER TABLE venda ADD CONSTRAINT FK_venda_funcionario
    FOREIGN KEY (fun_cod)
    REFERENCES funcionario (fun_cod)
    ON DELETE NO ACTION ON UPDATE NO ACTION;
 
ALTER TABLE parcelascompra ADD CONSTRAINT FK_parcelascompra
    FOREIGN KEY (compra_cod)
    REFERENCES compra (compra_cod)
    ON DELETE CASCADE ON UPDATE CASCADE;
 
ALTER TABLE fornecedor ADD CONSTRAINT FK_fornecedor_endereco
    FOREIGN KEY (endereco_cod)
    REFERENCES endereco (endereco_cod)
    ON DELETE CASCADE ON UPDATE CASCADE;
 
ALTER TABLE produto ADD CONSTRAINT FK_produto_uniMedida
    FOREIGN KEY (uniMedida_cod)
    REFERENCES undmedida (uniMedida_cod)
    ON DELETE NO ACTION ON UPDATE CASCADE;
 
ALTER TABLE produto ADD CONSTRAINT FK_produto_categoria
    FOREIGN KEY (categoria_cod)
    REFERENCES categoria (categoria_cod)
    ON DELETE NO ACTION ON UPDATE CASCADE;
 
ALTER TABLE produto ADD CONSTRAINT FK_produto_subCategoria
    FOREIGN KEY (subCategoria_cod)
    REFERENCES subcategoria (subCategoria_cod)
    ON DELETE NO ACTION ON UPDATE CASCADE;
 
ALTER TABLE parcelasvenda ADD CONSTRAINT FK_parcelasvenda
    FOREIGN KEY (venda_cod)
    REFERENCES venda (venda_cod)
    ON DELETE CASCADE ON UPDATE CASCADE;
 
ALTER TABLE compra ADD CONSTRAINT FK_compra_tipopagamento
    FOREIGN KEY (tipoPag_cod)
    REFERENCES tipopagamento (tipoPag_cod)
    ON DELETE NO ACTION ON UPDATE CASCADE;
 
ALTER TABLE compra ADD CONSTRAINT FK_compra_fornecedor
    FOREIGN KEY (fornecedor_cod)
    REFERENCES fornecedor (fornecedor_cod)
    ON DELETE SET NULL ON UPDATE CASCADE;
 
ALTER TABLE subcategoria ADD CONSTRAINT FK_subCategoria_categoria
    FOREIGN KEY (categoria_cod)
    REFERENCES categoria (categoria_cod)
    ON DELETE NO ACTION ON UPDATE NO ACTION;
 
ALTER TABLE itenscompra ADD CONSTRAINT FK_itenscompra_compra
    FOREIGN KEY (compra_cod)
    REFERENCES compra (compra_cod)
    ON DELETE CASCADE ON UPDATE CASCADE;
 
ALTER TABLE itenscompra ADD CONSTRAINT FK_itenscompra_produto
    FOREIGN KEY (produto_cod)
    REFERENCES produto (produto_cod)
    ON DELETE NO ACTION ON UPDATE CASCADE;
 
ALTER TABLE cliente ADD CONSTRAINT FK_cilente_endereco
    FOREIGN KEY (endereco_cod)
    REFERENCES endereco (endereco_cod)
    ON DELETE CASCADE ON UPDATE NO ACTION;
 
ALTER TABLE funcionario ADD CONSTRAINT FK_funcionario_endereco
    FOREIGN KEY (endereco_cod)
    REFERENCES endereco (endereco_cod)
    ON DELETE CASCADE ON UPDATE NO ACTION;