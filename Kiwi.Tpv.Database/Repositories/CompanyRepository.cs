using System;
using System.Data;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    public static class CompanyRepository
    {
        internal static void SaveOrUpdate(Company company)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = "UPDATE Companies " +
                                 "SET Name = @Name, Cif = @Cif, AppLogo = @AppLogo, ReportsLogo = @ReportsLogo, " +
                                 "CombinationControl = @CombinationControl, CombinationControlWithSoda = @CombinationControlWithSoda, " +
                                 "LocalImage = @LocalImage, TicketReport = @TicketReport " +
                                 "WHERE CompanyId = @CompanyId";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", company.Name);
                        command.Parameters.AddWithValue("@Cif", company.Cif);

                        if (company.AppLogo == null)
                            command.Parameters.Add("@AppLogo", SqlDbType.VarBinary).Value = DBNull.Value;
                        else command.Parameters.Add("@AppLogo", SqlDbType.VarBinary).Value = company.AppLogo;

                        if (company.ReportsLogo == null)
                            command.Parameters.Add("@ReportsLogo", SqlDbType.VarBinary).Value = DBNull.Value;
                        else command.Parameters.Add("@ReportsLogo", SqlDbType.VarBinary).Value = company.ReportsLogo;

                        if (company.LocalImage == null)
                            command.Parameters.Add("@LocalImage", SqlDbType.VarBinary).Value = DBNull.Value;
                        else command.Parameters.Add("@LocalImage", SqlDbType.VarBinary).Value = company.LocalImage;

                        command.Parameters.AddWithValue("@CombinationControl", company.CombinationControl);
                        command.Parameters.AddWithValue("@CombinationControlWithSoda", company.CombinationControlWithSoda);

                        command.Parameters.AddWithValue("@TicketReport", company.TicketReport);

                        command.Parameters.AddWithValue("@CompanyId", company.CompanyId);

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

        internal static Company GetById(int companyId)
        {
            var company = new Company();
            const string strSql =
                "SELECT CompanyId, Name, Cif, AppLogo, ReportsLogo, LocalImage, CombinationControl, CombinationControlWithSoda, TicketReport " +
                "FROM Companies WHERE CompanyId = @CompanyId";

            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyId", companyId);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                company = new Company
                                {
                                    CompanyId = Convert.ToInt16(reader["CompanyId"]),
                                    Name = reader["Name"].ToString(),
                                    Cif = reader["Cif"].ToString(),
                                    CombinationControl = (bool) reader["CombinationControl"],
                                    CombinationControlWithSoda = (bool)reader["CombinationControlWithSoda"],
                                    TicketReport = reader["TicketReport"].ToString()
                                };

                                if (reader["AppLogo"] != DBNull.Value)
                                    company.AppLogo = (byte[]) reader["AppLogo"];
                                if (reader["ReportsLogo"] != DBNull.Value)
                                    company.ReportsLogo = (byte[]) reader["ReportsLogo"];
                                if (reader["LocalImage"] != DBNull.Value)
                                    company.LocalImage = (byte[])reader["LocalImage"];

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

            return company;
        }
    }
}