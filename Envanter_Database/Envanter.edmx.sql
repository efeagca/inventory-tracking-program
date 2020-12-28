
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/25/2019 19:52:42
-- Generated from EDMX file: C:\Users\asus\source\repos\Envanter_Database\Envanter_Database\Envanter.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EnvanterTakip];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KULLANICISet'
CREATE TABLE [dbo].[KULLANICISet] (
    [KullaniciID] int IDENTITY(1,1) NOT NULL,
    [KullaniciAdi] nvarchar(max)  NOT NULL,
    [Sifre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SUBESet1'
CREATE TABLE [dbo].[SUBESet1] (
    [SubeId] int IDENTITY(1,1) NOT NULL,
    [SubeAdi] nvarchar(max)  NOT NULL,
    [KullaniciID] int  NOT NULL
);
GO

-- Creating table 'URUNSet1'
CREATE TABLE [dbo].[URUNSet1] (
    [Barkod] int IDENTITY(1,1) NOT NULL,
    [UrunAdi] nvarchar(max)  NOT NULL,
    [UrunCinsi] nvarchar(max)  NOT NULL,
    [Birim] nvarchar(max)  NOT NULL,
    [Stok] int  NOT NULL,
    [Birim_Fiyat] float  NOT NULL,
    [Aciklama1] nvarchar(max)  NULL,
    [Aciklama2] nvarchar(max)  NULL,
    [Kritik_Stok_Seviyesi] int  NULL,
    [SubeId] int  NOT NULL,
    [KullaniciID] int  NOT NULL
);
GO

-- Creating table 'SATISSet'
CREATE TABLE [dbo].[SATISSet] (
    [SatisId] int IDENTITY(1,1) NOT NULL,
    [Barkod] int  NOT NULL,
    [Miktar] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [SubeId] int  NOT NULL,
    [KullaniciID] int  NOT NULL
);
GO

-- Creating table 'ALIMSet'
CREATE TABLE [dbo].[ALIMSet] (
    [AlimID] int IDENTITY(1,1) NOT NULL,
    [Barkod] int  NOT NULL,
    [Miktar] int  NOT NULL,
    [Birim_Alis_Fiyati] float  NOT NULL,
    [Date] datetime  NOT NULL,
    [SubeId] int  NOT NULL,
    [KullaniciID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [KullaniciID] in table 'KULLANICISet'
ALTER TABLE [dbo].[KULLANICISet]
ADD CONSTRAINT [PK_KULLANICISet]
    PRIMARY KEY CLUSTERED ([KullaniciID] ASC);
GO

-- Creating primary key on [SubeId], [KullaniciID] in table 'SUBESet1'
ALTER TABLE [dbo].[SUBESet1]
ADD CONSTRAINT [PK_SUBESet1]
    PRIMARY KEY CLUSTERED ([SubeId], [KullaniciID] ASC);
GO

-- Creating primary key on [Barkod], [SubeId], [KullaniciID] in table 'URUNSet1'
ALTER TABLE [dbo].[URUNSet1]
ADD CONSTRAINT [PK_URUNSet1]
    PRIMARY KEY CLUSTERED ([Barkod], [SubeId], [KullaniciID] ASC);
GO

-- Creating primary key on [SatisId] in table 'SATISSet'
ALTER TABLE [dbo].[SATISSet]
ADD CONSTRAINT [PK_SATISSet]
    PRIMARY KEY CLUSTERED ([SatisId] ASC);
GO

-- Creating primary key on [AlimID] in table 'ALIMSet'
ALTER TABLE [dbo].[ALIMSet]
ADD CONSTRAINT [PK_ALIMSet]
    PRIMARY KEY CLUSTERED ([AlimID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [KullaniciID] in table 'SUBESet1'
ALTER TABLE [dbo].[SUBESet1]
ADD CONSTRAINT [FK_SAHIP]
    FOREIGN KEY ([KullaniciID])
    REFERENCES [dbo].[KULLANICISet]
        ([KullaniciID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAHIP'
CREATE INDEX [IX_FK_SAHIP]
ON [dbo].[SUBESet1]
    ([KullaniciID]);
GO

-- Creating foreign key on [SubeId], [KullaniciID] in table 'URUNSet1'
ALTER TABLE [dbo].[URUNSet1]
ADD CONSTRAINT [FK_SubeUrun]
    FOREIGN KEY ([SubeId], [KullaniciID])
    REFERENCES [dbo].[SUBESet1]
        ([SubeId], [KullaniciID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubeUrun'
CREATE INDEX [IX_FK_SubeUrun]
ON [dbo].[URUNSet1]
    ([SubeId], [KullaniciID]);
GO

-- Creating foreign key on [SubeId], [KullaniciID] in table 'ALIMSet'
ALTER TABLE [dbo].[ALIMSet]
ADD CONSTRAINT [FK_SUBEALIM]
    FOREIGN KEY ([SubeId], [KullaniciID])
    REFERENCES [dbo].[SUBESet1]
        ([SubeId], [KullaniciID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SUBEALIM'
CREATE INDEX [IX_FK_SUBEALIM]
ON [dbo].[ALIMSet]
    ([SubeId], [KullaniciID]);
GO

-- Creating foreign key on [SubeId], [KullaniciID] in table 'SATISSet'
ALTER TABLE [dbo].[SATISSet]
ADD CONSTRAINT [FK_SUBESATIS]
    FOREIGN KEY ([SubeId], [KullaniciID])
    REFERENCES [dbo].[SUBESet1]
        ([SubeId], [KullaniciID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SUBESATIS'
CREATE INDEX [IX_FK_SUBESATIS]
ON [dbo].[SATISSet]
    ([SubeId], [KullaniciID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------