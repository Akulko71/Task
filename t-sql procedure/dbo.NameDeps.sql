USE [TaskDB]
GO

/****** Объект: SqlProcedure [dbo].[NameDeps] Дата скрипта: 31.01.2022 15:13:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NameDeps] 
@numerDeps int
AS
	SELECT * FROM [dbo].[deps] WHERE @numerDeps = id
