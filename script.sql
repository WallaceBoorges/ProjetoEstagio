USE [master]
GO
/****** Object:  Database [ProjetoEstagio]    Script Date: 8/31/2019 11:23:11 PM ******/
CREATE DATABASE [ProjetoEstagio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjetoEstagio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ProjetoEstagio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProjetoEstagio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ProjetoEstagio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProjetoEstagio] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjetoEstagio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjetoEstagio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjetoEstagio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjetoEstagio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjetoEstagio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjetoEstagio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProjetoEstagio] SET  MULTI_USER 
GO
ALTER DATABASE [ProjetoEstagio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjetoEstagio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjetoEstagio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjetoEstagio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProjetoEstagio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProjetoEstagio] SET QUERY_STORE = OFF
GO
USE [ProjetoEstagio]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[categoria_cod] [int] IDENTITY(1,1) NOT NULL,
	[categoria_nome] [varchar](95) NULL,
 CONSTRAINT [XPKcategoria] PRIMARY KEY NONCLUSTERED 
(
	[categoria_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[cliente_cod] [int] IDENTITY(1,1) NOT NULL,
	[cliente_nome] [varchar](95) NULL,
	[cliente_cpfcnpj] [varchar](95) NULL,
	[cliente_rg] [varchar](95) NULL,
	[cliente_rsocial] [varchar](95) NULL,
	[cliente_tipo] [int] NULL,
	[cliente_cep] [varchar](20) NULL,
	[cliente_endereco] [varchar](95) NULL,
	[cliente_bairro] [varchar](95) NULL,
	[cliente_cel] [varchar](95) NULL,
	[cliente_email] [varchar](95) NULL,
	[cliente_endnumero] [varchar](10) NULL,
	[cliente_cidade] [varchar](95) NULL,
	[cliente_estado] [varchar](95) NULL,
	[cliente_fone] [varchar](95) NULL,
 CONSTRAINT [XPKcliente] PRIMARY KEY NONCLUSTERED 
(
	[cliente_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compra]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra](
	[compra_cod] [int] IDENTITY(1,1) NOT NULL,
	[compra_data] [datetime] NULL,
	[compra_nfiscal] [int] NULL,
	[compra_total] [money] NULL,
	[compra_nparcelas] [int] NULL,
	[compra_status] [int] NULL,
	[fornecedor_cod] [int] NULL,
	[tipoPag_cod] [int] NULL,
 CONSTRAINT [XPKcompra] PRIMARY KEY NONCLUSTERED 
(
	[compra_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fornecedor](
	[fornecedor_cod] [int] IDENTITY(1,1) NOT NULL,
	[fornecedor_nome] [varchar](95) NULL,
	[fornecedor_rsocial] [varchar](95) NULL,
	[fornecedor_ie] [varchar](95) NULL,
	[fornecedor_cnpj] [varchar](95) NULL,
	[fornecedor_cep] [varchar](95) NULL,
	[fornecedor_endereco] [varchar](95) NULL,
	[fornecedor_bairro] [varchar](95) NULL,
	[fornecedor_fone] [varchar](95) NULL,
	[fornecedor_cel] [varchar](95) NULL,
	[fornecedor_email] [varchar](95) NULL,
	[fornecedor_endnumero] [varchar](95) NULL,
	[fornecedor_cidade] [varchar](95) NULL,
	[fornecedor_estado] [varchar](95) NULL,
 CONSTRAINT [XPKfornecedor] PRIMARY KEY NONCLUSTERED 
(
	[fornecedor_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[itenscompra]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itenscompra](
	[itensCompra_cod] [int] NOT NULL,
	[itensCompra_qtde] [float] NULL,
	[itensCompra_valor] [money] NULL,
	[compra_cod] [int] NOT NULL,
	[produto_cod] [int] NOT NULL,
 CONSTRAINT [XPKitenscompra] PRIMARY KEY NONCLUSTERED 
(
	[itensCompra_cod] ASC,
	[compra_cod] ASC,
	[produto_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[itensvenda]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itensvenda](
	[itensVenda_cod] [int] NOT NULL,
	[itensVenda_qtde] [float] NULL,
	[ittensVenda_valor] [money] NULL,
	[venda_cod] [int] NOT NULL,
	[produto_cod] [int] NOT NULL,
 CONSTRAINT [XPKitensVenda] PRIMARY KEY NONCLUSTERED 
(
	[itensVenda_cod] ASC,
	[venda_cod] ASC,
	[produto_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parcelascompra]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parcelascompra](
	[parcelasCompra_cod] [int] NOT NULL,
	[parcelasCompra_valor] [money] NULL,
	[parcelasCompra_datapagto] [date] NULL,
	[parcelasCompra_datavecto] [date] NULL,
	[compra_cod] [int] NOT NULL,
 CONSTRAINT [XPKparcelascompra] PRIMARY KEY CLUSTERED 
(
	[parcelasCompra_cod] ASC,
	[compra_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parcelasvenda]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parcelasvenda](
	[venda_cod] [int] NOT NULL,
	[parcelasVenda_cod] [int] NOT NULL,
	[parcelasVenda_valor] [money] NULL,
	[parcelasVenda_datapagto] [date] NULL,
	[parcelasVenda_datavecto] [date] NULL,
 CONSTRAINT [XPKparcelasvenda] PRIMARY KEY CLUSTERED 
(
	[venda_cod] ASC,
	[parcelasVenda_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produto](
	[produto_cod] [int] IDENTITY(1,1) NOT NULL,
	[produto_nome] [varchar](95) NULL,
	[produto_descricao] [text] NULL,
	[produto_foto] [image] NULL,
	[produto_valorpago] [money] NULL,
	[produto_valorvenda] [money] NULL,
	[produto_qtde] [float] NULL,
	[uniMedida_cod] [int] NULL,
	[categoria_cod] [int] NULL,
	[subCategoria_cod] [int] NULL,
 CONSTRAINT [XPKproduto] PRIMARY KEY NONCLUSTERED 
(
	[produto_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subcategoria]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subcategoria](
	[subCategoria_cod] [int] IDENTITY(1,1) NOT NULL,
	[subCategoria_nome] [varchar](95) NULL,
	[categoria_cod] [int] NULL,
 CONSTRAINT [XPKsubcategoria] PRIMARY KEY NONCLUSTERED 
(
	[subCategoria_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipopagamento]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipopagamento](
	[tipoPag_cod] [int] NOT NULL,
	[tipoPag_nome] [varchar](90) NULL,
 CONSTRAINT [XPKtipopagamento] PRIMARY KEY CLUSTERED 
(
	[tipoPag_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[undmedida]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[undmedida](
	[uniMedida_cod] [int] IDENTITY(1,1) NOT NULL,
	[uniMedida_nome] [varchar](95) NULL,
 CONSTRAINT [XPKmedida] PRIMARY KEY NONCLUSTERED 
(
	[uniMedida_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venda]    Script Date: 8/31/2019 11:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venda](
	[venda_cod] [int] IDENTITY(1,1) NOT NULL,
	[venda_data] [datetime] NULL,
	[venda_nfiscal] [int] NULL,
	[venda_total] [money] NULL,
	[venda_nparcelas] [int] NULL,
	[venda_status] [int] NULL,
	[cliente_cod] [int] NULL,
	[tipoPag_cod] [int] NULL,
 CONSTRAINT [XPKvenda] PRIMARY KEY NONCLUSTERED 
(
	[venda_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [R_21] FOREIGN KEY([fornecedor_cod])
REFERENCES [dbo].[fornecedor] ([fornecedor_cod])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [R_21]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [R_24] FOREIGN KEY([tipoPag_cod])
REFERENCES [dbo].[tipopagamento] ([tipoPag_cod])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [R_24]
GO
ALTER TABLE [dbo].[itenscompra]  WITH CHECK ADD  CONSTRAINT [R_15] FOREIGN KEY([compra_cod])
REFERENCES [dbo].[compra] ([compra_cod])
GO
ALTER TABLE [dbo].[itenscompra] CHECK CONSTRAINT [R_15]
GO
ALTER TABLE [dbo].[itenscompra]  WITH CHECK ADD  CONSTRAINT [R_17] FOREIGN KEY([produto_cod])
REFERENCES [dbo].[produto] ([produto_cod])
GO
ALTER TABLE [dbo].[itenscompra] CHECK CONSTRAINT [R_17]
GO
ALTER TABLE [dbo].[itensvenda]  WITH CHECK ADD  CONSTRAINT [R_13] FOREIGN KEY([venda_cod])
REFERENCES [dbo].[venda] ([venda_cod])
GO
ALTER TABLE [dbo].[itensvenda] CHECK CONSTRAINT [R_13]
GO
ALTER TABLE [dbo].[itensvenda]  WITH CHECK ADD  CONSTRAINT [R_14] FOREIGN KEY([produto_cod])
REFERENCES [dbo].[produto] ([produto_cod])
GO
ALTER TABLE [dbo].[itensvenda] CHECK CONSTRAINT [R_14]
GO
ALTER TABLE [dbo].[parcelascompra]  WITH CHECK ADD  CONSTRAINT [R_25] FOREIGN KEY([compra_cod])
REFERENCES [dbo].[compra] ([compra_cod])
GO
ALTER TABLE [dbo].[parcelascompra] CHECK CONSTRAINT [R_25]
GO
ALTER TABLE [dbo].[parcelasvenda]  WITH CHECK ADD  CONSTRAINT [R_22] FOREIGN KEY([venda_cod])
REFERENCES [dbo].[venda] ([venda_cod])
GO
ALTER TABLE [dbo].[parcelasvenda] CHECK CONSTRAINT [R_22]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [R_11] FOREIGN KEY([categoria_cod])
REFERENCES [dbo].[categoria] ([categoria_cod])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [R_11]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [R_12] FOREIGN KEY([subCategoria_cod])
REFERENCES [dbo].[subcategoria] ([subCategoria_cod])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [R_12]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [R_9] FOREIGN KEY([uniMedida_cod])
REFERENCES [dbo].[undmedida] ([uniMedida_cod])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [R_9]
GO
ALTER TABLE [dbo].[subcategoria]  WITH CHECK ADD  CONSTRAINT [R_10] FOREIGN KEY([categoria_cod])
REFERENCES [dbo].[categoria] ([categoria_cod])
GO
ALTER TABLE [dbo].[subcategoria] CHECK CONSTRAINT [R_10]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [R_20] FOREIGN KEY([cliente_cod])
REFERENCES [dbo].[cliente] ([cliente_cod])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [R_20]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [R_23] FOREIGN KEY([tipoPag_cod])
REFERENCES [dbo].[tipopagamento] ([tipoPag_cod])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [R_23]
GO
USE [master]
GO
ALTER DATABASE [ProjetoEstagio] SET  READ_WRITE 
GO
