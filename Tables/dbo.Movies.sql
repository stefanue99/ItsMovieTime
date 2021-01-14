CREATE TABLE [dbo].[Movies] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (50)  NOT NULL,
    [Year]        INT            NOT NULL,
    [Genre]       NVARCHAR (20)  NOT NULL,
    [Rating]      DECIMAL (18)   NOT NULL,
    [Watched]     BIT            DEFAULT ((0)) NOT NULL,
    [Favorite]    BIT            DEFAULT ((0)) NOT NULL,
    [IMDBLink]    NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

