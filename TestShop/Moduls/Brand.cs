using System.Collections.Generic;

namespace TestShop.Moduls
{
    public class Brand
    {
        public int ID { get; set; }
        public string name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> Categorys { get; set; }
    }
}