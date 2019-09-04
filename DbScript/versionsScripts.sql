BEGIN TRAN
-------------------------------------

ALTER TABLE Products ADD PurchaseUnits FLOAT 
GO
ALTER TABLE Products ADD SaleUnits FLOAT 
GO
UPDATE Products SET PurchaseUnits = 1, SaleUnits = 1
GO
ALTER TABLE Products ADD SubType INT NULL
GO
UPDATE Products SET SubType = 9999 
GO
ALTER TABLE Companies ADD CombinationControl BIT
GO
UPDATE Companies SET CombinationControl = 0
GO

/****** Object:  Table [dbo].[Tables]    Script Date: 05/15/2019 19:05:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[BarTables](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ImagePath] [varchar](200) NULL,
	[Location] [varchar](10) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_BarTables] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
ALTER TABLE BarTables
ADD UNIQUE ([Code])
GO
ALTER TABLE Companies ADD LocalImage VARBINARY(MAX)
GO
ALTER TABLE Sales
ALTER COLUMN EmployeeId INT NULL
GO
ALTER TABLE Sales ADD BarTableId INT NULL
GO
ALTER TABLE Sales ADD Paid BIT
GO
UPDATE Sales SET Paid = 1
GO
ALTER TABLE Sales ADD Ticket BIT
GO
UPDATE Sales SET Ticket = 0
GO
ALTER TABLE JokeSales
ALTER COLUMN EmployeeId INT NULL
GO
ALTER TABLE JokeSales ADD BarTableId INT NULL
GO
ALTER TABLE JokeSales ADD Paid BIT
GO
UPDATE JokeSales SET Paid = 1
GO
ALTER TABLE JokeSales ADD Ticket BIT
GO
UPDATE JokeSales SET Ticket = 0
GO
ALTER TABLE Products ADD SaleDayPrice MONEY
GO
UPDATE Products SET SaleDayPrice = SalePrice
GO
ALTER TABLE Products ALTER COLUMN SaleDayPrice MONEY NOT NULL
GO
ALTER TABLE Products ADD ShowInMainView BIT
GO 
UPDATE Products SET ShowInMainView = 1 WHERE Type IN (1,2,3)
GO
UPDATE Products SET ShowInMainView = 0 WHERE Type IN (4,6,7,8,9,10)



-------------------------------------------------------------------------------
-- New -- Hasta aqui Licuore Bay ----
--------------------------------------------------------
GO
ALTER TABLE AppGeneralConfig ADD TableButtonsDimensions INT
GO
UPDATE AppGeneralConfig SET TableButtonsDimensions = 70
GO
ALTER TABLE Employees ADD Image VARBINARY(MAX)
GO
ALTER TABLE Products ADD Image VARBINARY(MAX)