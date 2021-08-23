CREATE TABLE [dbo].[AppGeneralConfig] (
    [Id]                        INT           IDENTITY (1, 1) NOT NULL,
    [AdminPassword]             VARCHAR (50)  NULL,
    [ProductButtonsDimensions]  INT           NULL,
    [EmployeeButtonsDimensions] INT           NULL,
    [TableButtonsDimensions]    INT           NULL,
    [BackgroundImage]           VARCHAR (100) NULL,
    [SystemJoke]                BIT           NULL,
    [JokeInit]                  TINYINT       NULL,
    [JokeEnd]                   TINYINT       NULL,
    [JokeInterval]              INT           NULL,
    [ShowJokeReport]            BIT           NULL,
    [ServerStationId]           INT           NULL,
    [DbBackupFilePath]          VARCHAR (500) NULL,
    CONSTRAINT [PK_AppGeneralConfig] PRIMARY KEY CLUSTERED ([Id] ASC)
);

