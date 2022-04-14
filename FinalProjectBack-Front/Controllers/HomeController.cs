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
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                FooterSocials = _context.FooterSocials.ToList(),
                Categories = _context.Categories.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Brands = _context.Brands.ToList(),
                Products = _context.Products.Include(p => p.ProductImages).Take(4).ToList(),
                Tags=_context.Tags.ToList(),
                Sliders=_context.Sliders.ToList()
            };

            return View(homeVM);
        }

        public IActionResult Search(string keyword)
        {
            List<Product> products = _context.Products.Include(p => p.ProductImages).Include(p => p.Brand).Where(p => p.Name.Trim().ToLower().Contains(keyword.Trim().ToLower()) || p.Brand.Name.ToLower().Trim().Contains(keyword.Trim().ToLower())).ToList();
            return PartialView("_SearchPartialView", products);
        }
    }
}
