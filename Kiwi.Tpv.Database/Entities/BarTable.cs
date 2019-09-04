namespace Kiwi.Tpv.Database.Entities
{
    public class BarTable
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Location { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            return "(" + Code +") " + Name;
        }
    }
}
