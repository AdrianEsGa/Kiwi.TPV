using System;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class AppCommonController
    {
        public static AppGeneralConfig Get()
        {
            try
            {
                return AppCommonRepository.Get();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static void SaveOrUpdate(AppGeneralConfig appGeneralConfig)
        {
            try
            {
                AppCommonRepository.SaveOrUpdate(appGeneralConfig);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}