using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.DTOs;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    internal static class SaleOrdersRepository
    {
        internal static List<SaleOrder> GetPendingsByTable(BarTable table)
        {
            var saleOrders = new List<SaleOrder>();

            const string strSql =
                "SELECT Id, StationId, Date " +
                "FROM SaleOrders " +
                "WHERE BarTableId = @BarTableId AND Paid = 0";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@BarTableId", table.Id);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var sale = new SaleOrder()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Station = StationRepository.GetByCode(Convert.ToInt32(reader["StationId"])),
                                    Table = table,
                                    Date = Convert.ToDateTime(reader["Date"]),
                                };
                                sale.Details = GetDetails(sale);
                                saleOrders.Add(sale);
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

            return saleOrders;
        }

        internal static SaleOrder GetPendingByStationAndBar(Station station)
        {
            var saleOrder = new SaleOrder();

            const string strSql =
                "SELECT Id, Date " +
                "FROM SaleOrders " +
                "WHERE StationId = @StationId AND BarTableId IS NULL";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@StationId", station.Id);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                saleOrder = new SaleOrder()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Station = station,
                                    Date = Convert.ToDateTime(reader["Date"]),                              
                                    Table = null,                                 
                                };

                                saleOrder.Details = GetDetails(saleOrder);
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

            return saleOrder;
        }

        private static List<SaleOrderDetail> GetDetails(SaleOrder saleOrder)
        {
            var saleOrderDetails = new List<SaleOrderDetail>();

            const string strSql =
                "SELECT Id, SaleOrderId, ProductId, Quantity, Price " +
                "FROM SaleOrderDetails " +
                "WHERE SaleOrderId = @SaleOrderId";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@SaleOrderId", saleOrder.Id);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                saleOrderDetails.Add( new SaleOrderDetail()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),                              
                                    Product = ProductRepository.GetById(Convert.ToInt32(reader["ProductId"])),                                
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Price = Convert.ToDouble(reader["Price"]),                               
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

            return saleOrderDetails;
        }

        internal static SaleOrder SaveOrUpdate(SaleOrder saleOrder)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {

                    var strSql = saleOrder.Id == 0
                        ? "INSERT INTO SaleOrders (StationId, Date, BarTableId) " +
                          "VALUES (@StationId, @Date, @BarTableId) SELECT Scope_Identity()"
                        : "UPDATE SaleOrders SET StationId = @StationId, Date = @Date," +
                         " BarTableId = @BarTableId WHERE Id = @Id";


                    connection.Open();

                    var transaction = connection.BeginTransaction();

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@StationId", saleOrder.Station.Id);

                        if (saleOrder.Table == null)
                            command.Parameters.AddWithValue("@BarTableId", DBNull.Value);
                        else command.Parameters.AddWithValue("@BarTableId", saleOrder.Table.Id);

                        command.Parameters.AddWithValue("@Id", saleOrder.Id);

                        if (saleOrder.Id == 0)
                            saleOrder.Id = Convert.ToInt32(command.ExecuteScalar());
                        else command.ExecuteNonQuery();

                    }

                    strSql = "DELETE FROM SaleOrderDetails WHERE SaleOrderId = @SaleOrderId";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@SaleOrderId", saleOrder.Id);
                        command.ExecuteNonQuery();
                    }

                    strSql =
                        "INSERT INTO SaleDetails (SaleOrderId, ProductId, Quantity, Price) " +
                        "VALUES (@SaleOrderId, @ProductId, @Quantity, @Price) SELECT Scope_Identity()";

                    foreach (var detail in saleOrder.Details)
                        using (var command = new SqlCommand(strSql, connection))
                        {
                            command.Transaction = transaction;
                            command.Parameters.AddWithValue("@SaleOrderId", saleOrder.Id);
                            command.Parameters.AddWithValue("@ProductId", detail.Product.Id);
                            command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                            command.Parameters.AddWithValue("@Price", detail.Price);
                            detail.Id = Convert.ToInt32(command.ExecuteScalar());
                        }

                    transaction.Commit();
                }
                return saleOrder;
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}