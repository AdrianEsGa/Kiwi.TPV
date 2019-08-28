using System;

namespace Kiwi.Tpv.Database.Entities
{
    public class PurchaseDetail
    {
        public int PurchaseDetailId { get; set; }
        public Purchase Purchase { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public double Units { get; set; }
        public double UnitPrice { get; set; }
        public double Disscount { get; set; }
        public double TaxPercentaje { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(PurchaseDetail other)
        {
            return PurchaseDetailId == other.PurchaseDetailId;
        }

        public override int GetHashCode()
        {
            return PurchaseDetailId;
        }
    }
}