/****** Object:  ForeignKey [FK_JokeSaleDetails_JokeSales]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSaleDetails_JokeSales]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSaleDetails]'))
ALTER TABLE [dbo].[JokeSaleDetails] DROP CONSTRAINT [FK_JokeSaleDetails_JokeSales]
GO
/****** Object:  ForeignKey [FK_JokeSaleDetails_Products]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSaleDetails_Products]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSaleDetails]'))
ALTER TABLE [dbo].[JokeSaleDetails] DROP CONSTRAINT [FK_JokeSaleDetails_Products]
GO
/****** Object:  ForeignKey [FK_JokeSales_BarTables]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_BarTables]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales] DROP CONSTRAINT [FK_JokeSales_BarTables]
GO
/****** Object:  ForeignKey [FK_JokeSales_Employees]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_Employees]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales] DROP CONSTRAINT [FK_JokeSales_Employees]
GO
/****** Object:  ForeignKey [FK_JokeSales_Stations]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales] DROP CONSTRAINT [FK_JokeSales_Stations]
GO
/****** Object:  ForeignKey [FK_Products_TaxTypes]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Products_TaxTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Products]'))
ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_TaxTypes]
GO
/****** Object:  ForeignKey [FK_SaleDetails_Products]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleDetails_Products]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleDetails]'))
ALTER TABLE [dbo].[SaleDetails] DROP CONSTRAINT [FK_SaleDetails_Products]
GO
/****** Object:  ForeignKey [FK_SaleDetails_Sales]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleDetails_Sales]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleDetails]'))
ALTER TABLE [dbo].[SaleDetails] DROP CONSTRAINT [FK_SaleDetails_Sales]
GO
/****** Object:  ForeignKey [FK_Sales_BarTables]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_BarTables]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK_Sales_BarTables]
GO
/****** Object:  ForeignKey [FK_Sales_Employees]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_Employees]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK_Sales_Employees]
GO
/****** Object:  ForeignKey [FK_Sales_Stations]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK_Sales_Stations]
GO
/****** Object:  Table [dbo].[SaleDetails]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleDetails_Products]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleDetails]'))
ALTER TABLE [dbo].[SaleDetails] DROP CONSTRAINT [FK_SaleDetails_Products]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleDetails_Sales]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleDetails]'))
ALTER TABLE [dbo].[SaleDetails] DROP CONSTRAINT [FK_SaleDetails_Sales]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SaleDetails]') AND type in (N'U'))
DROP TABLE [dbo].[SaleDetails]
GO
/****** Object:  Table [dbo].[JokeSaleDetails]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSaleDetails_JokeSales]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSaleDetails]'))
ALTER TABLE [dbo].[JokeSaleDetails] DROP CONSTRAINT [FK_JokeSaleDetails_JokeSales]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSaleDetails_Products]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSaleDetails]'))
ALTER TABLE [dbo].[JokeSaleDetails] DROP CONSTRAINT [FK_JokeSaleDetails_Products]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JokeSaleDetails]') AND type in (N'U'))
DROP TABLE [dbo].[JokeSaleDetails]
GO
/****** Object:  Table [dbo].[JokeSales]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_BarTables]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales] DROP CONSTRAINT [FK_JokeSales_BarTables]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_Employees]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales] DROP CONSTRAINT [FK_JokeSales_Employees]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales] DROP CONSTRAINT [FK_JokeSales_Stations]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JokeSales]') AND type in (N'U'))
DROP TABLE [dbo].[JokeSales]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Products_TaxTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Products]'))
ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_TaxTypes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_BarTables]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK_Sales_BarTables]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_Employees]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK_Sales_Employees]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK_Sales_Stations]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sales]') AND type in (N'U'))
DROP TABLE [dbo].[Sales]
GO
/****** Object:  Table [dbo].[Stations]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Stations]') AND type in (N'U'))
DROP TABLE [dbo].[Stations]
GO
/****** Object:  Table [dbo].[System]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System]') AND type in (N'U'))
DROP TABLE [dbo].[System]
GO
/****** Object:  Table [dbo].[TaxTypes]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaxTypes]') AND type in (N'U'))
DROP TABLE [dbo].[TaxTypes]
GO
/****** Object:  Table [dbo].[AppGeneralConfig]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AppGeneralConfig]') AND type in (N'U'))
DROP TABLE [dbo].[AppGeneralConfig]
GO
/****** Object:  Table [dbo].[BarTables]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BarTables]') AND type in (N'U'))
DROP TABLE [dbo].[BarTables]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Companies]') AND type in (N'U'))
DROP TABLE [dbo].[Companies]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 08/28/2019 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employees]') AND type in (N'U'))
DROP TABLE [dbo].[Employees]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employees]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ImagePath] [varchar](100) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Companies]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Companies](
	[CompanyId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Cif] [varchar](10) NOT NULL,
	[AppLogo] [varbinary](max) NULL,
	[ReportsLogo] [varbinary](max) NULL,
	[CombinationControl] [bit] NULL,
	[LocalImage] [varbinary](max) NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BarTables]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BarTables]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AppGeneralConfig]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AppGeneralConfig]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AppGeneralConfig](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdminPassword] [varchar](50) NULL,
	[ProductButtonsDimensions] [int] NULL,
	[EmployeeButtonsDimensions] [int] NULL,
	[BackgroundImage] [varchar](100) NULL,
	[SystemJoke] [bit] NULL,
	[JokeInit] [tinyint] NULL,
	[JokeEnd] [tinyint] NULL,
	[JokeInterval] [int] NULL,
	[ShowJokeReport] [bit] NULL,
 CONSTRAINT [PK_AppGeneralConfig] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaxTypes]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaxTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TaxTypes](
	[Percentaje] [float] NOT NULL,
 CONSTRAINT [PK_TaxTypes] PRIMARY KEY CLUSTERED 
(
	[Percentaje] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[System]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NULL,
	[Binary] [varbinary](max) NULL,
 CONSTRAINT [PK_System] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stations]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Stations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Stations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[PrintterComPort] [varchar](50) NULL,
 CONSTRAINT [PK_Stations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Stations_Code] UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Sales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StationId] [int] NOT NULL,
	[EmployeeId] [int] NULL,
	[Date] [datetime] NOT NULL,
	[Total] [money] NOT NULL,
	[Disscount] [money] NOT NULL,
	[Tax] [money] NULL,
	[PayType] [int] NULL,
	[BarTableId] [int] NULL,
	[Paid] [bit] NULL,
	[Ticket] [bit] NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Products]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Type] [int] NOT NULL,
	[SubType] [int] NULL,
	[ImagePath] [varchar](100) NULL,
	[SalePrice] [money] NOT NULL,
	[SaleTaxPercentaje] [float] NULL,
	[SaleUnits] [float] NULL,
	[PurchasePrice] [money] NULL,
	[PurchaseTaxPercentaje] [float] NULL,
	[PurchaseUnits] [float] NULL,
	[Active] [bit] NOT NULL,
	[SaleDayPrice] [money] NOT NULL,
	[ShowInMainView] [bit] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JokeSales]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JokeSales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[JokeSales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StationId] [int] NOT NULL,
	[EmployeeId] [int] NULL,
	[Date] [datetime] NOT NULL,
	[Total] [money] NOT NULL,
	[Disscount] [money] NOT NULL,
	[Tax] [money] NULL,
	[PayType] [int] NULL,
	[BarTableId] [int] NULL,
	[Paid] [bit] NULL,
	[Ticket] [bit] NULL,
 CONSTRAINT [PK_JokeSales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[JokeSaleDetails]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JokeSaleDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[JokeSaleDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[IsBottle] [bit] NULL,
	[SubTotal] [money] NULL,
	[TaxPercentaje] [float] NULL,
	[Tax] [money] NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_JokeSaleDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[SaleDetails]    Script Date: 08/28/2019 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SaleDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SaleDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[IsBottle] [bit] NULL,
	[SubTotal] [money] NULL,
	[TaxPercentaje] [float] NULL,
	[Tax] [money] NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_SaleDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  ForeignKey [FK_JokeSaleDetails_JokeSales]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSaleDetails_JokeSales]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSaleDetails]'))
ALTER TABLE [dbo].[JokeSaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_JokeSaleDetails_JokeSales] FOREIGN KEY([SaleId])
REFERENCES [dbo].[JokeSales] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSaleDetails_JokeSales]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSaleDetails]'))
ALTER TABLE [dbo].[JokeSaleDetails] CHECK CONSTRAINT [FK_JokeSaleDetails_JokeSales]
GO
/****** Object:  ForeignKey [FK_JokeSaleDetails_Products]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSaleDetails_Products]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSaleDetails]'))
ALTER TABLE [dbo].[JokeSaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_JokeSaleDetails_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSaleDetails_Products]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSaleDetails]'))
ALTER TABLE [dbo].[JokeSaleDetails] CHECK CONSTRAINT [FK_JokeSaleDetails_Products]
GO
/****** Object:  ForeignKey [FK_JokeSales_BarTables]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_BarTables]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales]  WITH CHECK ADD  CONSTRAINT [FK_JokeSales_BarTables] FOREIGN KEY([BarTableId])
REFERENCES [dbo].[BarTables] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_BarTables]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales] CHECK CONSTRAINT [FK_JokeSales_BarTables]
GO
/****** Object:  ForeignKey [FK_JokeSales_Employees]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_Employees]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales]  WITH CHECK ADD  CONSTRAINT [FK_JokeSales_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_Employees]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales] CHECK CONSTRAINT [FK_JokeSales_Employees]
GO
/****** Object:  ForeignKey [FK_JokeSales_Stations]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales]  WITH CHECK ADD  CONSTRAINT [FK_JokeSales_Stations] FOREIGN KEY([StationId])
REFERENCES [dbo].[Stations] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JokeSales_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[JokeSales]'))
ALTER TABLE [dbo].[JokeSales] CHECK CONSTRAINT [FK_JokeSales_Stations]
GO
/****** Object:  ForeignKey [FK_Products_TaxTypes]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Products_TaxTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Products]'))
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_TaxTypes] FOREIGN KEY([SaleTaxPercentaje])
REFERENCES [dbo].[TaxTypes] ([Percentaje])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Products_TaxTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Products]'))
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_TaxTypes]
GO
/****** Object:  ForeignKey [FK_SaleDetails_Products]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleDetails_Products]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleDetails]'))
ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetails_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleDetails_Products]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleDetails]'))
ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK_SaleDetails_Products]
GO
/****** Object:  ForeignKey [FK_SaleDetails_Sales]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleDetails_Sales]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleDetails]'))
ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetails_Sales] FOREIGN KEY([SaleId])
REFERENCES [dbo].[Sales] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleDetails_Sales]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleDetails]'))
ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK_SaleDetails_Sales]
GO
/****** Object:  ForeignKey [FK_Sales_BarTables]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_BarTables]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_BarTables] FOREIGN KEY([BarTableId])
REFERENCES [dbo].[BarTables] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_BarTables]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_BarTables]
GO
/****** Object:  ForeignKey [FK_Sales_Employees]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_Employees]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_Employees]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Employees]
GO
/****** Object:  ForeignKey [FK_Sales_Stations]    Script Date: 08/28/2019 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Stations] FOREIGN KEY([StationId])
REFERENCES [dbo].[Stations] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_Stations]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Stations]
GO
