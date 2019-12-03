using System;
using System.Collections.Generic;
using Kiwi.Tpv.Database.DTOs;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public class SalesController
    {

        private readonly bool _jokeSystemActive;
        private int _jokeSystemCounter;
        private readonly int _jokeSystemInterval;

        public bool PrintTicket { get; set; }
        public bool OpenCashDrawer { get; set; }

        public SalesController(bool jokeSystemActive, int jokeSystemInterval)
        {
            _jokeSystemActive = jokeSystemActive;
            _jokeSystemCounter = 0;
            _jokeSystemInterval = jokeSystemInterval;
        }

        public Sale MakeSale(SaleOrder saleOrderToPay, SaleOrder pendingSaleOrder, bool printTicket)
        {

            try
            {
                var sale = Map(saleOrderToPay);

                var isJoke = false;

                if (IsPosibleToMakeJokeSale(saleOrderToPay, printTicket))
                {
                    if (_jokeSystemCounter == _jokeSystemInterval)
                        isJoke = true;
                    else _jokeSystemCounter++;
                }

                if (isJoke)
                {
                    SalesRepository.SaveOrUpdateJoke(sale);
                    _jokeSystemCounter = 1;
                }
                else
                {
                    SalesRepository.SaveOrUpdate(sale);
                }

                if(pendingSaleOrder == null)
                   SaleOrdersController.Remove(saleOrderToPay);
                else SaleOrdersController.SaveOrUpdate(pendingSaleOrder);

                PrintTicket = printTicket && !isJoke;
                OpenCashDrawer = Math.Abs(sale.Total) > 0 && sale.PayType == PayType.Cash;

                return sale;
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        private Sale Map(SaleOrder saleOrder)
        {
            try
            {
                var sale = new Sale
                {
                    Station = saleOrder.Station,
                    Date = DateTime.Now,
                    Disscount = saleOrder.Disscount,
                    Employee = saleOrder.Employee,
                    PayType = saleOrder.PayType,
                    Table = saleOrder.Table
                };

                foreach (var saleOrderDetail in saleOrder.Details)
                {
                    var saleDetail = new SaleDetail
                    {
                        Sale = sale,
                        IsBottle = saleOrderDetail.IsBottle,
                        Price = saleOrderDetail.Price,
                        Product = saleOrderDetail.Product,
                        Quantity = saleOrderDetail.Quantity,
                        TaxPercentaje = saleOrderDetail.TaxPercentaje,
                        Total = saleOrderDetail.Quantity * saleOrderDetail.Price,

                    };
                    sale.Details.Add(saleDetail);
                }

                sale.Tax = Math.Round(sale.GetTotalTax(), 2);
                sale.Total = Math.Round(sale.TotalPriceDetails(), 2);

                return sale;
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        private bool IsPosibleToMakeJokeSale(SaleOrder saleOrder, bool printTicket)
        {
            return _jokeSystemActive && saleOrder.PayType == PayType.Cash &&
                   saleOrder.Total > 0 && !printTicket;
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