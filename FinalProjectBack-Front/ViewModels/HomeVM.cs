using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.ViewModels
{
    public class HomeVM
    {
        //private readonly AppDbContext _context;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        //public HomeVM(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        //{
        //    _context = context;
        //    _httpContextAccessor = httpContextAccessor;
        //}
        public Setting Setting { get; set; }
        public List<FooterSocial> FooterSocials { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Slider> Sliders { get; set; }

        //public BasketVM ShowBasket()
        //{
        //    string basket = _httpContextAccessor.HttpContext.Request.Cookies["Basket"];

        //    BasketVM basketData = new BasketVM
        //    {
        //        TotalPrice = 0,
        //        BasketItems = new List<BasketItemVM>(),
        //        Count = 0
        //    };

        //    if (!string.IsNullOrEmpty(basket))
        //    {
        //        List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

        //        foreach (BasketCookieItemVM item in basketCookieItems)
        //        {
        //            Product product = _context.Products.FirstOrDefault(p => p.Id == item.Id);
        //            if (product != null)
        //            {
        //                BasketItemVM basketItem = new BasketItemVM
        //                {
        //                    Product = _context.Products.Include(p => p.Campaign).Include(p => p.ProductImages).FirstOrDefault(p => p.Id == item.Id),
        //                    Count = item.Count
        //                };

        //                basketItem.Price = basketItem.Product.CampaignId == null ? basketItem.Product.Price : basketItem.Product.Price * (100 - basketItem.Product.Campaign.DiscountPercent) / 100;
        //                basketData.BasketItems.Add(basketItem);
        //                basketItem.Count++;
        //                basketData.TotalPrice += basketItem.Price * basketItem.Count;
        //                Math.Round(basketData.TotalPrice, 3);
        //            }
        //        }

        //    }
        //    return basketData;
        //}
    }
}
