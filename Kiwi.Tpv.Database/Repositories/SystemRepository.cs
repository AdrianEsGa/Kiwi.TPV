using System;
using System.Data.SqlClient;

namespace Kiwi.Tpv.Database.Repositories
{
    public static class SystemRepository
    {
        public static void Insert(byte[] binary)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = "INSERT INTO System (Code, Binary) VALUES (@Code, @Binary)";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Code", GetCount() + 1);
                        command.Parameters.AddWithValue("@Binary", binary);

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


        public static byte[] Get(int code)
        {
            byte[] binary = null;
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = "SELECT Binary FROM System WHERE Code = @Code";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                binary = (byte[]) reader["Binary"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return binary;
        }

        public static int GetCount()
        {
            object count;
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = "SELECT count(1) FROM System";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        connection.Open();
                        count = command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return (int) count;
        }
    }
}