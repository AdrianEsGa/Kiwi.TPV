CREATE TABLE [dbo].[CommandDetails] (
    [Id]                INT IDENTITY (1, 1) NOT NULL,
    [CommandId]         INT NOT NULL,
    [ProductId]         INT NOT NULL,
    [Quantity]          INT NOT NULL,
    [CombinedProductId] INT NULL,
    CONSTRAINT [PK_CommandDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CommandDetails_Commands] FOREIGN KEY ([CommandId]) REFERENCES [dbo].[Commands] ([Id]),
    CONSTRAINT [FK_CommandDetails_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]),
    CONSTRAINT [FK_CommandDetails_Products1] FOREIGN KEY ([CombinedProductId]) REFERENCES [dbo].[Products] ([Id])
);

