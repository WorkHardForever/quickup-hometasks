CREATE DATABASE [Animals]
GO

USE [Animals]
GO

CREATE TABLE [Bird] (
    [BirdId] int NOT NULL IDENTITY,
    [Description] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Bird] PRIMARY KEY ([BirdId])
);
GO

CREATE TABLE [Dove] (
    [DoveId] int NOT NULL IDENTITY,
    [BirdId] int NOT NULL,
    [Name] nvarchar(max),
    CONSTRAINT [PK_Dove] PRIMARY KEY ([DoveId]),
    CONSTRAINT [FK_Dove_Bird_BirdId] FOREIGN KEY ([BirdId]) REFERENCES [Bird] ([BirdId]) ON DELETE CASCADE
);
GO

INSERT INTO [Bird] (Description) VALUES 
('Dove1'), 
('Dove2'), 
('Dove3')
GO
