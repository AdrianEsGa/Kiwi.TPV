using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    internal static class EmployeeRepository
    {
        internal static List<Employee> GetAllActive()
        {
            const string strSql = "SELECT Id, Name, Image, Active FROM Employees WHERE Active = 1";
            var employees = new List<Employee>();

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
                                var employee = new Employee
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),                                 
                                    Active = (bool) reader["Active"]
                                };

                                if (reader["Image"] != DBNull.Value)
                                    employee.Image = (byte[])reader["Image"];

                                employees.Add(employee);
                            }

                            return employees;
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

        internal static List<Employee> GetAll()
        {
            const string strSql = "SELECT Id, Name, Image, Active, ImagePath FROM Employees";
            var employees = new List<Employee>();

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
                                var employee = new Employee
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    Active = (bool) reader["Active"]
                                };

                                if (reader["Image"] != DBNull.Value)
                                    employee.Image = (byte[])reader["Image"];

                                employees.Add(employee);
                            }

                            return employees;
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

        internal static Employee SaveOrUpdate(Employee employee)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = employee.Id == 0
                        ? "INSERT INTO Employees (Name, Image, Active) VALUES (@Name, @Image, @Active) SELECT Scope_Identity()"
                        : "UPDATE Employees SET Name = @Name, Image = @Image, Active = @Active WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", employee.Name);

                        if (employee.Image == null)
                            command.Parameters.Add("@Image", SqlDbType.VarBinary).Value = DBNull.Value;
                        else command.Parameters.Add("@Image", SqlDbType.VarBinary).Value = employee.Image;

                        command.Parameters.AddWithValue("@Active", employee.Active);
                        command.Parameters.AddWithValue("@Id", employee.Id);

                        connection.Open();

                        if (employee.Id == 0)
                            employee.Id = Convert.ToInt32(command.ExecuteScalar());
                        else command.ExecuteNonQuery();

                        return employee;
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        internal static void Remove(Employee employee)
        {
            try
            {
                using (var connection = new SqlConnection(GlobalDb.ConnectionString))
                {
                    var strSql = "DELETE FROM Employees WHERE Id = @Id";
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", employee.Id);
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

        internal static Employee GetById(int id)
        {
            const string strSql = "SELECT Id, Name, Image, Active FROM Employees WHERE Id = @Id";
            var employee = new Employee();

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
                                employee = new Employee
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),
                                    Active = (bool)reader["Active"]
                                };

                                if (reader["Image"] != DBNull.Value)
                                    employee.Image = (byte[])reader["Image"];
                            }

                            return employee;
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