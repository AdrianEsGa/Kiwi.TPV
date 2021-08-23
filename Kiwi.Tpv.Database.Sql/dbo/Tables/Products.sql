CREATE TABLE [dbo].[Products] (
    [Id]                    INT             IDENTITY (1, 1) NOT NULL,
    [Name]                  VARCHAR (50)    NOT NULL,
    [Type]                  INT             NOT NULL,
    [SubType]               INT             NULL,
    [SalePrice]             MONEY           NOT NULL,
    [SaleTaxPercentaje]     FLOAT (53)      NULL,
    [SaleUnits]             FLOAT (53)      NULL,
    [PurchasePrice]         MONEY           NULL,
    [PurchaseTaxPercentaje] FLOAT (53)      NULL,
    [PurchaseUnits]         FLOAT (53)      NULL,
    [Active]                BIT             NOT NULL,
    [SaleDayPrice]          MONEY           NOT NULL,
    [ShowInMainView]        BIT             NULL,
    [Image]                 VARBINARY (MAX) NULL,
    [SaleCupDayPrice]       MONEY           NULL,
    [SaleCupNightPrice]     MONEY           NULL,
    [SaleShotDayPrice]      MONEY           NULL,
    [SaleShotNightPrice]    MONEY           DEFAULT ((0)) NULL,
    [SaleCombinedPrice]     MONEY           NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Products_TaxTypes] FOREIGN KEY ([SaleTaxPercentaje]) REFERENCES [dbo].[TaxTypes] ([Percentaje])
);

