using System;
using System.Data.SqlClient;

namespace Kiwi.Tpv.Database.Repositories
{
    public static class DbManagementRepository
    {

        public static string CreateJokeTablesSql =
            "SET ANSI_NULLS ON\r\nSET QUOTED_IDENTIFIER ON\r\nCREATE TABLE [dbo].[JokeSales](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[StationId] [int] NOT NULL,\r\n\t[EmployeeId] [int] NULL,\r\n\t[Date] [datetime] NOT NULL,\r\n\t[Total] [money] NOT NULL,\r\n\t[Disscount] [money] NOT NULL,\r\n\t[Tax] [money] NULL,\r\n\t[PayType] [int] NULL,\r\n\t[BarTableId] [int] NULL,\r\n\t[Paid] [bit] NULL,\r\n\t[Ticket] [bit] NULL,\r\n CONSTRAINT [PK_JokeSales] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] ASC\r\n)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nALTER TABLE [dbo].[JokeSales]  WITH CHECK ADD  CONSTRAINT [FK_JokeSales_Employees] FOREIGN KEY([EmployeeId])\r\nREFERENCES [dbo].[Employees] ([Id])\r\nALTER TABLE [dbo].[JokeSales] CHECK CONSTRAINT [FK_JokeSales_Employees]\r\nALTER TABLE [dbo].[JokeSales]  WITH CHECK ADD  CONSTRAINT [FK_JokeSales_Stations] FOREIGN KEY([StationId])\r\nREFERENCES [dbo].[Stations] ([Id])\r\nALTER TABLE [dbo].[JokeSales] CHECK CONSTRAINT [FK_JokeSales_Stations]\r\nSET ANSI_NULLS ON\r\nSET QUOTED_IDENTIFIER ON\r\nCREATE TABLE [dbo].[JokeSaleDetails](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[SaleId] [int] NOT NULL,\r\n\t[ProductId] [int] NOT NULL,\r\n\t[Quantity] [int] NOT NULL,\r\n\t[Price] [money] NOT NULL,\r\n\t[IsBottle] [bit] NULL,\r\n\t[SubTotal] [money] NULL,\r\n\t[TaxPercentaje] [float] NULL,\r\n\t[Tax] [money] NULL,\r\n\t[Total] [money] NULL,\r\n CONSTRAINT [PK_JokeSaleDetails] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] ASC\r\n)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nALTER TABLE [dbo].[JokeSaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_JokeSaleDetails_JokeSales] FOREIGN KEY([SaleId])\r\nREFERENCES [dbo].[JokeSales] ([Id])\r\nALTER TABLE [dbo].[JokeSaleDetails] CHECK CONSTRAINT [FK_JokeSaleDetails_JokeSales]\r\nALTER TABLE [dbo].[JokeSaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_JokeSaleDetails_Products] FOREIGN KEY([ProductId])\r\nREFERENCES [dbo].[Products] ([Id])\r\nALTER TABLE [dbo].[JokeSaleDetails] CHECK CONSTRAINT [FK_JokeSaleDetails_Products]\r\n\r\n\r\n";
       
        public static void ExecuteSql(string strSql)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            } 
        }

        public static bool ExistsObject(string objectName)
        {
            var strSql =
                "select top 1 1 from sysobjects " +
                "where name = '" + objectName + "' and xtype = 'U'";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {                   
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                          return reader.Read();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }   
        }

        public static void DropTable(string objectName)
        {
            var strSql = "DROP TABLE " + objectName;
              
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }   
        }
    }
}
