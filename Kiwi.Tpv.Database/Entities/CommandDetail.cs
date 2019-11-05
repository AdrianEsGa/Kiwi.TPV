namespace Kiwi.Tpv.Database.Entities
{
    public class CommandDetail
    {
        public int Id { get; set; }
        public int CommandId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Product CombinedProduct { get; set; }
        public byte[] ProductImage => Product.Image;
        public byte[] CombinedProductImage => CombinedProduct?.Image;
    }
}
