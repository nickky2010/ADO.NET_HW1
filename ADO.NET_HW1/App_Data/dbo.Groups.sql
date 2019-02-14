USE [A:\УЧЕБА\ADO.NET\HOMEWORK\ADO.NET_HW1\ADO.NET_HW1\APP_DATA\UNIVERSITY.MDF]
GO

/****** Объект: Table [dbo].[Groups] Дата скрипта: 14.02.2019 23:55:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Groups] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [GroupName]      NVARCHAR (50) NOT NULL,
    [CuratorSurname] NVARCHAR (50) NOT NULL
);


