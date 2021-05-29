namespace TestShop.Moduls
{
    public class Model
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}