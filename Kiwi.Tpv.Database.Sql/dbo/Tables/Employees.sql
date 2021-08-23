CREATE TABLE [dbo].[Employees] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50)    NOT NULL,
    [ImagePath] VARCHAR (100)   NULL,
    [Active]    BIT             NOT NULL,
    [Image]     VARBINARY (MAX) NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([Id] ASC)
);

