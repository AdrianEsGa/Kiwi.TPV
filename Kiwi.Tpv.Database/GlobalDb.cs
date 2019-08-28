using System;
using System.Data.SqlClient;

namespace Kiwi.Tpv.Database
{
    public static class GlobalDb
    {
        public static string ConnectionString;

        public static bool TestConnection()
        {
            var sqlConnection = new SqlConnection(ConnectionString);

            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}