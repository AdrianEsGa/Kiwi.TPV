CREATE TABLE [dbo].[SaleDetails] (
    [Id]            INT        IDENTITY (1, 1) NOT NULL,
    [SaleId]        INT        NOT NULL,
    [ProductId]     INT        NOT NULL,
    [Quantity]      INT        NOT NULL,
    [Price]         MONEY      NOT NULL,
    [IsBottle]      BIT        NULL,
    [SubTotal]      MONEY      NULL,
    [TaxPercentaje] FLOAT (53) NULL,
    [Tax]           MONEY      NULL,
    [Total]         MONEY      NULL,
    CONSTRAINT [PK_SaleDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SaleDetails_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]),
    CONSTRAINT [FK_SaleDetails_Sales] FOREIGN KEY ([SaleId]) REFERENCES [dbo].[Sales] ([Id])
);

