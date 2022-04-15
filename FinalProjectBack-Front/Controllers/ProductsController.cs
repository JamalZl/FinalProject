using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using FinalProjectBack_Front.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
            ViewBag.Sizes = _context.Sizes.Include(s => s.ProductSizes).ThenInclude(ps => ps.Product).ToList();
            ProductVM productVM = new ProductVM
            {
                Products = _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).Where(p => p.IsDeleted == false).ToList()
            };
            return View(productVM);
        }
        public IActionResult Details(int id, int categoryId)
        {
            ProductVM productVM = new ProductVM
            {
                Product = _context.Products.Include(p => p.Campaign).Include(p => p.ProductImages).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Include(p => p.Brand).Include(p => p.Tag).Include(p => p.ProductCategories).ThenInclude(p => p.Category).Include(p => p.DescriptionImages).Where(p => p.IsDeleted == false).FirstOrDefault(p => p.Id == id),
                Products = _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).ToList(),
                RelatedProducts = _context.Products.Include(p => p.ProductImages).Include(p => p.Campaign).Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Where(p => p.ProductCategories.Any(pc => pc.CategoryId == categoryId && p.Id != id)).Where(p => p.IsDeleted == false).Take(8).ToList()
            };
            if (productVM == null) return NotFound();
            return View(productVM);
        }

        public IActionResult PriceSearch(int minPrice, int maxPrice, List<string> sizes)
        {
            //var min = int.Parse(minPrice);
            //var max = int.Parse(maxPrice);
            var sizeArr=sizes.ToArray();
            ViewBag.Sizes = _context.Sizes.Include(s => s.ProductSizes).ThenInclude(ps => ps.Product).ThenInclude(p => p.ProductImages).OrderBy(s => s.Value).ToList();
            List<Product> products = _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).Where(p => (minPrice <= p.Price * (100 - p.Campaign.DiscountPercent) / 100 && p.Price * (100 - p.Campaign.DiscountPercent) / 100 <= maxPrice) || (sizeArr.Contains(p.ProductSizes.FirstOrDefault().Size.Value))).ToList();
            return PartialView("_ProductPartialView", products);

        }


        public IActionResult AddBasket(int id)
        {
            Product product = _context.Products.Include(p => p.ProductImages).Include(p => p.Campaign).FirstOrDefault(p => p.Id == id);

            string basket = HttpContext.Request.Cookies["Basket"];

            if (basket == null)
            {
                List<BasketCookieItemVM> basketCookieItems = new List<BasketCookieItemVM>();

                basketCookieItems.Add(new BasketCookieItemVM
                {
                    Id = product.Id,
                    Count = 0
                });

                string basketStr = JsonConvert.SerializeObject(basketCookieItems);

                HttpContext.Response.Cookies.Append("Basket", basketStr);
            }
            else
            {
                List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

                BasketCookieItemVM cookieItem = basketCookieItems.FirstOrDefault(b => b.Id == product.Id);

                if (cookieItem == null)
                {
                    cookieItem = new BasketCookieItemVM
                    {
                        Id = product.Id,
                        Count = 0
                    };
                    basketCookieItems.Add(cookieItem);
                }
                else
                {
                    cookieItem.Count++;
                }

                string basketStr = JsonConvert.SerializeObject(basketCookieItems);

                HttpContext.Response.Cookies.Append("Basket", basketStr);
            }

            return RedirectToAction("index", "products");
        }

        //public IActionResult Delete(int id)
        //{
        //    //Product product = _context.Products.Include(p => p.ProductImages).Include(p => p.Campaign).FirstOrDefault(p => p.Id == id);

        //    string basket = HttpContext.Request.Cookies["Basket"];
        //    List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);


        //    if (cookieStr==null)
        //    {
        //        return NotFound();
        //    }



        //}

        public IActionResult GetBrands(int id)
        {
            ProductVM productVM = new ProductVM
            {
                ProductByBrands = _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).Include(p => p.Brand).Where(p => p.BrandId == id && p.IsDeleted == false).ToList()
            };
            return View(productVM);
        }
        public IActionResult GetCategories(int id)
        {
            ViewBag.Categories = _context.ProductCategories.Include(pc => pc.Category).FirstOrDefault(pc => pc.CategoryId == id);
            ProductVM productVM = new ProductVM
            {
                ProductByCategories = _context.Products.Include(p => p.Campaign).Include(p => p.ProductImages).Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Where(p => p.ProductCategories.Any(pc => pc.CategoryId == id)).Where(p => p.IsDeleted == false).ToList()
            };
            return View(productVM);
        }

        public IActionResult GetTags(int id)
        {
            ProductVM productVM = new ProductVM
            {
                ProductByTags = _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).Include(p => p.Tag).Where(p => p.TagId == id).Where(p => p.IsDeleted == false).ToList()
            };
            return View(productVM);
        }

        public IActionResult GetSale()
        {
            ProductVM productVM = new ProductVM
            {
                ProductBySale = _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).Where(p => p.CampaignId != null).Where(p => p.IsDeleted == false).ToList()
            };
            return View(productVM);
        }

        public IActionResult GetNewArrival()
        {
            ProductVM productVM = new ProductVM
            {
                ProductByNewArrival = _context.Products.Include(p => p.ProductCategories).ThenInclude(p => p.Category).Include(p => p.Campaign).Include(p => p.ProductImages).OrderByDescending(p => p.Id).Where(p => p.IsDeleted == false).Take(12).ToList()
            };
            return View(productVM);
        }

    }
}
