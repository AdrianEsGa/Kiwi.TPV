-- DB CHANGES VERSION 6.0 --
----------------------------

/****** Object:  Table [dbo].[SaleOrders]    Script Date: 13/12/2019 18:22:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SaleOrders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StationId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[BarTableId] [int] NULL,
 CONSTRAINT [PK_SaleOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[SaleOrderDetails]    Script Date: 13/12/2019 18:23:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SaleOrderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleOrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[TaxPercentaje] [float] NOT NULL,
	[Price] [money] NOT NULL,
	[IsBottle] [bit] NOT NULL,
 CONSTRAINT [PK_SaleOrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Sales
	DROP COLUMN Paid, Ticket
GO
ALTER TABLE dbo.Sales SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

GO

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Sales
	DROP CONSTRAINT FK_Sales_Stations
GO
ALTER TABLE dbo.Stations SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Sales
	DROP CONSTRAINT FK_Sales_Employees
GO
ALTER TABLE dbo.Employees SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Sales
	DROP CONSTRAINT FK_Sales_BarTables
GO
ALTER TABLE dbo.BarTables SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Sales
	(
	Id int NOT NULL IDENTITY (1, 1),
	StationId int NOT NULL,
	EmployeeId int NOT NULL,
	Date datetime NOT NULL,
	Total money NOT NULL,
	Disscount money NOT NULL,
	Tax money NULL,
	PayType int NULL,
	BarTableId int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Sales SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Sales ON
GO
IF EXISTS(SELECT * FROM dbo.Sales)
	 EXEC('INSERT INTO dbo.Tmp_Sales (Id, StationId, EmployeeId, Date, Total, Disscount, Tax, PayType, BarTableId)
		SELECT Id, StationId, EmployeeId, Date, Total, Disscount, Tax, PayType, BarTableId FROM dbo.Sales WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Sales OFF
GO
ALTER TABLE dbo.SaleDetails
	DROP CONSTRAINT FK_SaleDetails_Sales
GO
DROP TABLE dbo.Sales
GO
EXECUTE sp_rename N'dbo.Tmp_Sales', N'Sales', 'OBJECT' 
GO
ALTER TABLE dbo.Sales ADD CONSTRAINT
	PK_Sales PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Sales ADD CONSTRAINT
	FK_Sales_BarTables FOREIGN KEY
	(
	BarTableId
	) REFERENCES dbo.BarTables
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Sales ADD CONSTRAINT
	FK_Sales_Employees FOREIGN KEY
	(
	EmployeeId
	) REFERENCES dbo.Employees
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Sales ADD CONSTRAINT
	FK_Sales_Stations FOREIGN KEY
	(
	StationId
	) REFERENCES dbo.Stations
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.SaleDetails ADD CONSTRAINT
	FK_SaleDetails_Sales FOREIGN KEY
	(
	SaleId
	) REFERENCES dbo.Sales
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.SaleDetails SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.BarTables ADD
	Type tinyint NOT NULL CONSTRAINT DF_BarTables_Type DEFAULT 2
GO
ALTER TABLE dbo.BarTables SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

---------------------------------------------------------------------------------------------------
declare @name as varchar(500)
DECLARE @SQL AS VARCHAR (1000)
select @name = c.name 
from sys.key_constraints as c inner join sys.objects as o on c.parent_object_id = o.object_id
where c.type = 'UQ' and o.name = 'BarTables'

SET @SQL= 'ALTER TABLE BARTABLES DROP CONSTRAINT '+ @name
EXEC (@SQL)

ALTER TABLE BarTables  
ADD CONSTRAINT UQ_Code_Type UNIQUE (Code, Type); 
--------------------------------------------------------------------------------------------------------


/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Companies ADD
	CombinationControlWithSoda bit NOT NULL CONSTRAINT DF_Companies_CombinationControlWithSoda DEFAULT 0
GO
ALTER TABLE dbo.Companies SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
