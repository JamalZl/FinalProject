using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using FinalProjectBack_Front.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Areas.GeckoAdmin.Controllers
{
    [Area("GeckoAdmin")]
    [Authorize(Roles = "SuperAdmin")]

    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            AdminVM adminVM = new AdminVM
            {
                Products = _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.ProductImages).OrderByDescending(p => p.SellCount).Take(1).ToList(),
                UserMessages = _context.ContactMessages.OrderByDescending(cm => cm.SendDate).Take(1).ToList(),
                Orders = _context.Orders.Where(o => o.Status == true).ToList(),
                Users = _context.Users.ToList()
            };
            return View(adminVM);
        }
    }
}
