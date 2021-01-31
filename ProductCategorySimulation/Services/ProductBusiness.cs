using ProductCategorySimulation.Data;
using ProductCategorySimulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategorySimulation.Services
{
    public class ProductBusiness
    {
        ProductCategoryDbContext dbContext = new ProductCategoryDbContext();

        public List<Product> ShowProducts()
        {
            return dbContext.Products.ToList();
        }

        public void Add(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return dbContext.Products.Find(id);
        }

        public void Edit(Product product)
        {
            dbContext.Entry(product).State =
            Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
     
        }

        public void Remove(Product product)
        {
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
        }
    }
}
