using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.DTOs;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    internal static class SalesRepository
    {
        private static List<SaleDetail> GetDetails(Sale sale)
        {
            var saleDetails = new List<SaleDetail>();

            const string strSql =
                "SELECT Id, SaleId, ProductId, Quantity, Price, IsBottle, SubTotal, TaxPercentaje, Tax, Total " +
                "FROM SaleDetails " +
                "WHERE SaleId = @SaleId";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@SaleId", sale.Id);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                saleDetails.Add( new SaleDetail()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Sale = sale,
                                    Product = ProductRepository.GetById(Convert.ToInt32(reader["ProductId"])),                                
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Price = Convert.ToDouble(reader["Price"]),
                                    IsBottle = (bool)reader["IsBottle"],
                                    SubTotal = Convert.ToDouble(reader["SubTotal"]),
                                    TaxPercentaje = Convert.ToDouble(reader["TaxPercentaje"]),
                                    Tax = Convert.ToDouble(reader["Tax"]),
                                    Total = Convert.ToDouble(reader["Total"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return saleDetails;
        }

        internal static Sale SaveOrUpdate(Sale sale)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {


                    var strSql = sale.Id == 0
                        ? "INSERT INTO Sales (StationId, EmployeeId, Date, Total, Disscount, Tax, PayType, BarTableId) " +
                          "VALUES (@StationId, @EmployeeId, @Date, @Total, @Disscount, @Tax, @PayType, @BarTableId) SELECT Scope_Identity()"
                        : "UPDATE Sales SET StationId = @StationId, EmployeeId = @EmployeeId, Date = @Date, Total = @Total, Disscount = @Disscount," +
                         " Tax = @Tax , PayType = @PayType, BarTableId = @BarTableId WHERE Id = @SaleId";


                    connection.Open();

                    var transaction = connection.BeginTransaction();

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@StationId", sale.Station.Id);

                        if (sale.Employee == null)
                            command.Parameters.AddWithValue("@EmployeeId", DBNull.Value);
                        else command.Parameters.AddWithValue("@EmployeeId", sale.Employee.Id);

                        if (sale.Table == null)
                            command.Parameters.AddWithValue("@BarTableId", DBNull.Value);
                        else command.Parameters.AddWithValue("@BarTableId", sale.Table.Id);

                        command.Parameters.AddWithValue("@Date", sale.Date);
                        command.Parameters.AddWithValue("@Total", sale.Total);
                        command.Parameters.AddWithValue("@Disscount", sale.Disscount);
                        command.Parameters.AddWithValue("@Tax", sale.Tax);
                        command.Parameters.AddWithValue("@PayType", (int) sale.PayType);
                        command.Parameters.AddWithValue("@SaleId", sale.Id);

                        if (sale.Id == 0)
                            sale.Id = Convert.ToInt32(command.ExecuteScalar());
                        else command.ExecuteNonQuery();

                    }

                    strSql = "DELETE FROM SaleDetails WHERE SaleId = @SaleId";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@SaleId", sale.Id);
                        command.ExecuteNonQuery();
                    }

                    strSql =
                        "INSERT INTO SaleDetails (SaleId, ProductId, Quantity, Price, SubTotal, TaxPercentaje, Tax, Total, IsBottle) " +
                        "VALUES (@SaleId, @ProductId, @Quantity, @Price, @SubTotal, @TaxPercentaje, @Tax, @Total, @IsBottle) SELECT Scope_Identity()";

                    foreach (var detail in sale.Details)
                        using (var command = new SqlCommand(strSql, connection))
                        {
                            command.Transaction = transaction;
                            command.Parameters.AddWithValue("@SaleId", sale.Id);
                            command.Parameters.AddWithValue("@ProductId", detail.Product.Id);
                            command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                            command.Parameters.AddWithValue("@Price", detail.Price);
                            command.Parameters.AddWithValue("@SubTotal", detail.SubTotal);
                            command.Parameters.AddWithValue("@TaxPercentaje", detail.TaxPercentaje);
                            command.Parameters.AddWithValue("@Tax", detail.Tax);
                            command.Parameters.AddWithValue("@Total", detail.Total);
                            command.Parameters.AddWithValue("@IsBottle", detail.IsBottle);
                            detail.Id = Convert.ToInt32(command.ExecuteScalar());
                        }

                    transaction.Commit();
                }
                return sale;
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        internal static void SaveOrUpdateJoke(Sale sale)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "INSERT INTO JokeSales (StationId, EmployeeId, Date, Total, Disscount, Tax, PayType) " +
                        "VALUES (@StationId, @EmployeeId, @Date, @Total, @Disscount, @Tax, @PayType) SELECT Scope_Identity()";

                    connection.Open();

                    var transaction = connection.BeginTransaction();

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@StationId", sale.Station.Id);
                        command.Parameters.AddWithValue("@EmployeeId", sale.Employee.Id);
                        command.Parameters.AddWithValue("@Date", sale.Date);
                        command.Parameters.AddWithValue("@Total", sale.Total);
                        command.Parameters.AddWithValue("@Disscount", sale.Disscount);
                        command.Parameters.AddWithValue("@Tax", sale.Tax);
                        command.Parameters.AddWithValue("@PayType", (int) sale.PayType);

                        sale.Id = Convert.ToInt32(command.ExecuteScalar());
                    }

                    strSql =
                        "INSERT INTO JokeSaleDetails (SaleId, ProductId, Quantity, Price, SubTotal, TaxPercentaje, Tax, Total, IsBottle) " +
                        "VALUES (@SaleId, @ProductId, @Quantity, @Price, @SubTotal, @TaxPercentaje, @Tax, @Total, @IsBottle) SELECT Scope_Identity()";

                    foreach (var detail in sale.Details)
                        using (var command = new SqlCommand(strSql, connection))
                        {
                            command.Transaction = transaction;
                            command.Parameters.AddWithValue("@SaleId", sale.Id);
                            command.Parameters.AddWithValue("@ProductId", detail.Product.Id);
                            command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                            command.Parameters.AddWithValue("@Price", detail.Price);
                            command.Parameters.AddWithValue("@SubTotal", detail.SubTotal);
                            command.Parameters.AddWithValue("@TaxPercentaje", detail.TaxPercentaje);
                            command.Parameters.AddWithValue("@Tax", detail.Tax);
                            command.Parameters.AddWithValue("@Total", detail.Total);
                            command.Parameters.AddWithValue("@IsBottle", detail.IsBottle);
                            detail.Id = Convert.ToInt32(command.ExecuteScalar());
                        }

                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        internal static List<ProductHistoryDto> GetTotalsByProduct(string stationIds, DateTime initDate, DateTime endDate)
        {
            var productHistory = new List<ProductHistoryDto>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT QUERY.ProductId, QUERY.Product, ROUND(SUM(QUERY.TotalBottles),2) AS TotalBottles, SUM(QUERY.TotalQuantity) AS TotalQuantity " +
                        " FROM  " +
                        "  (SELECT SD.ProductId ,CASE WHEN SD.IsBottle = 1 THEN MAX('Botella ' + P.Name) ELSE MAX(P.Name) END AS Product  " +
                        "  ,SUM(SD.Quantity) AS TotalQuantity ,CASE WHEN MAX(P.Type) = 1 AND SD.IsBottle = 0 THEN ROUND(SUM(CAST(SD.Quantity AS FLOAT) / 10), 2)  " +
                        " WHEN SD.IsBottle = 1 THEN SUM(SD.Quantity) ELSE 0 END AS TotalBottles FROM Sales AS S  " +
                        "  INNER JOIN SaleDetails AS SD ON S.Id = SD.SaleId INNER JOIN Products AS P ON SD.ProductId = P.Id  " +
                        "  WHERE S.StationId IN ( " + stationIds + ")  " +
                        "  AND S.Date >= @InitDate AND s.Date <= @EndDate GROUP BY SD.ProductId, SD.IsBottle  " +
                        "    UNION ALL " +
                        " SELECT SD.ProductId ,CASE WHEN SD.IsBottle = 1 THEN MAX('Botella ' + P.Name) ELSE MAX(P.Name) END AS Product  " +
                        "  ,SUM(SD.Quantity) AS TotalQuantity ,CASE WHEN MAX(P.Type) = 1 AND SD.IsBottle = 0 THEN ROUND(SUM(CAST(SD.Quantity AS FLOAT) / 10), 2)  " +
                        "  WHEN SD.IsBottle = 1 THEN SUM(SD.Quantity) ELSE 0 END AS TotalBottles FROM JokeSales AS S  " +
                        "  INNER JOIN JokeSaleDetails AS SD ON S.Id = SD.SaleId INNER JOIN Products AS P ON SD.ProductId = P.Id  " +
                        "  WHERE S.StationId IN ( " + stationIds + ")  " +
                        "  AND S.Date >= @InitDate AND s.Date <= @EndDate GROUP BY SD.ProductId, SD.IsBottle ) AS QUERY " +
                        "   GROUP BY QUERY.ProductId, QUERY.Product";


                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var product = new ProductHistoryDto
                                {
                                    Product = reader["Product"].ToString(),
                                    TotalQuantity = Convert.ToInt32(reader["TotalQuantity"]),
                                    TotalBottles = Convert.ToDouble(reader["TotalBottles"])
                                };

                                productHistory.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return productHistory;
        }

        internal static List<EmployeeHistoryDto> GetTotalsByEmployee(string stationIds, DateTime initDate, DateTime endDate)
        {
            var employeeHistory = new List<EmployeeHistoryDto>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT Query.Employee, Query.EmployeeId FROM " +
                        "(SELECT S.EmployeeId, MAX(E.Name) as Employee  " +
                        "FROM Sales AS S  " +
                        "INNER JOIN Employees AS E ON S.EmployeeId = E.Id  " +
                        "WHERE S.StationId IN ( " + stationIds + ") AND S.Date >= @InitDate AND s.Date <= @EndDate  " +
                        "GROUP BY S.EmployeeId " +
                        "UNION " +
                        "SELECT S.EmployeeId, MAX(E.Name) as Employee  " +
                        "FROM JokeSales AS S  " +
                        "INNER JOIN Employees AS E ON S.EmployeeId = E.Id  " +
                        "WHERE S.StationId IN ( " + stationIds + ") AND S.Date >= @InitDate AND s.Date <= @EndDate  " +
                        "GROUP BY S.EmployeeId) AS Query ";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var employeeId = Convert.ToInt32(reader["EmployeeId"]);
                                var realAndDisscount = GetTotalRealAndDisscountByEmployee(stationIds, initDate,
                                    endDate, employeeId);

                                var employee = new EmployeeHistoryDto();

                                if (realAndDisscount.Count == 0)
                                {
                                    employee.Employee = reader["Employee"].ToString();
                                    employee.TotalReal = 0;
                                    employee.TotalDisscount = 0;
                                    employee.TotalInvited = GetTotalInvitedByEmployee(stationIds, initDate, endDate,
                                        employeeId);
                                }
                                else
                                {
                                    employee.Employee = reader["Employee"].ToString();
                                    employee.TotalReal = realAndDisscount[0];
                                    employee.TotalDisscount = realAndDisscount[1];
                                    employee.TotalInvited = GetTotalInvitedByEmployee(stationIds, initDate, endDate,
                                        employeeId);
                                }

                                employeeHistory.Add(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return employeeHistory;
        }

        private static List<double> GetTotalRealAndDisscountByEmployee(string stationIds, DateTime initDate, DateTime endDate, int employeeId)
        {
            var totalRealDisscount = new List<double>();
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        " SELECT ISNULL(SUM(QUERY.TotalReal),0) AS TotalReal, ISNULL(SUM(QUERY.TotalDisscount),0) AS TotalDisscount " +
                        "FROM  " +
                        "(SELECT  sum(S.Total) as TotalReal, sum (S.Disscount) as TotalDisscount  " +
                        "FROM Sales AS S INNER JOIN Employees AS E ON S.EmployeeId = E.Id  " +
                        "WHERE S.StationId IN ( " + stationIds + ") AND S.Date >= @InitDate AND  " +
                        "s.Date <= @EndDate AND S.EmployeeId = @EmployeeId AND s.Total<>0  " +
                        "GROUP BY S.EmployeeId " +
                        "UNION ALL " +
                        "SELECT  sum(S.Total) as TotalReal, sum (S.Disscount) as TotalDisscount  " +
                        "FROM JokeSales AS S INNER JOIN Employees AS E ON S.EmployeeId = E.Id  " +
                        "WHERE S.StationId IN (  " + stationIds + ") AND S.Date >= @InitDate AND  " +
                        "s.Date <= @EndDate AND S.EmployeeId = @EmployeeId AND s.Total<>0  " +
                        "GROUP BY S.EmployeeId) AS QUERY";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalRealDisscount.Add(Convert.ToDouble(reader["TotalReal"]));
                                totalRealDisscount.Add(Convert.ToDouble(reader["TotalDisscount"]));
                                return totalRealDisscount;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return totalRealDisscount;
        }

        private static double GetTotalInvitedByEmployee(string stationIds, DateTime initDate, DateTime endDate, int employeeId)
        {
            double totalInvited = 0;
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT ISNULL(SUM(ISNULL(QUERY.TotalInvited,0)),0) AS TotalInvited " +
                        "FROM  " +
                        "(SELECT sum (S.Disscount) as TotalInvited  " +
                        "FROM Sales AS S  " +
                        "INNER JOIN Employees AS E ON S.EmployeeId = E.Id  " +
                        "WHERE S.StationId IN ( " + stationIds +
                        ") AND S.Date >= @InitDate  AND s.Date <= @EndDate AND S.EmployeeId = @EmployeeId and Total = 0  " +
                        "GROUP BY S.EmployeeId " +
                        "UNION ALL " +
                        "SELECT sum (S.Disscount) as TotalInvited  " +
                        "FROM JokeSales AS S  " +
                        "INNER JOIN Employees AS E ON S.EmployeeId = E.Id  " +
                        "WHERE S.StationId IN ( " + stationIds +
                        ") AND S.Date >= @InitDate  AND s.Date <= @EndDate AND S.EmployeeId = @EmployeeId and Total = 0  " +
                        "GROUP BY S.EmployeeId ) QUERY";


                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalInvited = Convert.ToDouble(reader["TotalInvited"]);
                                return totalInvited;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return totalInvited;
        }

        internal static List<double> GetTotals(string stationIds, DateTime initDate, DateTime endDate)
        {
            var totals = new List<double>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT ISNULL(SUM(TotalLogic),0)AS TotalLogic " +
                        "FROM  " +
                        "(SELECT ISNULL(SUM(sd.Total),0) as TotalLogic  " +
                        "FROM SaleDetails as sd INNER JOIN Sales as s ON s.Id = sd.SaleId  " +
                        "WHERE StationId IN ( " + stationIds + ") AND Date >= @InitDate AND Date <= @EndDate  " +
                        "UNION ALL " +
                        "SELECT ISNULL(SUM(sd.Total),0) as TotalLogic  " +
                        "FROM JokeSaleDetails as sd INNER JOIN JokeSales as s ON s.Id = sd.SaleId  " +
                        "WHERE StationId IN ( " + stationIds + ") AND Date >= @InitDate AND Date <= @EndDate ) AS Query";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                totals.Add(Convert.ToDouble(reader["TotalLogic"]));
                        }
                    }


                    strSql =
                        "SELECT ISNULL(SUM(TotalInvited),0)AS TotalInvited " +
                        "FROM  " +
                        "(SELECT ISNULL(SUM (Disscount),0) as TotalInvited  " +
                        "FROM Sales  " +
                        "WHERE StationId IN (" + stationIds +
                        ") AND Date >= @InitDate AND Date <= @EndDate AND Total = 0 " +
                        "UNION ALL " +
                        "SELECT ISNULL(SUM (Disscount),0) as TotalInvited  " +
                        "FROM JokeSales  " +
                        "WHERE StationId IN ( " + stationIds +
                        ") AND Date >= @InitDate AND Date <= @EndDate AND Total = 0) AS Query";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                totals.Add(Convert.ToDouble(reader["TotalInvited"]));
                        }
                    }


                    strSql =
                        "SELECT ISNULL(SUM(TotalReal),0)AS TotalReal,ISNULL(SUM(TotalDisscount),0)AS TotalDisscount " +
                        "FROM  " +
                        "(SELECT ISNULL(SUM(Total),0) as TotalReal, ISNULL(SUM (Disscount),0) as TotalDisscount  " +
                        "FROM Sales  " +
                        "WHERE StationId IN ( " + stationIds +
                        ") AND Date >= @InitDate AND Date <= @EndDate AND Total <> 0 " +
                        "UNION ALL " +
                        "SELECT ISNULL(SUM(Total),0) as TotalReal, ISNULL(SUM (Disscount),0) as TotalDisscount  " +
                        "FROM JokeSales  " +
                        "WHERE StationId IN ( " + stationIds +
                        ") AND Date >= @InitDate AND Date <= @EndDate AND Total <> 0) AS Query";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totals.Add(Convert.ToDouble(reader["TotalDisscount"]));
                                totals.Add(Convert.ToDouble(reader["TotalReal"]));
                            }
                        }
                    }

                    //Total cash
                    strSql =
                        "SELECT ISNULL(SUM(TotalCash),0)AS TotalCash " +
                        "FROM  " +
                        "(SELECT ISNULL(SUM(Total),0) as TotalCash  " +
                        "FROM Sales  " +
                        "WHERE StationId IN ( " + stationIds +
                        ") AND Date >= @InitDate AND Date <= @EndDate AND Total <> 0 AND PayType = 1 " +
                        "UNION ALL " +
                        "SELECT ISNULL(SUM(Total),0) as TotalCash  " +
                        "FROM JokeSales  " +
                        "WHERE StationId IN (" + stationIds +
                        ") AND Date >= @InitDate AND Date <= @EndDate AND Total <> 0 AND PayType = 1) AS Query";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                totals.Add(Convert.ToDouble(reader["TotalCash"]));
                        }
                    }

                    //Total Credit Card
                    strSql =
                        "SELECT ISNULL(SUM(Total),0) as TotalCreditCard " +
                        "FROM Sales " +
                        "WHERE StationId IN ( " + stationIds +
                        ") AND Date >= @InitDate AND Date <= @EndDate AND Total <> 0 AND PayType = 2";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                totals.Add(Convert.ToDouble(reader["TotalCreditCard"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return totals;
        }
    }
}