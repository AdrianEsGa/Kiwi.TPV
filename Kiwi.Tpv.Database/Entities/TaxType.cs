using System.Globalization;

namespace Kiwi.Tpv.Database.Entities
{
    public class TaxType
    {
        public double Percentaje { get; set; }

        public override string ToString()
        {
            return Percentaje.ToString(CultureInfo.InvariantCulture);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(TaxType other)
        {
            return Percentaje.Equals(other.Percentaje);
        }

        public override int GetHashCode()
        {
            return Percentaje.GetHashCode();
        }
    }
}