﻿namespace TestShop.Moduls
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public int Price { get; set; }

        public int Discount { get; set; }
        
        public int CategoryId { get; set; }
        
        public virtual Category Category { get; set; }
    }
}