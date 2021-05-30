namespace TestShop.Dto.Response
{
    public class ProductResponse
    {
        public string Name { get; set; }

        public virtual BrandResponse Brand { get; set; }
        
        public virtual CategoryResponse Category { get; set; }

        public int Price { get; set; }

        public int Discount { get; set; }

    }
}