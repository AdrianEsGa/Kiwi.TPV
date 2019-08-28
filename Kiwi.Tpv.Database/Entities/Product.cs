namespace Kiwi.Tpv.Database.Entities
{
    public class Product
    {
        public Product()
        {
            Id = 0;
            SaleTaxType = new TaxType {Percentaje = 10};
            PurchaseTaxType = new TaxType {Percentaje = 10};
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public TaxType SaleTaxType { get; set; }
        public double PurchasePrice { get; set; }
        public TaxType PurchaseTaxType { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public ProductType Type { get; set; }
        public ProductSubType SubType { get; set; }
        public bool Active { get; set; }
        public double SaleUnits { get; set; }
        public double PurchaseUnits { get; set; }
        public double SaleDayPrice { get; set; }
        public double SaleNightPrice { get; set; }
        public bool ShowInMainView { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(Product other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public enum ProductType
    {
        Alcohol = 1,
        Refresco = 2,
        Cerveza = 3,
        Varios = 4,
        Botella = 5,
        Cafes = 6,
        Tes = 7,
        Cocktails = 8,
        Infusiones = 9,
        Vinos = 10
    }

    public enum ProductSubType
    {     
        Whisky = 1,
        Ron = 2,
        Ginebra = 3,
        Vodka = 4,
        Generico = 9999,
    }
}