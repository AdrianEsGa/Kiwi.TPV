using System;
using System.Collections.Generic;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;

namespace Kiwi.Tpv.Database.Controllers
{
    public static class CommandController
    {
        public static void Update(Command command)
        {
            try
            {
                CommandRepository.Update(command);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<Command> GetPendingOrInProcessWithStation(Station station)
        {          
            try
            {
                return CommandRepository.GetPendingOrInProcessWithStation(station);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static bool HastPendingOrInProcessWithStation(Station station)
        {
            try
            {
                return CommandRepository.HasGetPendingOrInProcessWithStation(station);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}
