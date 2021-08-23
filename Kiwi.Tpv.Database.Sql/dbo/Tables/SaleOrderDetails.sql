CREATE TABLE [dbo].[SaleOrderDetails] (
    [Id]            INT        IDENTITY (1, 1) NOT NULL,
    [SaleOrderId]   INT        NOT NULL,
    [ProductId]     INT        NOT NULL,
    [Quantity]      INT        NOT NULL,
    [TaxPercentaje] FLOAT (53) NOT NULL,
    [Price]         MONEY      NOT NULL,
    [IsBottle]      BIT        NOT NULL,
    CONSTRAINT [PK_SaleOrderDetails] PRIMARY KEY CLUSTERED ([Id] ASC)
);

