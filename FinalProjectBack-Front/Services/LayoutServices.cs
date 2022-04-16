using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using FinalProjectBack_Front.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<AppUser> _userManager;

        public LayoutServices(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public Setting GetSettingData()
        {
            Setting data = _context.Settings.FirstOrDefault();
            return data;
        }

        public List<FooterSocial> GetSocials()
        {
            List<FooterSocial> footerSocials = _context.FooterSocials.ToList();
            return footerSocials;
        }
        public List<Product> GetProducts()
        {
            List<Product> products = _context.Products.Include(p => p.ProductImages).ToList();
            return products;
        }

        public List<Brand> GetBrands()
        {
            List<Brand> brands = _context.Brands.ToList();
            return brands;
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }

        public List<Tag> GetTags()
        {
            List<Tag> tags = _context.Tags.ToList();
                return tags;
        }

        public async Task<BasketVM> ShowBasket()
        {
            string basket = _httpContextAccessor.HttpContext.Request.Cookies["Basket"];

            BasketVM basketData = new BasketVM
            {
                TotalPrice = 0,
                BasketItems = new List<BasketItemVM>(),
                Count = 0
            };

            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(_httpContextAccessor.HttpContext.User.Identity.Name);
                List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Where(b => b.AppUserId == user.Id).ToList();
                foreach (BasketItem item in basketItems)
                {
                    Product product = _context.Products.Include(p=>p.ProductImages).Include(p=>p.ProductCategories).ThenInclude(pc=>pc.Category).Include(p => p.Campaign).FirstOrDefault(f => f.Id == item.ProductId);
                    if (product != null)
                    {
                        BasketItemVM basketItemVM = new BasketItemVM
                        {
                            Product = product,
                            Count = item.Count
                        };
                        basketItemVM.Price = product.CampaignId == null ? product.Price : product.Price * (100 - product.Campaign.DiscountPercent) / 100;
                        basketData.BasketItems.Add(basketItemVM);
                        basketData.Count++;
                        basketData.TotalPrice += basketItemVM.Price * basketItemVM.Count;
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(basket))
                {
                    List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

                    foreach (BasketCookieItemVM item in basketCookieItems)
                    {
                        Product product = _context.Products.FirstOrDefault(p => p.Id == item.Id);
                        if (product != null)
                        {
                            BasketItemVM basketItem = new BasketItemVM
                            {
                                Product = _context.Products.Include(p => p.Campaign).Include(p => p.ProductImages).FirstOrDefault(p => p.Id == item.Id),
                                Count = item.Count
                            };

                            basketItem.Price = basketItem.Product.CampaignId == null ? basketItem.Product.Price : basketItem.Product.Price * (100 - basketItem.Product.Campaign.DiscountPercent) / 100;
                            basketData.BasketItems.Add(basketItem);
                            basketItem.Count++;
                            basketData.TotalPrice += basketItem.Price * basketItem.Count;
                            Math.Round(basketData.TotalPrice, 2);
                        }
                    }

                }
            }
           
            return basketData;
        }

        public async Task<WhishlistVM> GetWhishlist()
        {
            string whishlist = _httpContextAccessor.HttpContext.Request.Cookies["Whishlist"];

            WhishlistVM whishlistData = new WhishlistVM
            {
                WhishlistItems = new List<WhishlistItemVM>(),
                Count = 0
            };
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(_httpContextAccessor.HttpContext.User.Identity.Name);
                List<WhishlistItem> whishlistItems = _context.WhishlistItems.Include(b => b.AppUser).Where(b => b.AppUserId == user.Id).ToList();
                foreach (WhishlistItem item in whishlistItems)
                {
                    Product product = _context.Products.Include(p => p.ProductImages).Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).FirstOrDefault(f => f.Id == item.ProductId);
                    if (product != null)
                    {
                        WhishlistItemVM whishlistItemVM = new WhishlistItemVM
                        {
                            Product = product,
                            Count = item.Count
                        };
                        whishlistItemVM.Price = product.CampaignId == null ? product.Price : product.Price * (100 - product.Campaign.DiscountPercent) / 100;
                        whishlistData.WhishlistItems.Add(whishlistItemVM);
                        whishlistData.Count++;
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(whishlist))
                {
                    List<WhislistCookieItemVM> whislistCookieItems = JsonConvert.DeserializeObject<List<WhislistCookieItemVM>>(whishlist);

                    foreach (WhislistCookieItemVM item in whislistCookieItems)
                    {
                        Product product = _context.Products.Include(p=>p.ProductImages).Include(p=>p.ProductCategories).ThenInclude(pc=>pc.Category).FirstOrDefault(p => p.Id == item.Id);
                        if (product != null)
                        {
                            WhishlistItemVM whishlistItem = new WhishlistItemVM
                            {
                                Product = _context.Products.Include(p => p.Campaign).Include(p => p.ProductImages).FirstOrDefault(p => p.Id == item.Id),
                                Count = item.Count
                            };

                            whishlistItem.Price = whishlistItem.Product.CampaignId == null ? whishlistItem.Product.Price : whishlistItem.Product.Price * (100 - whishlistItem.Product.Campaign.DiscountPercent) / 100;
                            whishlistData.WhishlistItems.Add(whishlistItem);
                            whishlistItem.Count++;
                        }
                    }

                }
            }
            return whishlistData;
        }
    }
}
