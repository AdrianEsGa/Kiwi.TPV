using System;
using System.Collections.Generic;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class TaxTypeController
    {
        public static List<TaxType> GetAll()
        {
            try
            {
                return TaxTypeRepository.GetAll();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}