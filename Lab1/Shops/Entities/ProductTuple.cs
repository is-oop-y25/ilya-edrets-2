namespace Shops.Entities
{
    internal interface ProductTuple
    {
        public Product Product { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }
    }
}
