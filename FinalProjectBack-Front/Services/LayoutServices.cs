﻿using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using FinalProjectBack_Front.ViewModels;
using Microsoft.AspNetCore.Http;
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

        public LayoutServices(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
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

        public BasketVM ShowBasket()
        {
            string basket = _httpContextAccessor.HttpContext.Request.Cookies["Basket"];

            BasketVM basketData = new BasketVM
            {
                TotalPrice = 0,
                BasketItems = new List<BasketItemVM>(),
                Count = 0
            };

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
                        Math.Round(basketData.TotalPrice, 3);
                    }
                }

            }
            return basketData;
        }
    }
}
