namespace Kiwi.Tpv.Database.Entities
{
    public class WarehouseProductStock
    {
        public Company Company { get; set; }
        public Warehouse Warehouse { get; set; }
        public Product Product { get; set; }
        public double Stock { get; set; }
    }
}