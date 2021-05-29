using System.Collections.Generic;
using TestShop.Moduls;

namespace TestShop.Service
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
    }
}