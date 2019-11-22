using System;
using System.Collections.Generic;
using Kiwi.Tpv.Database.DTOs;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class SalesController
    {

        public static List<Sale> GetPendingsByTable(BarTable table)
        {
            try
            {
                return SalesRepository.GetPendingsByTable(table);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static Sale GetPendingByStationAndBar(Station station)
        {
            try
            {
                return SalesRepository.GetPendingByStationAndBar(station);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static Sale SaveOrUpdate(Sale sale)
        {
            try
            {
               sale.Total = sale.TotalPriceDetails();
               sale.Date = DateTime.Now;
               sale.Tax = sale.GetTotalTax();
               return SalesRepository.SaveOrUpdate(sale);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static void SaveOrUpdateJoke(Sale sale)
        {
            try
            {
                sale.Total = sale.TotalPriceDetails();
                sale.Date = DateTime.Now;
                sale.Tax = sale.GetTotalTax();
                SalesRepository.SaveOrUpdateJoke(sale);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<ProductHistoryDto> GetTotalsByProduct(string stationIds, DateTime initDate, DateTime endDate)
        {
            try
            {
                return SalesRepository.GetTotalsByProduct(stationIds, initDate, endDate);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<EmployeeHistoryDto> GetTotalsByEmployee(string stationIds, DateTime initDate,
            DateTime endDate)
        {
            try
            {
                return SalesRepository.GetTotalsByEmployee(stationIds, initDate, endDate);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<double> GetTotals(string stationIds, DateTime initDate, DateTime endDate)
        {
            try
            {
                return SalesRepository.GetTotals(stationIds, initDate, endDate);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}