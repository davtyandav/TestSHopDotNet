using System.Collections;
using System.Collections.Generic;

namespace TestShop.Moduls
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int BrandId { get; set; }

        public virtual List<Brand> Brands{ get; set; }
    }
}