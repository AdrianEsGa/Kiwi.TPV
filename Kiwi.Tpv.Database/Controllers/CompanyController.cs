using System;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class CompanyController
    {
        public static void SaveOrUpdate(Company company)
        {
            try
            {
                CompanyRepository.SaveOrUpdate(company);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static Company GetById(Company company)
        {
            try
            {
                return CompanyRepository.GetById(company.CompanyId);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}