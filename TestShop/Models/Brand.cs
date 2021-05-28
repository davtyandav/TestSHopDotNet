using System.Collections.Generic;

namespace TestShop.Modules
{
    public class Brand
    {
        public int ID { get; set; }
        public string name { get; set; }
        public virtual ICollection<Model> models { get; set; }
    }
}