USE [A:\УЧЕБА\ADO.NET\HOMEWORK\ADO.NET_HW1\ADO.NET_HW1\APP_DATA\UNIVERSITY.MDF]
GO

/****** Объект: SqlProcedure [dbo].[sp_CreateGroup] Дата скрипта: 14.02.2019 23:55:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CreateGroup]
    @GroupName nvarchar(50),
    @CuratorSurname nvarchar(50),
    @Id int out
AS
    INSERT INTO Groups (GroupName, CuratorSurname)
    VALUES (@GroupName, @CuratorSurname)
  
    SET @Id=SCOPE_IDENTITY()
