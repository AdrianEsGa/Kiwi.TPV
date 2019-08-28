using System;
using System.Collections.Generic;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class StationController
    {
        public static Station GetByCode(int code)
        {
            try
            {
                return StationRepository.GetByCode(code);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<Station> GetAll()
        {
            try
            {
                return StationRepository.GetAll();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static void Update(Station station)
        {
            try
            {
                StationRepository.Update(station);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}