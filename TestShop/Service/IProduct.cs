using System.Collections.Generic;
using TestShop.Modules;

namespace TestShop.Service
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
    }
}