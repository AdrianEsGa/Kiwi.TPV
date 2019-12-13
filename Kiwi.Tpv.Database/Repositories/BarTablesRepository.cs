using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    internal static class BarTablesRepository
    {
        internal static List<BarTable> GetAllActive()
        {
            const string strSql =
                "SELECT Id, Code, Name, ImagePath, Location, Active, Type " +
                "FROM BarTables WHERE Active = 1";

            var tables = new List<BarTable>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tables.Add(new BarTable()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Code = Convert.ToInt32(reader["Code"]),
                                    Name = reader["Name"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    Location = reader["Location"].ToString(),
                                    Active = (bool)reader["Active"],
                                    Type = (BarTable.BarTableType) Convert.ToInt16(reader["Type"])
                                });
                            }

                            return tables;
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

        internal static List<BarTable> GetAllActiveWithoutLocation()
        {
            const string strSql =
                "SELECT Id, Code, Name, ImagePath, Location, Active, Type " +
                "FROM BarTables WHERE Active = 1 AND Location IS NULL";

            var tables = new List<BarTable>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tables.Add(new BarTable()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Code = Convert.ToInt32(reader["Code"]),
                                    Name = reader["Name"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    Location = reader["Location"].ToString(),
                                    Active = (bool)reader["Active"],
                                    Type = (BarTable.BarTableType)Convert.ToInt16(reader["Type"])
                                });
                            }

                            return tables;
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

        internal static List<BarTable> GetAllActiveWithLocation()
        {
            const string strSql =
                "SELECT Id, Code, Name, ImagePath, Location, Active, Type " +
                "FROM BarTables WHERE Active = 1 AND Location IS NOT NULL";

            var tables = new List<BarTable>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tables.Add(new BarTable()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Code = Convert.ToInt32(reader["Code"]),
                                    Name = reader["Name"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    Location = reader["Location"].ToString(),
                                    Active = (bool)reader["Active"],
                                    Type = (BarTable.BarTableType)Convert.ToInt16(reader["Type"])
                                });
                            }

                            return tables;
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

        internal static List<BarTable> GetAll()
        {
            const string strSql =
                "SELECT Id, Code, Name, ImagePath, Location, Active, Type " +
                "FROM BarTables";

            var tables = new List<BarTable>();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tables.Add(new BarTable()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Code = Convert.ToInt32(reader["Code"]),
                                    Name = reader["Name"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    Location = string.IsNullOrEmpty(reader["Location"].ToString()) ? null : reader["Location"].ToString(),
                                    Active = (bool)reader["Active"],
                                    Type = (BarTable.BarTableType)Convert.ToInt16(reader["Type"])
                                });
                            }

                            return tables;
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

        internal static BarTable SaveOrUpdate(BarTable table)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = table.Id == 0
                        ? "INSERT INTO BarTables (Code, Name, Location, Active, Type) " +
                          "VALUES (@Code, @Name, @Location, @Active, @Type) SELECT Scope_Identity() "
                        : "UPDATE BarTables " +
                          "SET Code = @Code, Name = @Name, Location = @Location, Active = @Active, Type = @Type " +
                          "WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Code", table.Code);
                        command.Parameters.AddWithValue("@Name", table.Name);

                        if (table.Location == null)
                          command.Parameters.AddWithValue("@Location", DBNull.Value);
                        else command.Parameters.AddWithValue("@Location", table.Location);

                        command.Parameters.AddWithValue("@Active", table.Active);
                        command.Parameters.AddWithValue("@Type", (int) table.Type);
                        command.Parameters.AddWithValue("@Id", table.Id);

                        connection.Open();

                        if (table.Id == 0)
                            table.Id = Convert.ToInt32(command.ExecuteScalar());
                        else command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return table;
        }

        internal static void Remove(BarTable table)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = "DELETE FROM BarTables WHERE Id = @Id";
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", table.Id);
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

        public static void RemoveDistribution(BarTable table)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = "UPDATE BarTables SET Location = NULL WHERE Id = @Id";
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", table.Id);
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

        public static bool HasPendingSales(BarTable table)
        {
            var hastPendingSales = false;
            const string strSql =
                "SELECT TOP 1 1 FROM SaleOrders WHERE BarTableId = @BarTableId";

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
                            hastPendingSales = reader.Read();                           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return hastPendingSales;
        }

        public static double GetTotalPending(BarTable table)
        {
            double totalPending = 0;
            const string strSql =
                "SELECT SUM(Quantity * Price) As TotalPending " +
                " FROM SaleOrders " +
                " INNER JOIN SaleOrderDetails ON SaleOrders.Id = SaleOrderDetails.SaleOrderId " +
                " WHERE SaleOrders.BarTableId = @BarTableId";

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
                                totalPending = Convert.ToDouble(reader["TotalPending"]);
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

            return totalPending;
        }

        public static BarTable GetById(int id)
        {
            const string strSql =
                "SELECT Id, Code, Name, ImagePath, Location, Active, Type " +
                "FROM BarTables WHERE Id = @Id";

            var table = new BarTable();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Id", id);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                table = new BarTable()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Code = Convert.ToInt32(reader["Code"]),
                                    Name = reader["Name"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    Location = reader["Location"].ToString(),
                                    Active = (bool) reader["Active"],
                                    Type = (BarTable.BarTableType)Convert.ToInt16(reader["Type"])
                                };
                            }

                            return table;
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
    }
}