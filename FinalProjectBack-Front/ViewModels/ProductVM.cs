using FinalProjectBack_Front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.ViewModels
{
    public class ProductVM
    {
        public List<Product> Products { get; set; }
        public List<Product> ProductByBrands { get; set; }
        public List<Product> ProductByCategories { get; set; }
        public List<Product> ProductByTags { get; set; }
        public Product Product { get; set; }
    }
}
