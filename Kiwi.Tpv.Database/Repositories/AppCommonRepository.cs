using System;
using System.Data;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    internal static class AppCommonRepository
    {
        internal static AppGeneralConfig Get()
        {
            const string strSql =
                "SELECT AdminPassword, ProductButtonsDimensions, EmployeeButtonsDimensions, TableButtonsDimensions, BackgroundImage, " +
                "SystemJoke, JokeInit, JokeEnd, JokeInterval, ShowJokeReport, ServerStationId, DbBackupFilePath " +
                "FROM AppGeneralConfig";
            var appGeneralConfig = new AppGeneralConfig();

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
                                appGeneralConfig = new AppGeneralConfig
                                {
                                    AdminPassword = reader["AdminPassword"].ToString(),
                                    ProductButtonsDimension = Convert.ToInt32(reader["ProductButtonsDimensions"]),
                                    EmployeeButtonsDimension = Convert.ToInt32(reader["EmployeeButtonsDimensions"]),
                                    TableButtonsDimension = Convert.ToInt32(reader["TableButtonsDimensions"]),
                                    BackgroundImage = reader["BackgroundImage"].ToString(),
                                    SystemJoke = (bool) reader["SystemJoke"],
                                    JokeInit = int.Parse(reader["JokeInit"].ToString()),
                                    JokeEnd = int.Parse(reader["JokeEnd"].ToString()),
                                    JokeInterval = int.Parse(reader["JokeInterval"].ToString()),
                                    ShowJokeReport = (bool) reader["ShowJokeReport"],

                                    DbBackupFilePath = reader["DbBackupFilePath"].ToString()
                                };
                                if (reader["ServerStationId"] != DBNull.Value)
                                {
                                    appGeneralConfig.ServerStation =
                                        StationRepository.GetById((int) reader["ServerStationId"]);
                                }
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

            return appGeneralConfig;
        }

        internal static void SaveOrUpdate(AppGeneralConfig appGeneralConfig)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    const string strSql =
                        "UPDATE AppGeneralConfig " +
                        "SET AdminPassword = @AdminPassword, " +
                        "ProductButtonsDimensions = @ProductButtonsDimensions, " +
                        "EmployeeButtonsDimensions = @EmployeeButtonsDimensions, " +
                        "TableButtonsDimensions = @TableButtonsDimensions, " +
                        "BackgroundImage = @BackgroundImage, " +
                        "ShowJokeReport = @ShowJokeReport," +
                        "ServerStationId = @ServerStationId," +
                        "DbBackupFilePath = @DbBackupFilePath";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.Add("@AdminPassword", SqlDbType.VarChar).Value =
                            appGeneralConfig.AdminPassword;
                        command.Parameters.AddWithValue("@ProductButtonsDimensions",
                            appGeneralConfig.ProductButtonsDimension);
                        command.Parameters.AddWithValue("@EmployeeButtonsDimensions",
                            appGeneralConfig.EmployeeButtonsDimension);
                        command.Parameters.AddWithValue("@TableButtonsDimensions",
                            appGeneralConfig.TableButtonsDimension);
                        command.Parameters.AddWithValue("@BackgroundImage", appGeneralConfig.BackgroundImage);
                        command.Parameters.AddWithValue("@ShowJokeReport", appGeneralConfig.ShowJokeReport);

                        if (appGeneralConfig.ServerStation != null)
                        {
                            command.Parameters.AddWithValue("@ServerStationId", appGeneralConfig.ServerStation.Id);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ServerStationId", DBNull.Value);
                        }

                        command.Parameters.AddWithValue("@DbBackupFilePath", appGeneralConfig.DbBackupFilePath);
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