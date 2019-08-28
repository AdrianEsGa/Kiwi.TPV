using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kiwi.Tpv.Database.Entities;

namespace Kiwi.Tpv.Database.Repositories
{
    internal static class EmployeeRepository
    {
        internal static List<Employee> GetAllActive()
        {
            const string strSql = "SELECT Id, Name, ImagePath, Active FROM Employees WHERE Active = 1";
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
            const string strSql = "SELECT Id, Name, ImagePath, Active FROM Employees";
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
                        ? "INSERT INTO Employees (Name, ImagePath, Active) VALUES (@Name, @ImagePath, @Active) SELECT Scope_Identity()"
                        : "UPDATE Employees SET Name = @Name, ImagePath = @ImagePath, Active = @Active WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", employee.Name);
                        command.Parameters.AddWithValue("@ImagePath", employee.ImagePath);
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
    }
}