namespace TestShop.Dto.Requset
{
    public class ProductRequset
    {
        public string Name { get; set; }
        
        public int BrandId { get; set; }

        public int Price { get; set; }

        public int Discount { get; set; }

        public int CategoryId { get; set; }
    }
}