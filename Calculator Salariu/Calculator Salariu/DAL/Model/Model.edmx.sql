
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/04/2018 16:43:47
-- Generated from EDMX file: E:\Radu\Faculta\Anul 4\TPBD\tpbd-exam\Calculator Salariu\Calculator Salariu\DAL\Model\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TPBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Salariati]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Salariati];
GO
IF OBJECT_ID(N'[dbo].[Parametrii]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parametrii];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Salariati'
CREATE TABLE [dbo].[Salariati] (
    [Nr_crt] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(max)  NOT NULL,
    [Prenume] nvarchar(max)  NOT NULL,
    [Functie] nvarchar(max)  NULL,
    [SalariuBaza] int  NOT NULL,
    [ProcentSpor] int  NOT NULL,
    [PremiiBrute] int  NOT NULL,
    [TotalBrut] int  NULL,
    [BrutImpozabil] int  NULL,
    [Impozit] int  NULL,
    [CAS] int  NULL,
    [CASS] int  NULL,
    [Retineri] int  NOT NULL,
    [ViratCard] int  NULL,
    [Imagine] varbinary(max)  NULL
);
GO

-- Creating table 'Parametrii'
CREATE TABLE [dbo].[Parametrii] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CAS] float  NOT NULL,
    [CASS] float  NOT NULL,
    [Impozit] float  NOT NULL,
    [Parola] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Nr_crt] in table 'Salariati'
ALTER TABLE [dbo].[Salariati]
ADD CONSTRAINT [PK_Salariati]
    PRIMARY KEY CLUSTERED ([Nr_crt] ASC);
GO

-- Creating primary key on [Id] in table 'Parametrii'
ALTER TABLE [dbo].[Parametrii]
ADD CONSTRAINT [PK_Parametrii]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------