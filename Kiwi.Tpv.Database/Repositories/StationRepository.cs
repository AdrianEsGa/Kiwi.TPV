using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    internal static class StationRepository
    {
        internal static Station GetById(int id)
        {
            const string strSql = "SELECT Id, Code, Name, PrintterComPort, ShowSaleOrderTicket, ShowAnimations FROM Stations WHERE Id = @Id";
            var station = new Station();

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
                                station = new Station
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Code = Convert.ToInt32(reader["Code"]),
                                    Name = reader["Name"].ToString(),
                                    PrintterComPort = reader["PrintterComPort"].ToString(),
                                    ShowSaleOrderTicket = (bool)reader["ShowSaleOrderTicket"],
                                    ShowAnimations = (bool)reader["ShowAnimations"]
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

            return station;
        }

        internal static Station GetByCode(int code)
        {
            const string strSql = "SELECT Id, Code, Name, PrintterComPort, ShowSaleOrderTicket, ShowAnimations FROM Stations WHERE Code = @Code";
            var station = new Station();

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                station = new Station
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Code = Convert.ToInt32(reader["Code"]),
                                    Name = reader["Name"].ToString(),
                                    PrintterComPort = reader["PrintterComPort"].ToString(),
                                    ShowSaleOrderTicket = (bool)reader["ShowSaleOrderTicket"],
                                    ShowAnimations = (bool)reader["ShowAnimations"]
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

            return station;
        }

        internal static List<Station> GetAll()
        {
            const string strSql = "SELECT Id, Code, Name, PrintterComPort, ShowSaleOrderTicket, ShowAnimations FROM Stations";
            var stations = new List<Station>();

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
                                var station = new Station
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Code = Convert.ToInt32(reader["Code"]),
                                    Name = reader["Name"].ToString(),
                                    PrintterComPort = reader["PrintterComPort"].ToString(),
                                    ShowSaleOrderTicket = (bool)reader["ShowSaleOrderTicket"],
                                    ShowAnimations = (bool)reader["ShowAnimations"]
                                };

                                stations.Add(station);
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

            return stations;
        }

        internal static void Update(Station station)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    const string strSql = "UPDATE Stations " +
                                          " SET PrintterComPort = @PrintterComPort, ShowSaleOrderTicket = @ShowSaleOrderTicket, ShowAnimations = @ShowAnimations " +
                                          "WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@PrintterComPort", station.PrintterComPort);
                        command.Parameters.AddWithValue("@ShowSaleOrderTicket", station.ShowSaleOrderTicket);
                        command.Parameters.AddWithValue("@ShowAnimations", station.ShowAnimations);
                        command.Parameters.AddWithValue("@Id", station.Id);
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