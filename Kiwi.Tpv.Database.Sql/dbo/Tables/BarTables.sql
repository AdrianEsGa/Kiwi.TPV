CREATE TABLE [dbo].[BarTables] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Code]      INT           NOT NULL,
    [Name]      VARCHAR (50)  NOT NULL,
    [ImagePath] VARCHAR (200) NULL,
    [Location]  VARCHAR (10)  NULL,
    [Active]    BIT           NOT NULL,
    [Type]      TINYINT       CONSTRAINT [DF_BarTables_Type] DEFAULT ((2)) NOT NULL,
    CONSTRAINT [PK_BarTables] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UQ_Code_Type] UNIQUE NONCLUSTERED ([Code] ASC, [Type] ASC)
);

