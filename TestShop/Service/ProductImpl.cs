using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestShop.Moduls;

namespace TestShop.Service
{
    public class ProductImpl : IProduct
    {
        private readonly DataContext _dataContext;


        public ProductImpl(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dataContext.Products
                .Include(product => product.Model)
                .ThenInclude(model => model.Brand);
        }

        public Product GetProduct(int id)
        {
            return _dataContext.Products.Include(product => product.Model)
                .ThenInclude(model => model.Brand)
                .FirstOrDefault(c => c.Id == id);
        }
    }
}