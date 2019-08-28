using System;
using System.Collections.Generic;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class ProductController
    {
        public static List<Product> GetAllActive()
        {
            try
            {
                return ProductRepository.GetAllActive();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<Product> GetAll()
        {
            try
            {
                return ProductRepository.GetAll();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<Product> GetAllActive(ProductType type)
        {
            try
            {
                return ProductRepository.GetAllActive(type);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<Product> GetAllActiveAndNotShowInMainView(ProductType type)
        {
            try
            {
                return ProductRepository.GetAllActiveAndNotShowInMainView(type);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static Product SaveOrUpdate(Product product)
        {
            try
            {
                return ProductRepository.SaveOrUpdate(product);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static void Remove(Product product)
        {
            try
            {
                ProductRepository.Remove(product);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}