using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategorySimulation.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgAddress { get; set; }
        public decimal Price { get; set; }
        public string Info { get; set; }
        public double Rating { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
