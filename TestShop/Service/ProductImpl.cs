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
            _dataContext = dataContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dataContext.Products
                .Include(product => product.Brand)
                .Include(b => b.Category);
        }

        public Product GetProduct(int id)
        {
            return _dataContext.Products
                .Include(product => product.Brand)
                .Include(b => b.Category)
                .FirstOrDefault(c => c.Id == id);
        }

        public void AddProduct(Product product)
        {
           
            
            _dataContext.Products.Add(product);
            _dataContext.SaveChanges();
        }
    }
}