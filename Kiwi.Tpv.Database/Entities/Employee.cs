namespace Kiwi.Tpv.Database.Entities
{
    public class Employee
    {
        public Employee()
        {
            Id = 0;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public byte[] Image { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(Employee other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}