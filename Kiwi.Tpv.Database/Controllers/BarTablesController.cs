using System;
using System.Collections.Generic;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class BarTablesController
    {
        public static List<BarTable> GetAllActive()
        {
            try
            {
                return BarTablesRepository.GetAllActive();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<BarTable> GetAllActiveWithoutLocation()
        {
            try
            {
                return BarTablesRepository.GetAllActiveWithoutLocation();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<BarTable> GetAllActiveWithLocation()
        {
            try
            {
                return BarTablesRepository.GetAllActiveWithLocation();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<BarTable> GetAll()
        {
            try
            {
                return BarTablesRepository.GetAll();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static BarTable SaveOrUpdate(BarTable table)
        {
            try
            {
                return BarTablesRepository.SaveOrUpdate(table);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static void Remove(BarTable table)
        {
            try
            {
                BarTablesRepository.Remove(table);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static void RemoveDistribution(BarTable table)
        {
            try
            {
                BarTablesRepository.RemoveDistribution(table);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static bool HasSales(BarTable table)
        {
            try
            {
               return BarTablesRepository.HasSaleOrders(table);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static double GetSaleOrdersTotal(BarTable table)
        {
            try
            {
                return BarTablesRepository.GetSaleOrdersTotal(table);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}