namespace CSharpProject04Data.Common
{
    public class Product
    {
        public int DetailId { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Taxable { get; set; }
        public decimal Extension { get { return Quantity * Price; } }
    }
}
