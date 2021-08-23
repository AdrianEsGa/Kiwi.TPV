CREATE TABLE [dbo].[Commands] (
    [Id]         INT      IDENTITY (1, 1) NOT NULL,
    [EmployeeId] INT      NOT NULL,
    [BarTableId] INT      NOT NULL,
    [StationId]  INT      NULL,
    [Date]       DATETIME NOT NULL,
    [Status]     TINYINT  NOT NULL,
    CONSTRAINT [PK_Commands] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Commands_BarTables] FOREIGN KEY ([BarTableId]) REFERENCES [dbo].[BarTables] ([Id]),
    CONSTRAINT [FK_Commands_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([Id]),
    CONSTRAINT [FK_Commands_Stations] FOREIGN KEY ([StationId]) REFERENCES [dbo].[Stations] ([Id])
);

