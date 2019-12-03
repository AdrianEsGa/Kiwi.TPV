using System;
using System.Collections.Generic;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class SaleOrdersController
    {


        public static List<SaleOrder> GetPendingsByTable(BarTable table)
        {
            try
            {
                return SaleOrdersRepository.GetPendingsByTable(table);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static SaleOrder GetPendingByStationAndBar(Station station)
        {
            try
            {
                return SaleOrdersRepository.GetPendingByStationAndBar(station);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static SaleOrder SaveOrUpdate(SaleOrder saleOrder)
        {
            try
            {
               return SaleOrdersRepository.SaveOrUpdate(saleOrder);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static SaleOrder GetById(int id)
        {
            try
            {
                return SaleOrdersRepository.GetById(id);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static void Remove(SaleOrder saleOrder)
        {
            try
            {
                SaleOrdersRepository.Remove(saleOrder);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}