USE [Cadastro]
GO
/****** Object:  StoredProcedure [dbo].[FuncionarioDeleteByID]    Script Date: 4/13/2020 10:45:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 ALTER PROC [dbo].[FuncionarioDeleteByID]
 @FuncionarioID int
 AS BEGIN
 DELETE FROM Funcionarios
 WHEre FuncionarioID = @FuncionarioID

END

