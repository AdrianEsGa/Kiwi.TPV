using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    internal static class TaxTypeRepository
    {
        internal static List<TaxType> GetAll()
        {
            const string strSql = "SELECT Percentaje FROM TaxTypes";
            var taxTypes = new List<TaxType>();

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
                                var taxType = new TaxType
                                {
                                    Percentaje = Convert.ToDouble(reader["Percentaje"])
                                };

                                taxTypes.Add(taxType);
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

            return taxTypes;
        }
    }
}