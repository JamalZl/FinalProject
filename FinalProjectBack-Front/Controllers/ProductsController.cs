using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using FinalProjectBack_Front.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            ProductVM productVM = new ProductVM
            {
                Products = _context.Products.Include(p => p.ProductImages).ToList()
            };
            return View(productVM);
        }
        public  IActionResult Details(int id)
        {

            ProductVM productVM = new ProductVM
            {
                Product = _context.Products.Include(p => p.ProductImages).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Include(p => p.Brand).Include(p => p.Tag).Include(p => p.ProductCategories).ThenInclude(p => p.Category).Include(p => p.DescriptionImages).FirstOrDefault(p => p.Id == id),
                Products = _context.Products.Include(p => p.ProductImages).ToList()
            };
            return View(productVM);
        }
    }
}
