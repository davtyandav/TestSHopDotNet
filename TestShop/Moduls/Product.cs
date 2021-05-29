namespace TestShop.Moduls
{
    public class Product
    {
        public int Id { get; set; }

        public int ModelId { get; set; }
        public virtual Model Model { get; set; }

        public int Price { get; set; }

        public int Discount { get; set; }

        public Category Category { get; set; }
    }
}