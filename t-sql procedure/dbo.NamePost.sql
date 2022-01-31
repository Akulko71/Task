USE [TaskDB]
GO

/****** Объект: SqlProcedure [dbo].[NamePost] Дата скрипта: 31.01.2022 15:14:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NamePost] 
@numerPost int
AS
	SELECT * FROM [dbo].[posts] WHERE @numerPost = id
