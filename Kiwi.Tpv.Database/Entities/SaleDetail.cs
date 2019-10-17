namespace Kiwi.Tpv.Database.Entities
{

    public class SaleDetail
    {
        public int Id { get; set; }
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double SubTotal { get; set; }
        public double TaxPercentaje { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
        public bool IsBottle { get; set; }
        public byte[] ProductImage => Product.Image;
        public string TotalString => Total.ToString("F");


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