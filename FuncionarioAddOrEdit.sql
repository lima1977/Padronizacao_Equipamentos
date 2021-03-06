USE [Cadastro]
GO
/****** Object:  StoredProcedure [dbo].[FuncionarioAddOrEdit]    Script Date: 4/13/2020 10:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[FuncionarioAddOrEdit]
(
@FuncionarioID int ,
@Matricula int,
@Nome nvarchar(100),
@Cpf nvarchar(20),
@Nasc nvarchar(20),
@Email nvarchar(100),
@Rg nvarchar(20),
@Estadocivil nvarchar(100),
@Sexo nvarchar(100),
@Filhos nvarchar(100),
@Pcd nvarchar(100),
@Deficiencia nvarchar(100),
@Endereco nvarchar(100),
@Numero nvarchar(25),
@Bairro nvarchar(100),
@Cidade nvarchar(100),
@Comple nvarchar(100),
@Cep nvarchar(10),
@Uf nvarchar(10),
@Telefone nvarchar(100),
@Celular nvarchar(100),
@Departamento nvarchar(100),
@Cargo nvarchar(100),
@Empresa nvarchar(30),
@Adimissao nvarchar(12),
@Situacao nvarchar(15),
@Datacad  varchar(15),
@Supervisor nvarchar(100),
@Coordenador nvarchar(100),
@Turno nvarchar(100),
@Fretado nvarchar(100),
@Obs nvarchar(1000),
@ImagemUrl varbinary
)

as
BEGIN
IF (@FuncionarioID = 0)
BEGIN

	insert into Funcionarios(Matricula,Nome,Cpf,Nasc, Email,Rg,Estadocivil,Sexo,Filhos,Pcd,Deficiencia,Endereco,Numero,Bairro,Cidade,Comple,Cep,Uf,Telefone,Celular,       
    Departamento,Cargo,Empresa,Adimissao,Situacao,Datacad,Supervisor,Coordenador,Turno,Fretado,Obs, ImagemUrl)


	values  (@Matricula,@Nome,@cpf,@Nasc,@Email,@Rg,@Estadocivil,@Sexo,@Filhos,@Pcd,@Deficiencia,@Endereco,@Numero,@Bairro,@Cidade,@Comple,@Cep,@Uf,@Telefone,@Celular,  
	         @Departamento,@Cargo,@Empresa,@Adimissao,@Situacao,@Datacad,@Supervisor,@Coordenador,@Turno,@Fretado,@Obs,@ImagemUrl)	
	        
END
ELSE
BEGIN

UPDATE  Funcionarios 
 SET
Matricula=@Matricula,
Nome=@Nome,
Cpf=@cpf,
Nasc=@Nasc,
Email=@Email,
Rg=@Rg, 
Estadocivil=@Estadocivil,
Sexo=@Sexo, 
Filhos=@Filhos,
Pcd=@Pcd, 
Deficiencia=@Deficiencia,
Endereco=@Endereco, 
Numero=@Numero,
Cidade=@Cidade,
Comple=@Comple, 
Cep=@Cep,
Uf=@Uf, 
Telefone=@Telefone,
Celular=@Celular,                 
Departamento=@Departamento,
Cargo=@Cargo, 
Empresa=@Empresa,
Adimissao=@Adimissao,
Situacao=@Situacao,
Datacad=@Datacad,
Supervisor=@Supervisor,
Coordenador=@Coordenador,
Turno=@Turno,  
Fretado=@Fretado,
Obs = @Obs,
ImagemUrl= @ImagemUrl
where FuncionarioID = @FuncionarioID

  
  
  END
  END