using System;
using System.Collections.Generic;

namespace Kiwi.Tpv.Database.Entities
{
    public class SaleOrder
    {
        public int Id { get; set; }
        public Station Station { get; set; }
        public DateTime Date { get; set; }
        public BarTable Table { get; set; }
        public List<SaleOrderDetail> Details { get; set; }
     
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(Sale other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

}