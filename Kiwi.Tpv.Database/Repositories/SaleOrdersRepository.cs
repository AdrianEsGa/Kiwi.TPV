using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    internal static class SaleOrdersRepository
    {
        public static SaleOrder GetById(int id)
        {
            var saleOrder = new SaleOrder();

            const string strSql =
                "SELECT Id, Date, StationId, BarTableId, IsPending, PendingComment " +
                "FROM SaleOrders " +
                "WHERE Id = @Id";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                saleOrder = new SaleOrder()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Station = StationRepository.GetById(Convert.ToInt32(reader["StationId"])),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    IsPending = (bool)reader["IsPending"],
                                    PendingComment = reader["PendingComment"].ToString()
                                };

                                if (reader["BarTableId"] != DBNull.Value)
                                    saleOrder.Table =
                                        BarTablesRepository.GetById(Convert.ToInt32(reader["BarTableId"]));

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

        internal static List<SaleOrder> GetByTable(BarTable table, bool isPending)
        {
            var saleOrders = new List<SaleOrder>();

            const string strSql =
                "SELECT Id, StationId, Date, IsPending, PendingComment " +
                "FROM SaleOrders " +
                "WHERE BarTableId = @BarTableId AND IsPending = @isPending";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@BarTableId", table.Id);
                        command.Parameters.AddWithValue("@isPending", isPending);

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
                                    IsPending = (bool)reader["IsPending"],
                                    PendingComment = reader["PendingComment"].ToString()
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

        internal static SaleOrder GetByStationAndBar(Station station, bool isPending)
        {
            var saleOrder = new SaleOrder();

            const string strSql =
                "SELECT Id, Date, IsPending, PendingComment " +
                "FROM SaleOrders " +
                "WHERE StationId = @StationId AND BarTableId IS NULL AND IsPending =  @isPending";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@StationId", station.Id);
                        command.Parameters.AddWithValue("@isPending", isPending);

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
                                    IsPending = (bool)reader["IsPending"],
                                    PendingComment = reader["PendingComment"].ToString()
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

        internal static List<SaleOrder> GetAll(bool isPending)
        {
            var saleOrders = new List<SaleOrder>();

            const string strSql =
                "SELECT Id, StationId, Date, IsPending, PendingComment " +
                "FROM SaleOrders " +
                "WHERE IsPending = @isPending";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@isPending", isPending);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var sale = new SaleOrder()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Station = StationRepository.GetByCode(Convert.ToInt32(reader["StationId"])),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    IsPending = (bool)reader["IsPending"],
                                    PendingComment = reader["PendingComment"].ToString()
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

        private static List<SaleOrderDetail> GetDetails(SaleOrder saleOrder)
        {
            var saleOrderDetails = new List<SaleOrderDetail>();

            const string strSql =
                "SELECT Id, SaleOrderId, ProductId, Quantity, Price, TaxPercentaje, IsBottle " +
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
                                    TaxPercentaje = Convert.ToDouble(reader["TaxPercentaje"]),
                                    Price = Convert.ToDouble(reader["Price"]),
                                    IsBottle = Convert.ToBoolean(reader["IsBottle"])
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

                if (saleOrder.Details.Count == 0)
                {
                    Remove(saleOrder);
                    return new SaleOrder();
                }

                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {

                    var strSql = saleOrder.Id == 0
                        ? "INSERT INTO SaleOrders (StationId, Date, BarTableId, IsPending, PendingComment) " +
                          "VALUES (@StationId, @Date, @BarTableId, @IsPending, @PendingComment) SELECT Scope_Identity()"
                        : "UPDATE SaleOrders SET StationId = @StationId, Date = @Date," +
                         " BarTableId = @BarTableId, IsPending = @IsPending, PendingComment = @PendingComment WHERE Id = @Id";


                    connection.Open();

                    var transaction = connection.BeginTransaction();

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@StationId", saleOrder.Station.Id);

                        command.Parameters.AddWithValue("@Date",  DateTime.Now);

                        if (saleOrder.Table == null)
                            command.Parameters.AddWithValue("@BarTableId", DBNull.Value);
                        else command.Parameters.AddWithValue("@BarTableId", saleOrder.Table.Id);

                        command.Parameters.AddWithValue("@IsPending", saleOrder.IsPending);

                        if (string.IsNullOrEmpty(saleOrder.PendingComment))
                            command.Parameters.AddWithValue("@PendingComment", DBNull.Value);
                        else command.Parameters.AddWithValue("@PendingComment", saleOrder.PendingComment);

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
                        "INSERT INTO SaleOrderDetails (SaleOrderId, ProductId, Quantity, Price, TaxPercentaje, IsBottle) " +
                        "VALUES (@SaleOrderId, @ProductId, @Quantity, @Price, @TaxPercentaje, @IsBottle) SELECT Scope_Identity()";

                    foreach (var detail in saleOrder.Details)
                        using (var command = new SqlCommand(strSql, connection))
                        {
                            command.Transaction = transaction;
                            command.Parameters.AddWithValue("@SaleOrderId", saleOrder.Id);
                            command.Parameters.AddWithValue("@ProductId", detail.Product.Id);
                            command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                            command.Parameters.AddWithValue("@Price", detail.Price);
                            command.Parameters.AddWithValue("@TaxPercentaje", detail.TaxPercentaje);
                            command.Parameters.AddWithValue("@IsBottle", detail.IsBottle);
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

        public static void Remove(SaleOrder saleOrder)
        {
            string strSql;

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {          
                   connection.Open();

                    var transaction = connection.BeginTransaction();
                    strSql = "DELETE FROM SaleOrderDetails WHERE SaleOrderId = @SaleOrderId";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@SaleOrderId", saleOrder.Id);
                        command.ExecuteNonQuery();
                    }

                    strSql = "DELETE FROM SaleOrders WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@Id", saleOrder.Id);
                        command.ExecuteNonQuery();
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

    }
}