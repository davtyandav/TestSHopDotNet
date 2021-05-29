namespace TestShop.Dto.Response
{
    public class ProductResponse
    {
        public virtual ModelResponse Model { get; set; }

        public int Price { get; set; }

        public int Discount { get; set; }

        public string Category { get; set; }
    }
}