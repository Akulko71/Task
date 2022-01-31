USE [TaskDB]
GO

/****** Объект: SqlProcedure [dbo].[NameStatus] Дата скрипта: 31.01.2022 15:14:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NameStatus] 
@numerStatus int
AS
	SELECT * FROM [dbo].[status] WHERE @numerStatus = id
