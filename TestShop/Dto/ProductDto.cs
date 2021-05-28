namespace TestShop.Dto
{
    public class ProductDto
    {
        public virtual ModelDto Model { get; set; }

        public int Price { get; set; }

        public int Discount { get; set; }

        public string Category { get; set; }
    }
}