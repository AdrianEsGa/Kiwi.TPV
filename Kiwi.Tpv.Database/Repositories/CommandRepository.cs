using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    public static class CommandRepository
    {

        internal static void Update(Command command)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    const string strSql = "UPDATE Commands " +
                                          "SET Status = @Status " +
                                          "WHERE Id = @Id";

                    using (var commandSql = new SqlCommand(strSql, connection))
                    {
                        commandSql.Parameters.AddWithValue("@Id", command.Id);
                        commandSql.Parameters.AddWithValue("@Status", (int) command.Status);                    
                        connection.Open();
                        commandSql.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        internal static List<Command> GetPendingAndInProcessOrFinalizedWithStation(Station station)
        {
            var commands = new List<Command>();

            const string strSql =
                "SELECT Id, EmployeeId, BarTableId, StationId, Date, Status " +
                "FROM Commands " +
                "WHERE Status = 0 OR (Status IN (1, 2) AND StationId = @StationId)";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var commandSql = new SqlCommand(strSql, connection))
                    {
                        commandSql.Parameters.AddWithValue("@StationId", station.Id);

                        connection.Open();
                        using (var reader = commandSql.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var command = new Command
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Employee = EmployeeRepository.GetById(Convert.ToInt32(reader["EmployeeId"])),
                                    Table = BarTablesRepository.GetById(Convert.ToInt32(reader["BarTableId"])),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    Status = (CommandStatus) Convert.ToInt32(reader["Status"]),
                                    Station = reader["StationId"] == DBNull.Value
                                        ? null
                                        : StationRepository.GetByCode(Convert.ToInt32(reader["StationId"])),
                                };
                                command.Details = GetDetails(command);
                                commands.Add(command);
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

            return commands;
        }

        private static List<CommandDetail> GetDetails(Command command)
        {
            var commandDetails = new List<CommandDetail>();

            const string strSql =
                "SELECT Id, ProductId, Quantity, CombinedProductId " +
                "FROM CommandDetails " +
                "WHERE CommandId = @CommandId";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var commandSql = new SqlCommand(strSql, connection))
                    {
                        commandSql.Parameters.AddWithValue("@CommandId", command.Id);

                        connection.Open();
                        using (var reader = commandSql.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                commandDetails.Add(new CommandDetail
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    CommandId = command.Id,
                                    Product = ProductRepository.GetById(Convert.ToInt32(reader["ProductId"])),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    CombinedProduct =
                                        reader["CombinedProductId"] == DBNull.Value
                                            ? null
                                            : ProductRepository.GetById(Convert.ToInt32(reader["CombinedProductId"])),
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

            return commandDetails;
        }

        
    }
}
