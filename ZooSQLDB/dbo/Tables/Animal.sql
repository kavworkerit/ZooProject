CREATE TABLE [dbo].[Animal] (
    [Name]         VARCHAR (50)  NOT NULL,
    [From]         VARCHAR (255) NOT NULL,
    [Cost]         FLOAT (53)    NOT NULL,
    [Nickname]     VARCHAR (50)  NOT NULL,
    [Age]          INT           NOT NULL,
    [Height]       INT           NOT NULL,
    [Weight]       INT           NOT NULL,
    [Gender]       VARCHAR (10)  NOT NULL,
    [Reproduction] VARCHAR (50)  NOT NULL,
    [Song]         VARCHAR (255) DEFAULT ('') NOT NULL,
    [ContentType]  VARCHAR (50)  NOT NULL,
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Animal] PRIMARY KEY CLUSTERED ([Id] ASC)
);

