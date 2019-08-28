using System;

namespace Kiwi.Tpv.Database.Entities
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public DateTime Date { get; set; }
        public string AlbaranSeries { get; set; }
        public string AlbaranNumber { get; set; }
        public string AlaranYear { get; set; }
        public Employee Employee { get; set; }
        public string BillSeries { get; set; }
        public string BillNumber { get; set; }
        public string BillYear { get; set; }
        public double Total { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(Purchase other)
        {
            return PurchaseId == other.PurchaseId;
        }

        public override int GetHashCode()
        {
            return PurchaseId;
        }
    }
}