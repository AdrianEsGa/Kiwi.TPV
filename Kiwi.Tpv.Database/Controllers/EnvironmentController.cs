using Kiwi.Tpv.Database.Repositories;
using System;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class EnvironmentController
    {
        public static DateTime GetServerDate()
        {
            try
            {
                return SystemRepository.GetServerDate();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static void Insert(byte[] value)
        {
            try
            {
                SystemRepository.Insert(value);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}
