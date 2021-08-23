CREATE TABLE [dbo].[Stations] (
    [Id]                  INT          IDENTITY (1, 1) NOT NULL,
    [Code]                INT          NOT NULL,
    [Name]                VARCHAR (50) NOT NULL,
    [PrintterComPort]     VARCHAR (50) NULL,
    [ShowSaleOrderTicket] BIT          CONSTRAINT [DF_Stations_ShowOrderSaleTicket] DEFAULT ((0)) NOT NULL,
    [ShowAnimations]      BIT          CONSTRAINT [DF_Stations_ShowAnimations] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Stations] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UQ_Stations_Code] UNIQUE NONCLUSTERED ([Code] ASC)
);

