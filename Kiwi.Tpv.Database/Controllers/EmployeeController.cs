using System;
using System.Collections.Generic;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class EmployeeController
    {
        public static List<Employee> GetAllActive()
        {
            try
            {
                return EmployeeRepository.GetAllActive();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<Employee> GetAll()
        {
            try
            {
                return EmployeeRepository.GetAll();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static Employee SaveOrUpdate(Employee employee)
        {
            try
            {
                return EmployeeRepository.SaveOrUpdate(employee);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static void Remove(Employee employee)
        {
            try
            {
                EmployeeRepository.Remove(employee);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}