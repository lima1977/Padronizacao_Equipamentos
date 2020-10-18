USE [Cadastro]
GO

/****** Object:  Table [dbo].[Funcionarios]    Script Date: 4/13/2020 10:49:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Funcionarios](
	[FuncionarioID] [int] NOT NULL,
	[Matricula] [int] NULL,
	[Nome] [nvarchar](100) NULL,
	[Cpf] [nvarchar](20) NULL,
	[Nasc] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[Rg] [nvarchar](20) NULL,
	[Estadocivil] [nvarchar](100) NULL,
	[Sexo] [nvarchar](100) NULL,
	[Filhos] [nvarchar](100) NULL,
	[Pcd] [nvarchar](100) NULL,
	[Deficiencia] [nvarchar](100) NULL,
	[Endereco] [nvarchar](100) NULL,
	[Numero] [nvarchar](25) NULL,
	[Bairro] [nvarchar](100) NULL,
	[Cidade] [nvarchar](100) NULL,
	[Comple] [nvarchar](100) NULL,
	[Cep] [nvarchar](10) NULL,
	[Uf] [nvarchar](10) NULL,
	[Telefone] [nvarchar](100) NULL,
	[Celular] [nvarchar](100) NULL,
	[Departamento] [nvarchar](100) NULL,
	[Cargo] [nvarchar](100) NOT NULL,
	[Empresa] [nvarchar](30) NULL,
	[Adimissao] [nvarchar](12) NULL,
	[Situacao] [nvarchar](15) NULL,
	[Datacad] [varchar](15) NULL,
	[Supervisor] [nvarchar](100) NULL,
	[Coordenador] [nvarchar](100) NULL,
	[Turno] [nvarchar](100) NULL,
	[Fretado] [nvarchar](100) NULL,
	[Obs] [nvarchar](1000) NULL,
	[ImagemUrl] [varbinary](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[FuncionarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


