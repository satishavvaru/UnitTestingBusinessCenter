
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/08/2015 15:42:19
-- Generated from EDMX file: E:\DCBusinessCenter\BusinessCenter.Data\BussinessCenterDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BussinessCenter];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_UserClaim_dbo_User_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserClaim] DROP CONSTRAINT [FK_dbo_UserClaim_dbo_User_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UserLogin_dbo_User_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserLogin] DROP CONSTRAINT [FK_dbo_UserLogin_dbo_User_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UserRole_dbo_Role_RoleId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserRole] DROP CONSTRAINT [FK_dbo_UserRole_dbo_Role_RoleId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UserRole_dbo_User_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserRole] DROP CONSTRAINT [FK_dbo_UserRole_dbo_User_UserId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Role];
GO
IF OBJECT_ID(N'[dbo].[SchemaVersions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SchemaVersions];
GO
IF OBJECT_ID(N'[dbo].[SecurityQuestion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SecurityQuestion];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[UserClaim]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserClaim];
GO
IF OBJECT_ID(N'[dbo].[UserLogin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserLogin];
GO
IF OBJECT_ID(N'[dbo].[UserRole]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserRole];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'Role'
CREATE TABLE [dbo].[Role] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'SchemaVersions'
CREATE TABLE [dbo].[SchemaVersions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ScriptName] nvarchar(255)  NOT NULL,
    [Applied] datetime  NOT NULL
);
GO

-- Creating table 'SecurityQuestion'
CREATE TABLE [dbo].[SecurityQuestion] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(50)  NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Address] nvarchar(max)  NULL,
    [City] nvarchar(max)  NULL,
    [FirstName] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NULL,
    [MobileNumber] nvarchar(max)  NULL,
    [PostalCode] nvarchar(max)  NULL,
    [State] nvarchar(max)  NULL,
    [LastLoginDateandTime] datetime  NULL,
    [IsActive] bit  NOT NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [ActivationCode] nvarchar(max)  NULL,
    [Password] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [SecurityQuestion1] nvarchar(200)  NULL,
    [SecurityQuestion2] nvarchar(200)  NULL,
    [SecurityQuestion3] nvarchar(200)  NULL,
    [SecurityAnswer1] nvarchar(500)  NULL,
    [SecurityAnswer2] nvarchar(500)  NULL,
    [SecurityAnswer3] nvarchar(500)  NULL,
    [Title] nvarchar(50)  NULL,
    [ActivationDate] datetime  NULL
);
GO

-- Creating table 'UserClaim'
CREATE TABLE [dbo].[UserClaim] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'UserLogin'
CREATE TABLE [dbo].[UserLogin] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'UserRole'
CREATE TABLE [dbo].[UserRole] (
    [Role_Id] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Id] in table 'Role'
ALTER TABLE [dbo].[Role]
ADD CONSTRAINT [PK_Role]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SchemaVersions'
ALTER TABLE [dbo].[SchemaVersions]
ADD CONSTRAINT [PK_SchemaVersions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'SecurityQuestion'
ALTER TABLE [dbo].[SecurityQuestion]
ADD CONSTRAINT [PK_SecurityQuestion]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserClaim'
ALTER TABLE [dbo].[UserClaim]
ADD CONSTRAINT [PK_UserClaim]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'UserLogin'
ALTER TABLE [dbo].[UserLogin]
ADD CONSTRAINT [PK_UserLogin]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Role_Id], [User_Id] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [PK_UserRole]
    PRIMARY KEY CLUSTERED ([Role_Id], [User_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'UserClaim'
ALTER TABLE [dbo].[UserClaim]
ADD CONSTRAINT [FK_dbo_UserClaim_dbo_User_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UserClaim_dbo_User_UserId'
CREATE INDEX [IX_FK_dbo_UserClaim_dbo_User_UserId]
ON [dbo].[UserClaim]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserLogin'
ALTER TABLE [dbo].[UserLogin]
ADD CONSTRAINT [FK_dbo_UserLogin_dbo_User_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UserLogin_dbo_User_UserId'
CREATE INDEX [IX_FK_dbo_UserLogin_dbo_User_UserId]
ON [dbo].[UserLogin]
    ([UserId]);
GO

-- Creating foreign key on [Role_Id] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [FK_UserRole_Role]
    FOREIGN KEY ([Role_Id])
    REFERENCES [dbo].[Role]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [User_Id] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [FK_UserRole_User]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserRole_User'
CREATE INDEX [IX_FK_UserRole_User]
ON [dbo].[UserRole]
    ([User_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------