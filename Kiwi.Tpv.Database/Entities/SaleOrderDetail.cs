using System.Collections.Generic;

namespace Kiwi.Tpv.Database.Entities
{

    public class SaleOrderDetail
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string PriceString => Price.ToString("F");
        public double TaxPercentaje { get; set; }
        public bool IsBottle { get; set; }
        public double Total => Price * Quantity;
        public byte[] ProductImage => Product.Image;
        public string TotalString => Total.ToString("F");

        public SaleOrderDetail Copy()
        {
            return new SaleOrderDetail()
            {
                Product = Product,
                Price = Price,
                TaxPercentaje = TaxPercentaje,
                IsBottle = IsBottle                         
            };
        }

        public bool Equals(SaleOrderDetail other)
        {
            return Equals(Product, other.Product) && Price.Equals(other.Price) && TaxPercentaje.Equals(other.TaxPercentaje) && IsBottle == other.IsBottle;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SaleOrderDetail) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Product != null ? Product.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Price.GetHashCode();
                hashCode = (hashCode * 397) ^ TaxPercentaje.GetHashCode();
                hashCode = (hashCode * 397) ^ IsBottle.GetHashCode();
                return hashCode;
            }
        }

    }
}