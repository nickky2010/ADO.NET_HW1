USE [A:\УЧЕБА\ADO.NET\HOMEWORK\ADO.NET_HW1\ADO.NET_HW1\APP_DATA\UNIVERSITY.MDF]
GO

/****** Объект: Table [dbo].[Students] Дата скрипта: 14.02.2019 23:55:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Students] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [IdGroup]         INT           NOT NULL,
    [Surname]         NVARCHAR (50) NOT NULL,
    [MarkByOOP]       INT           NOT NULL,
    [MarkByWinForms]  INT           NOT NULL,
    [MarkByADOdotNET] INT           NOT NULL
);


