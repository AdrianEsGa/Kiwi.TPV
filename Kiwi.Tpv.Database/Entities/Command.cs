using System;
using System.Collections.Generic;

namespace Kiwi.Tpv.Database.Entities
{
    public class Command
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public byte[] EmployeeImage => Employee.Image;
        public BarTable Table { get; set; }
        public Station Station { get; set; }
        public DateTime Date { get; set; }
        public CommandStatus Status { get; set; }
        public List<CommandDetail> Details { get; set; }
    }

    public enum CommandStatus
    {
        Pendiente = 0,
        EnProceso = 1,
        Finalizado = 2,
        Servido = 3
    }
}
