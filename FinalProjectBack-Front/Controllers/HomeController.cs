using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
                Setting = _context.Settings.FirstOrDefault(),
                Brands = _context.Brands.ToList()
            };

            return View(homeVM);
        }
    }
}
