USE [Cadastro]
GO
/****** Object:  StoredProcedure [dbo].[FuncionarioViewAllOrSearch]    Script Date: 4/13/2020 10:45:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER  PROC [dbo].[FuncionarioViewAllOrSearch]
 @PesquisaText VARCHAR (100)
AS BEGIN
SELECT *
FROM Funcionarios
WHERE @PesquisaText ='' OR
NOME LIKE '%' +@PesquisaText+'%'
END