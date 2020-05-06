
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/06/2020 22:53:52
-- Generated from EDMX file: D:\Training\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Orarend_DAL_Konzol\edmOrarendek.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [D:\Training\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Orarend_DB.mdf];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_enTantargyenBeadando]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[enBeadandok] DROP CONSTRAINT [FK_enTantargyenBeadando];
GO
IF OBJECT_ID(N'[dbo].[FK_enOktatoenTantargy_enOktato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[enOktatoenTantargy] DROP CONSTRAINT [FK_enOktatoenTantargy_enOktato];
GO
IF OBJECT_ID(N'[dbo].[FK_enOktatoenTantargy_enTantargy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[enOktatoenTantargy] DROP CONSTRAINT [FK_enOktatoenTantargy_enTantargy];
GO
IF OBJECT_ID(N'[dbo].[FK_enTanteremenTanora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[enTanorak] DROP CONSTRAINT [FK_enTanteremenTanora];
GO
IF OBJECT_ID(N'[dbo].[FK_enTantargyenTanora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[enTanorak] DROP CONSTRAINT [FK_enTantargyenTanora];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[enTantargyak]', 'U') IS NOT NULL
    DROP TABLE [dbo].[enTantargyak];
GO
IF OBJECT_ID(N'[dbo].[enOktatok]', 'U') IS NOT NULL
    DROP TABLE [dbo].[enOktatok];
GO
IF OBJECT_ID(N'[dbo].[enTantermek]', 'U') IS NOT NULL
    DROP TABLE [dbo].[enTantermek];
GO
IF OBJECT_ID(N'[dbo].[enBeadandok]', 'U') IS NOT NULL
    DROP TABLE [dbo].[enBeadandok];
GO
IF OBJECT_ID(N'[dbo].[enTanorak]', 'U') IS NOT NULL
    DROP TABLE [dbo].[enTanorak];
GO
IF OBJECT_ID(N'[dbo].[enOktatoenTantargy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[enOktatoenTantargy];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'enTantargyak'
CREATE TABLE [dbo].[enTantargyak] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tantargy_neve] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'enOktatok'
CREATE TABLE [dbo].[enOktatok] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Oktato_Neve] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'enTantermek'
CREATE TABLE [dbo].[enTantermek] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tanterem_neve] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'enBeadandok'
CREATE TABLE [dbo].[enBeadandok] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Hatarido] datetime  NOT NULL,
    [Leírás] nvarchar(max)  NOT NULL,
    [Tipus] nvarchar(max)  NOT NULL,
    [enTantargyak_Id] int  NOT NULL
);
GO

-- Creating table 'enTanorak'
CREATE TABLE [dbo].[enTanorak] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tanora_Kezdete] datetime  NOT NULL,
    [Hossza] int  NOT NULL,
    [enTantermek_Id] int  NOT NULL,
    [enTantargyak_Id] int  NOT NULL
);
GO

-- Creating table 'enOktatoenTantargy'
CREATE TABLE [dbo].[enOktatoenTantargy] (
    [enOktatok_Id] int  NOT NULL,
    [enTantargyak_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'enTantargyak'
ALTER TABLE [dbo].[enTantargyak]
ADD CONSTRAINT [PK_enTantargyak]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'enOktatok'
ALTER TABLE [dbo].[enOktatok]
ADD CONSTRAINT [PK_enOktatok]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'enTantermek'
ALTER TABLE [dbo].[enTantermek]
ADD CONSTRAINT [PK_enTantermek]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'enBeadandok'
ALTER TABLE [dbo].[enBeadandok]
ADD CONSTRAINT [PK_enBeadandok]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'enTanorak'
ALTER TABLE [dbo].[enTanorak]
ADD CONSTRAINT [PK_enTanorak]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [enOktatok_Id], [enTantargyak_Id] in table 'enOktatoenTantargy'
ALTER TABLE [dbo].[enOktatoenTantargy]
ADD CONSTRAINT [PK_enOktatoenTantargy]
    PRIMARY KEY CLUSTERED ([enOktatok_Id], [enTantargyak_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [enTantargyak_Id] in table 'enBeadandok'
ALTER TABLE [dbo].[enBeadandok]
ADD CONSTRAINT [FK_enTantargyenBeadando]
    FOREIGN KEY ([enTantargyak_Id])
    REFERENCES [dbo].[enTantargyak]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_enTantargyenBeadando'
CREATE INDEX [IX_FK_enTantargyenBeadando]
ON [dbo].[enBeadandok]
    ([enTantargyak_Id]);
GO

-- Creating foreign key on [enOktatok_Id] in table 'enOktatoenTantargy'
ALTER TABLE [dbo].[enOktatoenTantargy]
ADD CONSTRAINT [FK_enOktatoenTantargy_enOktato]
    FOREIGN KEY ([enOktatok_Id])
    REFERENCES [dbo].[enOktatok]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [enTantargyak_Id] in table 'enOktatoenTantargy'
ALTER TABLE [dbo].[enOktatoenTantargy]
ADD CONSTRAINT [FK_enOktatoenTantargy_enTantargy]
    FOREIGN KEY ([enTantargyak_Id])
    REFERENCES [dbo].[enTantargyak]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_enOktatoenTantargy_enTantargy'
CREATE INDEX [IX_FK_enOktatoenTantargy_enTantargy]
ON [dbo].[enOktatoenTantargy]
    ([enTantargyak_Id]);
GO

-- Creating foreign key on [enTantermek_Id] in table 'enTanorak'
ALTER TABLE [dbo].[enTanorak]
ADD CONSTRAINT [FK_enTanteremenTanora]
    FOREIGN KEY ([enTantermek_Id])
    REFERENCES [dbo].[enTantermek]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_enTanteremenTanora'
CREATE INDEX [IX_FK_enTanteremenTanora]
ON [dbo].[enTanorak]
    ([enTantermek_Id]);
GO

-- Creating foreign key on [enTantargyak_Id] in table 'enTanorak'
ALTER TABLE [dbo].[enTanorak]
ADD CONSTRAINT [FK_enTantargyenTanora]
    FOREIGN KEY ([enTantargyak_Id])
    REFERENCES [dbo].[enTantargyak]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_enTantargyenTanora'
CREATE INDEX [IX_FK_enTantargyenTanora]
ON [dbo].[enTanorak]
    ([enTantargyak_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------