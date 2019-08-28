using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.DTOs.ReportDTOs;

namespace Kiwi.Tpv.Database.Repositories.Reports
{
    public static class ReportRepository
    {
        public static List<SaleDetailsReportDto> GetSaleById(int saleId)
        {
            var saleDetails = new List<SaleDetailsReportDto>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT SD.SaleId, STA.Name AS Station, EMP.Name AS Employee, S.Date, S.Total as TotalSale, " +
                        "S.Tax as TaxSale, S.Disscount as DisscountSale, PR.Name as Product, " +
                        "SD.Quantity, SD.Price, SD.SubTotal, SD.TaxPercentaje, SD.Tax, SD.Total  " +
                        "FROM Sales AS S  " +
                        "INNER JOIN SaleDetails AS SD ON S.Id = SD.SaleId  " +
                        "INNER JOIN Stations AS STA ON S.StationId = STA.Id  " +
                        "INNER JOIN Products AS PR ON SD.ProductId = PR.Id  " +
                        "LEFT JOIN Employees AS EMP ON S.EmployeeId = EMP.Id " +
                        "WHERE S.Id = @saleId ";


                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@saleId", saleId);


                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var product = new SaleDetailsReportDto
                                {
                                    SaleId = "Venta " + reader["SaleId"],
                                    Station = reader["Station"].ToString(),
                                    Employee = reader["Employee"].ToString(),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    TotalSale = Convert.ToDouble(reader["TotalSale"]),
                                    DisscountSale = Convert.ToDouble(reader["DisscountSale"]),
                                    TaxSale = Convert.ToDouble(reader["TaxSale"]),
                                    Product = reader["Product"].ToString(),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Price = Convert.ToDouble(reader["Price"]),
                                    SubTotal = Convert.ToDouble(reader["SubTotal"]),
                                    TaxPercentaje = Convert.ToDouble(reader["TaxPercentaje"]),
                                    Tax = Convert.ToDouble(reader["Tax"]),
                                    Total = Convert.ToDouble(reader["Total"])
                                };

                                saleDetails.Add(product);
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

        public static List<SaleDetailsReportDto> GetSaleDetails(string stationIds, DateTime initDate, DateTime endDate)
        {
            var saleDetails = new List<SaleDetailsReportDto>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT SD.SaleId, STA.Name AS Station, EMP.Name AS Employee, S.Date, S.Total as TotalSale, " +
                        "S.Tax as TaxSale, S.Disscount as DisscountSale, PR.Name as Product, " +
                        "SD.Quantity, SD.Price, SD.SubTotal, SD.TaxPercentaje, SD.Tax, SD.Total  " +
                        "FROM Sales AS S  " +
                        "INNER JOIN SaleDetails AS SD ON S.Id = SD.SaleId  " +
                        "INNER JOIN Stations AS STA ON S.StationId = STA.Id  " +
                        "INNER JOIN Products AS PR ON SD.ProductId = PR.Id  " +
                        "INNER JOIN Employees AS EMP ON S.EmployeeId = EMP.Id " +
                        "WHERE STA.Id IN ( " + stationIds + ") AND S.Date >= @InitDate AND s.Date <= @EndDate ";


                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var product = new SaleDetailsReportDto
                                {
                                    SaleId = "Venta " + reader["SaleId"],
                                    Station = reader["Station"].ToString(),
                                    Employee = reader["Employee"].ToString(),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    TotalSale = Convert.ToDouble(reader["TotalSale"]),
                                    DisscountSale = Convert.ToDouble(reader["DisscountSale"]),
                                    TaxSale = Convert.ToDouble(reader["TaxSale"]),
                                    Product = reader["Product"].ToString(),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Price =  Math.Round(Convert.ToDouble(reader["Price"]) / (Convert.ToDouble(reader["TaxPercentaje"]) / 100 + 1), 2),
                                    SubTotal = Convert.ToDouble(reader["SubTotal"]),
                                    TaxPercentaje = Convert.ToDouble(reader["TaxPercentaje"]),
                                    Tax = Convert.ToDouble(reader["Tax"]),
                                    Total = Convert.ToDouble(reader["Total"])
                                };

                                saleDetails.Add(product);
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

        public static List<SaleResumeReportDto> GetSaleResume(string stationIds, DateTime initDate, DateTime endDate)
        {
            var saleResume = new List<SaleResumeReportDto>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT SD.TaxPercentaje, SUM(SD.SubTotal) AS SubTotal, SUM(SD.Tax) AS Tax, SUM(SD.Total) AS Total " +
                        "FROM SaleDetails AS SD " +
                        "INNER JOIN Sales AS S ON SD.SaleId = S.Id " +
                        "WHERE S.StationId IN ( " + stationIds + ") AND  S.Date >= @InitDate AND  S.Date <= @EndDate " +
                        "GROUP BY TaxPercentaje ";


                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var resume = new SaleResumeReportDto
                                {
                                    TaxTypePercentaje = Convert.ToDouble(reader["TaxPercentaje"]),
                                    SubTotal = Convert.ToDouble(reader["SubTotal"]),
                                    Tax = Convert.ToDouble(reader["Tax"]),
                                    Total = Convert.ToDouble(reader["Total"])
                                };

                                saleResume.Add(resume);
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

            return saleResume;
        }

        public static SaleResumeDisscountDto GetSaleDisccountResume(string stationIds, DateTime initDate,
            DateTime endDate)
        {
            var saleResumeDisscount = new SaleResumeDisscountDto();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT ISNULL(SUM(Total),0) as TotalLessDisscount, ISNULL(SUM(Disscount),0) as TotalDisscount FROM Sales AS S " +
                        "WHERE S.StationId IN ( " + stationIds + ") AND  S.Date >= @InitDate AND  S.Date <= @EndDate ";


                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                saleResumeDisscount = new SaleResumeDisscountDto
                                {
                                    TotalLessDisscount = Convert.ToDouble(reader["TotalLessDisscount"]),
                                    TotalDisscount = Convert.ToDouble(reader["TotalDisscount"])
                                };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return saleResumeDisscount;
        }


        public static List<SaleDetailsReportDto> GetJokeSaleDetails(string stationIds, DateTime initDate,
            DateTime endDate)
        {
            var saleDetails = new List<SaleDetailsReportDto>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT SD.SaleId, STA.Name AS Station, EMP.Name AS Employee, S.Date, S.Total as TotalSale, " +
                        "S.Tax as TaxSale, S.Disscount as DisscountSale, PR.Name as Product, " +
                        "SD.Quantity, SD.Price, SD.SubTotal, SD.TaxPercentaje, SD.Tax, SD.Total  " +
                        "FROM JokeSales AS S  " +
                        "INNER JOIN JokeSaleDetails AS SD ON S.Id = SD.SaleId  " +
                        "INNER JOIN Stations AS STA ON S.StationId = STA.Id  " +
                        "INNER JOIN Products AS PR ON SD.ProductId = PR.Id  " +
                        "INNER JOIN Employees AS EMP ON S.EmployeeId = EMP.Id " +
                        "WHERE STA.Id IN ( " + stationIds + ") AND S.Date >= @InitDate AND s.Date <= @EndDate ";


                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var product = new SaleDetailsReportDto
                                {
                                    SaleId = "Venta " + reader["SaleId"],
                                    Station = reader["Station"].ToString(),
                                    Employee = reader["Employee"].ToString(),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    TotalSale = Convert.ToDouble(reader["TotalSale"]),
                                    DisscountSale = Convert.ToDouble(reader["DisscountSale"]),
                                    TaxSale = Convert.ToDouble(reader["TaxSale"]),
                                    Product = reader["Product"].ToString(),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Price = Math.Round(Convert.ToDouble(reader["Price"]) / (Convert.ToDouble(reader["TaxPercentaje"]) / 100 + 1), 2),
                                    SubTotal = Convert.ToDouble(reader["SubTotal"]),
                                    TaxPercentaje = Convert.ToDouble(reader["TaxPercentaje"]),
                                    Tax = Convert.ToDouble(reader["Tax"]),
                                    Total = Convert.ToDouble(reader["Total"])
                                };

                                saleDetails.Add(product);
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

        public static List<SaleResumeReportDto> GetJokeSaleResume(string stationIds, DateTime initDate,
            DateTime endDate)
        {
            var saleResume = new List<SaleResumeReportDto>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT SD.TaxPercentaje, SUM(SD.SubTotal) AS SubTotal, SUM(SD.Tax) AS Tax, SUM(SD.Total) AS Total " +
                        "FROM JokeSaleDetails AS SD " +
                        "INNER JOIN JokeSales AS S ON SD.SaleId = S.Id " +
                        "WHERE S.StationId IN ( " + stationIds + ") AND  S.Date >= @InitDate AND  S.Date <= @EndDate " +
                        "GROUP BY TaxPercentaje ";


                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var resume = new SaleResumeReportDto
                                {
                                    TaxTypePercentaje = Convert.ToDouble(reader["TaxPercentaje"]),
                                    SubTotal = Convert.ToDouble(reader["SubTotal"]),
                                    Tax = Convert.ToDouble(reader["Tax"]),
                                    Total = Convert.ToDouble(reader["Total"])
                                };

                                saleResume.Add(resume);
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

            return saleResume;
        }

        public static SaleResumeDisscountDto GetJokeSaleDisccountResume(string stationIds, DateTime initDate,
            DateTime endDate)
        {
            var saleResumeDisscount = new SaleResumeDisscountDto();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql =
                        "SELECT ISNULL(SUM(Total),0) as TotalLessDisscount, ISNULL(SUM(Disscount),0) as TotalDisscount FROM JokeSales AS S " +
                        "WHERE S.StationId IN ( " + stationIds + ") AND  S.Date >= @InitDate AND  S.Date <= @EndDate ";


                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@InitDate", initDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                saleResumeDisscount = new SaleResumeDisscountDto
                                {
                                    TotalLessDisscount = Convert.ToDouble(reader["TotalLessDisscount"]),
                                    TotalDisscount = Convert.ToDouble(reader["TotalDisscount"])
                                };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return saleResumeDisscount;
        }
    }
}