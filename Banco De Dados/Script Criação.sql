CREATE DATABASE ProjetoEstagio
GO

USE ProjetoEstagio
GO

/* Modelo Logico: */

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
    venda_nfiscal varchar(95),
    venda_total money,
    venda_nparcelas int,
    venda_taxaParcela float,
    venda_status varchar(30),
    cliente_cod int,
    tipoPag_cod int,
    fun_cod int
);

CREATE TABLE parcelascompra (
    parcelasCompra_cod int IDENTITY(1,1) PRIMARY KEY,
    parcelasCompra_valor money,
    parcelasCompra_vecto date,
    parcelasCompra_datapagto date,
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
    produto_valorvenda money,
    produto_qtde float,
    produto_status varchar(20) NOT NULL CHECK(produto_status IN ( 'EM ESTOQUE', 'FORA DE ESTOQUE')),
    uniMedida_cod int,
    categoria_cod int,
    subCategoria_cod int
);

CREATE TABLE parcelasvenda (
    parcelasVenda_cod int IDENTITY(1,1) PRIMARY KEY,
    parcelasVenda_valor money,
    parcelasVenda_tadavecto date,
    parcelasVenda_datapagto date,
    venda_cod int
);

CREATE TABLE compra (
    compra_cod int IDENTITY(1,1) PRIMARY KEY,
    compra_data date,
    compra_nfiscal varchar(95) UNIQUE,
    compra_total money,
    compra_nparcelas int,
    compra_status varchar(11) NOT NULL CHECK(compra_status IN ('AGUARDANDO', 'FINALIZADA', 'CANCELADA')),
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
    itensCompra_qtdeVenda float,
    itensCompra_valor money,
    itensCompra_codigoBarra varchar(50) UNIQUE,
    itensCompra_vencimento date,
    compra_cod int,
    produto_cod int
);

CREATE TABLE cliente (
    cliente_cod int IDENTITY(1,1) PRIMARY KEY,
    cliente_nome varchar(95),
    cliente_tipo varchar(10) NOT NULL CHECK(cliente_tipo IN ( 'F�SICA', 'JUR�DICA')),
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

USE [ProjetoEstagio]
GO

INSERT INTO [dbo].[endereco]
           ([endereco_cep]
           ,[endereco_logradouro]
           ,[endereco_bairro]
           ,[endereco_numero]
           ,[endereco_cidade]
           ,[endereco_estado])
     VALUES
           ('13235',
		   'rua',
		   'centro',
		   '64',
		   'Paripiranga',
		   'Bahia')
GO

USE [ProjetoEstagio]
GO

INSERT INTO [dbo].[funcionario]
           ([fun_nome]
           ,[fun_usuario]
           ,[fun_senha]
           ,[fun_cpf]
           ,[fun_rg]
           ,[fun_datanascimento]
           ,[fun_sexo]
           ,[fun_estadocivil]
           ,[fun_celular]
           ,[fun_funcaoexercida]
           ,[fun_admissao]
           ,[fun_demissao]
           ,[fun_salariobase]
           ,[fun_banconome]
           ,[fun_bancoagencia]
           ,[fun_bancoconta]
           ,[endereco_cod])
     VALUES
           ('admin',
		   'admin',
		   'admin',
		   '1226563563',
		   '23526536',
		   '01/01/2012',
		   'Masculino',
		   'Solteiro',
		   '235546354',
		   'Administrador',
		   '01/12/2019',
		   null,
		   '10000',
		   'Nubank',
		   '0001',
		   '4856486',
		   '1')
GO