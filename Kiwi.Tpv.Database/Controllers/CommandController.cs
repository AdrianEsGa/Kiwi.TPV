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

        public static List<Command> GetPendingAndInProcessOrFinalizedWithStation(Station station)
        {          
            try
            {
                return CommandRepository.GetPendingAndInProcessOrFinalizedWithStation(station);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}
