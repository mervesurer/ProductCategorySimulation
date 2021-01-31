using ProductCategorySimulation.Data;
using ProductCategorySimulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategorySimulation.Services
{
    public class CategoryBusiness
    {
        ProductCategoryDbContext dbContext = new ProductCategoryDbContext();

        public List<Category> ShowCategories()
        {
            return dbContext.Categories.ToList();
        }

        public string Add(Category category)
        {
            string result = "";

            foreach (var item in dbContext.Categories)
            {
                if (category.Name.ToLower().Equals(item.Name.ToLower()))
                {
                    result = "Eklemek istediğiniz kategori zaten mevcut!";
                    return result;
                }
            }

            dbContext.Add<Category>(category);
            dbContext.SaveChanges();

            result = "Kategori başarıyla eklendi";

            return result;
        }

        public Category GetCategoryById(int id)
        {
            return dbContext.Categories.Find(id);
        }

        public void Edit(Category category)
        {
            dbContext.Entry(category).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public string Remove(Category category)
        {
            string result = ""; 

            if (!CategoryStatus(category))
            {
                result = "Bu kategoriye sahip ürünler mevcuttur, kategori silinemez!";
                return result;
            }

            dbContext.Remove<Category>(category);
            dbContext.SaveChanges();

            result = "Kategori başarıyla silindi!";

            return result;
        }

        private bool CategoryStatus(Category category)
        {
            foreach(var product in dbContext.Products)
            {
                if(product.CategoryId == category.Id)
                {
                    return false; 
                }
            }

            return true;
        }
    }
}
