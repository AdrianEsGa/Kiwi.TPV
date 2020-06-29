namespace Kiwi.Tpv.Database.Entities
{
    public class Station
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string PrintterComPort { get; set; }
        public bool ShowSaleOrderTicket { get; set; }
        public bool ShowAnimations { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(Station other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}