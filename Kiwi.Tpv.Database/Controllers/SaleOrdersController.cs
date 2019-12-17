using System;
using System.Collections.Generic;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class SaleOrdersController
    {


        public static List<SaleOrder> GetByTable(BarTable table, bool isPending)
        {
            try
            {
                return SaleOrdersRepository.GetByTable(table, isPending);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static SaleOrder GetByStationAndBar(Station station, bool isPending)
        {
            try
            {
                return SaleOrdersRepository.GetByStationAndBar(station, isPending);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<SaleOrder> GetAll(bool isPending)
        {
            try
            {
                return SaleOrdersRepository.GetAll(isPending);
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