namespace Kiwi.Tpv.Database.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Cif { get; set; }
        public byte[] AppLogo { get; set; }
        public byte[] ReportsLogo { get; set; }
        public byte[] LocalImage { get; set; }
        public bool CombinationControl { get; set; }
        public bool CombinationControlWithSoda { get; set; }
        public string TicketReport { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(Company other)
        {
            return CompanyId == other.CompanyId;
        }

        public override int GetHashCode()
        {
            return CompanyId;
        }
    }
}