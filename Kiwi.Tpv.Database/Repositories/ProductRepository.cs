using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    internal static class ProductRepository
    {
        internal static List<Product> GetAllActive()
        {
            const string strSql =
                "SELECT Id, Name, Image, SalePrice, SaleDayPrice, Type, SubType, Active, SaleTaxPercentaje, SaleUnits, " +
                "PurchaseUnits, PurchasePrice, PurchaseTaxPercentaje, ShowInMainView, SaleCupDayPrice, SaleCupNightPrice, SaleShotDayPrice, SaleShotNightPrice, SaleCombinedPrice " +
                "FROM Products WHERE Active = 1 AND ShowInMainView = 1 ORDER BY Type, SubType, Name";
            var products = new List<Product>();

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
                                var product = new Product
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),
                                    SaleNightPrice = Convert.ToDouble(reader["SalePrice"]),
                                    SaleDayPrice = Convert.ToDouble(reader["SaleDayPrice"]),
                                    SaleCupDayPrice = Convert.ToDouble(reader["SaleCupDayPrice"]),
                                    SaleCupNightPrice = Convert.ToDouble(reader["SaleCupNightPrice"]),
                                    SaleShotDayPrice = Convert.ToDouble(reader["SaleShotDayPrice"]),
                                    SaleShotNightPrice = Convert.ToDouble(reader["SaleShotNightPrice"]),
                                    SaleCombinedPrice = Convert.ToDouble(reader["SaleCombinedPrice"]),
                                    Type = (ProductType) reader["Type"],
                                    SubType = (ProductSubType)reader["SubType"],
                                    Active = (bool) reader["Active"],
                                    SaleTaxType =
                                        new TaxType {Percentaje = Convert.ToDouble(reader["SaleTaxPercentaje"])},
                                    SaleUnits = Convert.ToDouble(reader["SaleUnits"]),
                                    PurchaseUnits = Convert.ToDouble(reader["PurchaseUnits"]),
                                    PurchasePrice = Convert.ToDouble(reader["PurchasePrice"]),
                                    PurchaseTaxType = new TaxType
                                    {
                                        Percentaje = Convert.ToDouble(reader["PurchaseTaxPercentaje"])
                                    },
                                    ShowInMainView = (bool)reader["ShowInMainView"]
                                };

                                if (reader["Image"] != DBNull.Value)
                                    product.Image = (byte[])reader["Image"];

                                products.Add(product);
                            }

                            return products;
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

        internal static List<Product> GetAll()
        {
            const string strSql =
                "SELECT Id, Name, Image, SalePrice, SaleDayPrice, Type, SubType, Active, " +
                "SaleTaxPercentaje, SaleUnits, PurchaseUnits, PurchasePrice, PurchaseTaxPercentaje, ShowInMainView, " +
                "SaleCupDayPrice, SaleCupNightPrice, SaleShotDayPrice, SaleShotNightPrice, SaleCombinedPrice  " +
                "FROM Products ORDER BY Type, SubType, Name";
            var products = new List<Product>();

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
                                var product = new Product
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),
                                    SaleNightPrice = Convert.ToDouble(reader["SalePrice"]),
                                    SaleDayPrice = Convert.ToDouble(reader["SaleDayPrice"]),
                                    SaleCupDayPrice = Convert.ToDouble(reader["SaleCupDayPrice"]),
                                    SaleCupNightPrice = Convert.ToDouble(reader["SaleCupNightPrice"]),
                                    SaleShotDayPrice = Convert.ToDouble(reader["SaleShotDayPrice"]),
                                    SaleShotNightPrice = Convert.ToDouble(reader["SaleShotNightPrice"]),
                                    SaleCombinedPrice = Convert.ToDouble(reader["SaleCombinedPrice"]),
                                    Type = (ProductType) reader["Type"],
                                    SubType = (ProductSubType)reader["SubType"],
                                    Active = (bool) reader["Active"],
                                    SaleTaxType =
                                        new TaxType {Percentaje = Convert.ToDouble(reader["SaleTaxPercentaje"])},
                                    SaleUnits = Convert.ToDouble(reader["SaleUnits"]),
                                    PurchaseUnits = Convert.ToDouble(reader["PurchaseUnits"]),
                                    PurchasePrice = Convert.ToDouble(reader["PurchasePrice"]),
                                    PurchaseTaxType = new TaxType
                                    {
                                        Percentaje = Convert.ToDouble(reader["PurchaseTaxPercentaje"])
                                    },
                                    ShowInMainView = (bool)reader["ShowInMainView"]
                                };

                                if (reader["Image"] != DBNull.Value)
                                    product.Image = (byte[])reader["Image"];

                                products.Add(product);
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

            return products;
        }

        internal static List<Product> GetAllActive(ProductType type)
        {
            string strSql =
                "SELECT Id, Name, Image, SalePrice, SaleDayPrice, Type, SubType, Active, " +
                "SaleTaxPercentaje, SaleUnits, PurchaseUnits, PurchasePrice, PurchaseTaxPercentaje, ShowInMainView, " +
                "SaleCupDayPrice, SaleCupNightPrice, SaleShotDayPrice, SaleShotNightPrice, SaleCombinedPrice " +
                "FROM Products WHERE Active = 1 AND Type = " + (int) type + " ORDER BY Type, SubType, Name";

            var products = new List<Product>();

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
                                var product = new Product
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),
                                    SaleNightPrice = Convert.ToDouble(reader["SalePrice"]),
                                    SaleDayPrice = Convert.ToDouble(reader["SaleDayPrice"]),
                                    SaleCupDayPrice = Convert.ToDouble(reader["SaleCupDayPrice"]),
                                    SaleCupNightPrice = Convert.ToDouble(reader["SaleCupNightPrice"]),
                                    SaleShotDayPrice = Convert.ToDouble(reader["SaleShotDayPrice"]),
                                    SaleShotNightPrice = Convert.ToDouble(reader["SaleShotNightPrice"]),
                                    SaleCombinedPrice = Convert.ToDouble(reader["SaleCombinedPrice"]),
                                    Type = (ProductType) reader["Type"],
                                    SubType = (ProductSubType)reader["SubType"],
                                    Active = (bool) reader["Active"],
                                    SaleTaxType =
                                        new TaxType {Percentaje = Convert.ToDouble(reader["SaleTaxPercentaje"])},
                                    SaleUnits = Convert.ToDouble(reader["SaleUnits"]),
                                    PurchaseUnits = Convert.ToDouble(reader["PurchaseUnits"]),
                                    PurchasePrice = Convert.ToDouble(reader["PurchasePrice"]),
                                    PurchaseTaxType = new TaxType
                                    {
                                        Percentaje = Convert.ToDouble(reader["PurchaseTaxPercentaje"])
                                    },
                                    ShowInMainView = (bool)reader["ShowInMainView"]
                                };

                                if (reader["Image"] != DBNull.Value)
                                    product.Image = (byte[])reader["Image"];

                                products.Add(product);
                            }

                            return products;
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

        internal static List<Product> GetAllActiveAndNotShowInMainView(ProductType type)
        {
            string strSql =
                "SELECT Id, Name, Image, SalePrice, SaleDayPrice, Type, SubType, Active, " +
                "SaleTaxPercentaje, SaleUnits, PurchaseUnits, PurchasePrice, PurchaseTaxPercentaje, ShowInMainView, " +
                "SaleCupDayPrice, SaleCupNightPrice, SaleShotDayPrice, SaleShotNightPrice, SaleCombinedPrice " +
                "FROM Products WHERE Active = 1 AND ShowInMainView = 0 AND Type = " + (int)type + " ORDER BY Type, SubType, Name";

            var products = new List<Product>();

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
                                var product = new Product
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),
                                    SaleNightPrice = Convert.ToDouble(reader["SalePrice"]),
                                    SaleDayPrice = Convert.ToDouble(reader["SaleDayPrice"]),
                                    SaleCupDayPrice = Convert.ToDouble(reader["SaleCupDayPrice"]),
                                    SaleCupNightPrice = Convert.ToDouble(reader["SaleCupNightPrice"]),
                                    SaleShotDayPrice = Convert.ToDouble(reader["SaleShotDayPrice"]),
                                    SaleShotNightPrice = Convert.ToDouble(reader["SaleShotNightPrice"]),
                                    SaleCombinedPrice = Convert.ToDouble(reader["SaleCombinedPrice"]),
                                    Type = (ProductType)reader["Type"],
                                    SubType = (ProductSubType)reader["SubType"],
                                    Active = (bool)reader["Active"],
                                    SaleTaxType =
                                        new TaxType { Percentaje = Convert.ToDouble(reader["SaleTaxPercentaje"]) },
                                    SaleUnits = Convert.ToDouble(reader["SaleUnits"]),
                                    PurchaseUnits = Convert.ToDouble(reader["PurchaseUnits"]),
                                    PurchasePrice = Convert.ToDouble(reader["PurchasePrice"]),
                                    PurchaseTaxType = new TaxType
                                    {
                                        Percentaje = Convert.ToDouble(reader["PurchaseTaxPercentaje"])
                                    },
                                    ShowInMainView = (bool)reader["ShowInMainView"]
                                };

                                if (reader["Image"] != DBNull.Value)
                                    product.Image = (byte[])reader["Image"];

                                products.Add(product);
                            }

                            return products;
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

        internal static Product SaveOrUpdate(Product product)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = product.Id == 0
                        ? "INSERT INTO Products (Name, Image, SalePrice, SaleDayPrice, Type, SubType, Active, SaleTaxPercentaje, SaleUnits, PurchaseUnits, PurchasePrice, PurchaseTaxPercentaje, ShowInMainView, SaleCupDayPrice, SaleCupNightPrice, SaleShotDayPrice, SaleShotNightPrice, SaleCombinedPrice) " +
                          "VALUES (@Name, @Image, @SalePrice, @SaleDayPrice, @Type, @SubType, @Active, @SaleTaxPercentaje, @SaleUnits, @PurchaseUnits, @PurchasePrice, @PurchaseTaxPercentaje, @ShowInMainView, @SaleCupDayPrice, @SaleCupNightPrice, @SaleShotDayPrice, @SaleShotNightPrice, @SaleCombinedPrice) SELECT Scope_Identity()"
                        : "UPDATE Products " +
                          "SET Name = @Name, Image = @Image, SalePrice = @SalePrice, SaleDayPrice = @SaleDayPrice, " +
                          "Type = @Type, SubType = @SubType, Active = @Active, SaleTaxPercentaje = @SaleTaxPercentaje, " +
                          "SaleUnits = @SaleUnits, PurchaseUnits = @PurchaseUnits, " +
                          "PurchasePrice = @PurchasePrice, PurchaseTaxPercentaje = @PurchaseTaxPercentaje, ShowInMainView = @ShowInMainView, " +
                          "SaleCupDayPrice = @SaleCupDayPrice, SaleCupNightPrice = @SaleCupNightPrice, SaleShotDayPrice = @SaleShotDayPrice, SaleShotNightPrice = @SaleShotNightPrice, SaleCombinedPrice = @SaleCombinedPrice " +
                          "WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", product.Name);
                        if (product.Image == null)
                            command.Parameters.Add("@Image", SqlDbType.VarBinary).Value = DBNull.Value;
                        else command.Parameters.Add("@Image", SqlDbType.VarBinary).Value = product.Image;

                        command.Parameters.AddWithValue("@SalePrice", product.SaleNightPrice);
                        command.Parameters.AddWithValue("@SaleDayPrice", product.SaleDayPrice);
                        command.Parameters.AddWithValue("@SaleCupDayPrice", product.SaleCupDayPrice);
                        command.Parameters.AddWithValue("@SaleCupNightPrice", product.SaleCupNightPrice);
                        command.Parameters.AddWithValue("@SaleShotDayPrice", product.SaleShotDayPrice);
                        command.Parameters.AddWithValue("@SaleShotNightPrice", product.SaleShotNightPrice);
                        command.Parameters.AddWithValue("@SaleCombinedPrice", product.SaleCombinedPrice);
                        command.Parameters.AddWithValue("@Type", product.Type);
                        command.Parameters.AddWithValue("@SubType", product.SubType);
                        command.Parameters.AddWithValue("@Active", product.Active);
                        command.Parameters.AddWithValue("@SaleTaxPercentaje", product.SaleTaxType.Percentaje);
                        command.Parameters.AddWithValue("@SaleUnits", product.SaleUnits);
                        command.Parameters.AddWithValue("@PurchaseUnits", product.PurchaseUnits);
                        command.Parameters.AddWithValue("@PurchasePrice", product.PurchasePrice);
                        command.Parameters.AddWithValue("@PurchaseTaxPercentaje", product.PurchaseTaxType.Percentaje);
                        command.Parameters.AddWithValue("@ShowInMainView", product.ShowInMainView);
                        command.Parameters.AddWithValue("@Id", product.Id);

                        connection.Open();

                        if (product.Id == 0)
                            product.Id = Convert.ToInt32(command.ExecuteScalar());
                        else command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return product;
        }

        internal static void Remove(Product product)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = "DELETE FROM Products WHERE Id = @Id";
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", product.Id);
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

        internal static Product GetById(int productId)
        {
            const string strSql =
                "SELECT Id, Name, Image, SalePrice, SaleDayPrice, Type, SubType, Active, SaleTaxPercentaje, SaleUnits, " +
                "PurchaseUnits, PurchasePrice, PurchaseTaxPercentaje, ShowInMainView, " +
                "SaleCupDayPrice, SaleCupNightPrice, SaleShotDayPrice, SaleShotNightPrice, SaleCombinedPrice " +
                "FROM Products WHERE Id = @ProductId";

            var product = new Product();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                product = new Product
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),
                                    SaleNightPrice = Convert.ToDouble(reader["SalePrice"]),
                                    SaleDayPrice = Convert.ToDouble(reader["SaleDayPrice"]),
                                    SaleCupDayPrice = Convert.ToDouble(reader["SaleCupDayPrice"]),
                                    SaleCupNightPrice = Convert.ToDouble(reader["SaleCupNightPrice"]),
                                    SaleShotDayPrice = Convert.ToDouble(reader["SaleShotDayPrice"]),
                                    SaleShotNightPrice = Convert.ToDouble(reader["SaleShotNightPrice"]),
                                    SaleCombinedPrice = Convert.ToDouble(reader["SaleCombinedPrice"]),
                                    Type = (ProductType)reader["Type"],
                                    SubType = (ProductSubType)reader["SubType"],
                                    Active = (bool)reader["Active"],
                                    SaleTaxType =
                                        new TaxType { Percentaje = Convert.ToDouble(reader["SaleTaxPercentaje"]) },
                                    SaleUnits = Convert.ToDouble(reader["SaleUnits"]),
                                    PurchaseUnits = Convert.ToDouble(reader["PurchaseUnits"]),
                                    PurchasePrice = Convert.ToDouble(reader["PurchasePrice"]),
                                    PurchaseTaxType = new TaxType
                                    {
                                        Percentaje = Convert.ToDouble(reader["PurchaseTaxPercentaje"])
                                    },
                                    ShowInMainView = (bool)reader["ShowInMainView"]
                                };

                                if (reader["Image"] != DBNull.Value)
                                    product.Image = (byte[])reader["Image"];
                            }

                           
                        }
                    }
                }

                return product;
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}