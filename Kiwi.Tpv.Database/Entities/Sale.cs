using System;
using System.Collections.Generic;
using System.Linq;

namespace Kiwi.Tpv.Database.Entities
{
    public class Sale
    {
        public Sale()
        {
            Id = 0;
            Details = new List<SaleDetail>();
        }

        public int Id { get; set; }
        public Station Station { get; set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public double Disscount { get; set; }
        public double Tax { get; set; }
        public PayType PayType { get; set; }
        public List<SaleDetail> Details { get; set; }
        public BarTable Table { get; set; }

        public double TotalPriceDetails()
        {
            return (Details.Sum(detail => detail.Total)) - Disscount;
        }

        public double GetTotalTax()
        {
            return Details.Sum(detail => detail.Tax);
        }

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

    public enum PayType
    {
        NoPaid = 0,
        Cash = 1,
        CreditCard = 2
    }

    public enum SaleMode
    {
        Day = 0,
        Night = 1
    }
}