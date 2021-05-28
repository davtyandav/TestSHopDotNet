using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestShop.Modules;

namespace TestShop.Service
{
    public class ProductImpl : IProduct
    {
        private readonly DataContext dataContext;


        public ProductImpl(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return dataContext.Products
                .Include(product => product.Model)
                .ThenInclude(model => model.Brand);
        }

        public Product GetProduct(int id)
        {
            return dataContext.Products.Include(product => product.Model)
                .ThenInclude(model => model.Brand)
                .FirstOrDefault(c => c.Id == id);
        }
    }
}