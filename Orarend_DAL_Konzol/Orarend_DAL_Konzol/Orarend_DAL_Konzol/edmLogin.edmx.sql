
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/09/2020 01:01:10
-- Generated from EDMX file: D:\Training\timetable_exam\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Orarend_DAL_Konzol\edmLogin.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [D:\Training\timetable_exam\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Login.mdf];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[edmLoginok]', 'U') IS NOT NULL
    DROP TABLE [dbo].[edmLoginok];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'edmLoginok'
CREATE TABLE [dbo].[edmLoginok] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'edmLoginok'
ALTER TABLE [dbo].[edmLoginok]
ADD CONSTRAINT [PK_edmLoginok]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------