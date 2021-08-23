CREATE TABLE [dbo].[Sales] (
    [Id]         INT      IDENTITY (1, 1) NOT NULL,
    [StationId]  INT      NOT NULL,
    [EmployeeId] INT      NOT NULL,
    [Date]       DATETIME NOT NULL,
    [Total]      MONEY    NOT NULL,
    [Disscount]  MONEY    NOT NULL,
    [Tax]        MONEY    NULL,
    [PayType]    INT      NULL,
    [BarTableId] INT      NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sales_BarTables] FOREIGN KEY ([BarTableId]) REFERENCES [dbo].[BarTables] ([Id]),
    CONSTRAINT [FK_Sales_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([Id]),
    CONSTRAINT [FK_Sales_Stations] FOREIGN KEY ([StationId]) REFERENCES [dbo].[Stations] ([Id])
);

