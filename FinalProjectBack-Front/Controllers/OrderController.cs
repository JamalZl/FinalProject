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

namespace FinalProjectBack_Front.Controllers
{
    [Authorize(Roles ="Member")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async  Task<IActionResult> Checkout()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return View();

            OrderVM order = new OrderVM
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                BasketItems=_context.BasketItems.Include(bi=>bi.Product).ThenInclude(p=>p.Campaign).Include(p=>p.Product).ThenInclude(p=>p.ProductImages).Where(bi=>bi.AppUserId==user.Id).ToList()
            };
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(OrderVM orderVM)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            OrderVM model = new OrderVM
            {
                Name = orderVM.Name,
                Surname=orderVM.Surname,
                Email = orderVM.Email,
                BasketItems = _context.BasketItems.Include(bi => bi.Product).ThenInclude(p => p.Campaign).Include(p => p.Product).ThenInclude(p => p.ProductImages).Where(bi => bi.AppUserId == user.Id).ToList()
            };
            if (!ModelState.IsValid) return View(model);



            TempData["Succeeded"] = false;

            if (model.BasketItems.Count == 0) return RedirectToAction("index", "home");
            Order order = new Order
            {
                Country = orderVM.Country,
                State = orderVM.State,
                Address = orderVM.Address,
                TotalPrice = 0,
                Date = DateTime.Now,
                AppUserId = user.Id
            };
            
            foreach (BasketItem item in model.BasketItems)
            {
                List<Product>  products = _context.Products.Where(p=>p.Id==item.ProductId).ToList();
                order.TotalPrice += item.Product.CampaignId == null ? item.Count * item.Product.Price : item.Count * item.Product.Price * (100 - item.Product.Campaign.DiscountPercent) / 100;
                OrderItem orderItem = new OrderItem
                {
                    Name = item.Product.Name,
                    Price = item.Product.CampaignId == null ? item.Count * item.Product.Price : item.Count * item.Product.Price * (100 - item.Product.Campaign.DiscountPercent) / 100,
                    Count=item.Count,
                    AppUserId = user.Id,
                    ProductId = item.Product.Id,
                    Order = order
                };
                foreach (var prod in products)
                {
                    prod.SellCount+=item.Count;
                }
                _context.OrderItems.Add(orderItem);
            }
            TempData["Succeeded"] = true;
            _context.BasketItems.RemoveRange(model.BasketItems);
            _context.Orders.Add(order);
            _context.SaveChanges();
            return RedirectToAction("index","home");
        }
    }
}
