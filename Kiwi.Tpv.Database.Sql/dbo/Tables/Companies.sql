CREATE TABLE [dbo].[Companies] (
    [CompanyId]                  INT             NOT NULL,
    [Name]                       VARCHAR (50)    NOT NULL,
    [Cif]                        VARCHAR (10)    NOT NULL,
    [AppLogo]                    VARBINARY (MAX) NULL,
    [ReportsLogo]                VARBINARY (MAX) NULL,
    [CombinationControl]         BIT             NULL,
    [LocalImage]                 VARBINARY (MAX) NULL,
    [TicketReport]               VARCHAR (200)   NULL,
    [CombinationControlWithSoda] BIT             CONSTRAINT [DF_Companies_CombinationControlWithSoda] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED ([CompanyId] ASC)
);

