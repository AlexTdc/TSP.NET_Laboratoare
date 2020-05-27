
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/01/2020 12:18:30
-- Generated from EDMX file: C:\Users\ALEXANDRU\source\repos\Model\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotosDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PhotosVideosPlace]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosVideosSet] DROP CONSTRAINT [FK_PhotosVideosPlace];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosVideosPerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet] DROP CONSTRAINT [FK_PhotosVideosPerson];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PhotosVideosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotosVideosSet];
GO
IF OBJECT_ID(N'[dbo].[PersonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet];
GO
IF OBJECT_ID(N'[dbo].[PlaceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlaceSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PhotosVideosSet'
CREATE TABLE [dbo].[PhotosVideosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CreateDate] bit  NULL,
    [Path] nvarchar(max)  NULL,
    [About] nvarchar(max)  NOT NULL,
    [Place_Id] int  NOT NULL
);
GO

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PhotosVideosId] int  NOT NULL
);
GO

-- Creating table 'PlaceSet'
CREATE TABLE [dbo].[PlaceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PhotosVideosSet'
ALTER TABLE [dbo].[PhotosVideosSet]
ADD CONSTRAINT [PK_PhotosVideosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PlaceSet'
ALTER TABLE [dbo].[PlaceSet]
ADD CONSTRAINT [PK_PlaceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Place_Id] in table 'PhotosVideosSet'
ALTER TABLE [dbo].[PhotosVideosSet]
ADD CONSTRAINT [FK_PhotosVideosPlace]
    FOREIGN KEY ([Place_Id])
    REFERENCES [dbo].[PlaceSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosVideosPlace'
CREATE INDEX [IX_FK_PhotosVideosPlace]
ON [dbo].[PhotosVideosSet]
    ([Place_Id]);
GO

-- Creating foreign key on [PhotosVideosId] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [FK_PhotosVideosPerson]
    FOREIGN KEY ([PhotosVideosId])
    REFERENCES [dbo].[PhotosVideosSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosVideosPerson'
CREATE INDEX [IX_FK_PhotosVideosPerson]
ON [dbo].[PersonSet]
    ([PhotosVideosId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------