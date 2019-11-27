namespace Kiwi.Tpv.Database.Entities
{

    public class SaleOrderDetail
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(SaleDetail other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}