namespace Kiwi.Tpv.Database.Entities
{
    public class Warehouse
    {
        private int WarehouseId { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(Warehouse other)
        {
            return WarehouseId == other.WarehouseId;
        }

        public override int GetHashCode()
        {
            return WarehouseId;
        }
    }
}