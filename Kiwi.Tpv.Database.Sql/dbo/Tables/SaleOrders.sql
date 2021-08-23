CREATE TABLE [dbo].[SaleOrders] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [StationId]      INT            NOT NULL,
    [Date]           DATETIME       NOT NULL,
    [BarTableId]     INT            NULL,
    [IsPending]      BIT            CONSTRAINT [DF_SaleOrders_Pending] DEFAULT ((0)) NOT NULL,
    [PendingComment] VARCHAR (5000) NULL,
    CONSTRAINT [PK_SaleOrders] PRIMARY KEY CLUSTERED ([Id] ASC)
);

