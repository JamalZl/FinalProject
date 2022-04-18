using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using FinalProjectBack_Front.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> _userManager;

        public ProductsController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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
                RelatedProducts = _context.Products.Include(p => p.ProductImages).Include(p => p.Campaign).Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Where(p => p.ProductCategories.Any(pc => pc.CategoryId == categoryId && p.Id != id)).Where(p => p.IsDeleted == false).Take(8).ToList(),
                Comments = _context.Comments.Include(c => c.Product).Include(c => c.AppUser).Where(c => c.ProductId == id).ToList(),
                CheapProducts = _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).OrderBy(p => (p.CampaignId != null ? (p.Price - (p.Price * p.Campaign.DiscountPercent) / 100) : p.Price)).Take(8).ToList(),
            };
            if (productVM.Product == null) return NotFound();
            return View(productVM);
        }

        public IActionResult PriceSearch(int minPrice, int maxPrice)
        {
            //var min = int.Parse(minPrice);
            //var max = int.Parse(maxPrice);
            List<Product> products = _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).Where(p => (p.CampaignId != null && minPrice <= (p.Price - (p.Price * p.Campaign.DiscountPercent) / 100) && (p.Price - (p.Price * p.Campaign.DiscountPercent) / 100 <= maxPrice)) || (p.CampaignId == null && p.Price >= minPrice && p.Price <= maxPrice)).ToList();
            return PartialView("_ProductPartialView", products);


        }


        public async Task<IActionResult> AddBasket(int id, string colorval, string sizeval, int count)
        {
            Product product = _context.Products.Include(p => p.ProductImages).Include(p => p.Campaign).FirstOrDefault(p => p.Id == id);

            if ((colorval == null && sizeval != null) || (colorval != null && sizeval == null) || (colorval == null && sizeval == null))
            {
                return NotFound();
            }
            if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                //((b.Size == sizeval && b.Color != colorval) || (b.Size != sizeval && b.Color == colorval) || (b.Size != sizeval && b.Color != colorval))
                BasketItem basketItem = _context.BasketItems.FirstOrDefault(b => b.ProductId == product.Id && b.AppUserId == user.Id);
                if (basketItem == null)
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        ProductId = product.Id,
                        Count = count,
                        Color = colorval,
                        Size = sizeval
                    };
                    _context.BasketItems.Add(basketItem);
                }
                else
                {
                    basketItem.Count += count;
                }
                _context.SaveChanges();
                return PartialView("_BasketPartialView");
            }
            else
            {
                string basket = HttpContext.Request.Cookies["Basket"];

                if (basket == null)
                {
                    List<BasketCookieItemVM> basketCookieItems = new List<BasketCookieItemVM>();

                    basketCookieItems.Add(new BasketCookieItemVM
                    {
                        Id = product.Id,
                        Count = 1
                    });

                    string basketStr = JsonConvert.SerializeObject(basketCookieItems);

                    HttpContext.Response.Cookies.Append("Basket", basketStr);
                    return PartialView("_BasketPartialView");

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
                            Count = 1
                        };
                        basketCookieItems.Add(cookieItem);
                    }
                    else
                    {
                        cookieItem.Count++;
                    }

                    string basketStr = JsonConvert.SerializeObject(basketCookieItems);

                    HttpContext.Response.Cookies.Append("Basket", basketStr);

                    return PartialView("_BasketPartialView");
                }
            }

        }


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

        public IActionResult GetPartial()
        {
            return PartialView("_BasketPartialView");
        }

        public async Task<IActionResult> AddWhishlist(int id)
        {
            Product product = _context.Products.Include(p => p.ProductImages).Include(p => p.Campaign).FirstOrDefault(p => p.Id == id);

            if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                WhishlistItem whishlistItem = _context.WhishlistItems.FirstOrDefault(b => b.ProductId == product.Id && b.AppUserId == user.Id);
                if (whishlistItem == null)
                {
                    whishlistItem = new WhishlistItem
                    {
                        AppUserId = user.Id,
                        ProductId = product.Id,
                        Count = 1
                    };
                    _context.WhishlistItems.Add(whishlistItem);
                }
                else
                {
                    whishlistItem.Count++;
                }
                _context.SaveChanges();
                return PartialView("_WhishlistPartialView");
            }
            else
            {
                string whishlist = HttpContext.Request.Cookies["Whishlist"];

                if (whishlist == null)
                {
                    List<WhislistCookieItemVM> whislistCookieItems = new List<WhislistCookieItemVM>();

                    whislistCookieItems.Add(new WhislistCookieItemVM
                    {
                        Id = product.Id,
                        Count = 0
                    });

                    string whishlistStr = JsonConvert.SerializeObject(whislistCookieItems);

                    HttpContext.Response.Cookies.Append("Whishlist", whishlistStr);
                    return PartialView("_WhishlistPartialView");

                }
                else
                {
                    List<WhislistCookieItemVM> whislistCookieItems = JsonConvert.DeserializeObject<List<WhislistCookieItemVM>>(whishlist);

                    WhislistCookieItemVM cookieItem = whislistCookieItems.FirstOrDefault(b => b.Id == product.Id);

                    if (cookieItem == null)
                    {
                        cookieItem = new WhislistCookieItemVM
                        {
                            Id = product.Id,
                            Count = 0
                        };
                        whislistCookieItems.Add(cookieItem);
                    }
                    else
                    {
                        cookieItem.Count++;
                    }

                    string whishlistStr = JsonConvert.SerializeObject(whislistCookieItems);

                    HttpContext.Response.Cookies.Append("Whishlist", whishlistStr);

                    return PartialView("_WhishlistPartialView");
                }
            }
        }

        public IActionResult GetWhishlistPartial()
        {
            return PartialView("_WhishlistPartialView");
        }

        public async Task<IActionResult> DeleteWhishListItem(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                List<WhishlistItem> whishlistItems = _context.WhishlistItems.Where(b => b.ProductId == id && b.AppUserId == user.Id).ToList();
                foreach (var item in whishlistItems)
                {
                    _context.WhishlistItems.Remove(item);
                }
            }
            else
            {
                string basket = HttpContext.Request.Cookies["Whishlist"];

                List<WhislistCookieItemVM> whislistCookieItems = JsonConvert.DeserializeObject<List<WhislistCookieItemVM>>(basket);

                WhislistCookieItemVM cookieItem = whislistCookieItems.FirstOrDefault(c => c.Id == id);


                whislistCookieItems.Remove(cookieItem);

                string whishlistStr = JsonConvert.SerializeObject(whislistCookieItems);

                HttpContext.Response.Cookies.Append("Whishlist", whishlistStr);

            }
            _context.SaveChanges();
            return PartialView("_WhishlistPartialView");
        }

        public async Task<IActionResult> DeleteBasketItem(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                List<BasketItem> basketItems = _context.BasketItems.Where(b => b.ProductId == id && b.AppUserId == user.Id).ToList();
                foreach (var item in basketItems)
                {
                    _context.BasketItems.Remove(item);
                }
            }
            else
            {
                string basket = HttpContext.Request.Cookies["Basket"];

                List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

                BasketCookieItemVM cookieItem = basketCookieItems.FirstOrDefault(c => c.Id == id);


                basketCookieItems.Remove(cookieItem);

                string basketStr = JsonConvert.SerializeObject(basketCookieItems);

                HttpContext.Response.Cookies.Append("Basket", basketStr);

            }
            _context.SaveChanges();
            return PartialView("_BasketPartialView");
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            Product product = _context.Products.Include(p => p.ProductCategories).FirstOrDefault();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("details", "products", new { id = comment.ProductId, categoryId = product.ProductCategories.FirstOrDefault().CategoryId });
            if (!_context.Products.Any(p => p.Id == comment.ProductId)) return NotFound();
            Comment cmmt = new Comment
            {
                Text = comment.Text,
                ProductId = comment.ProductId,
                CreatedTime = DateTime.Now,
                AppUserId = user.Id,
                Rating = comment.Rating
            };
            _context.Comments.Add(cmmt);
            _context.SaveChanges();
            return RedirectToAction("details", "products", new { id = comment.ProductId, categoryId = product.ProductCategories.FirstOrDefault().CategoryId });
        }

        public async Task<IActionResult> DeleteComment(int id)
        {
            Product product = _context.Products.Include(p => p.ProductCategories).FirstOrDefault();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Index", "Products");
            if (!_context.Comments.Any(c => c.Id == id && c.AppUserId == user.Id)) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id && c.AppUserId == user.Id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Details", "Products", new { id = comment.ProductId, categoryId = product.ProductCategories.FirstOrDefault().CategoryId });
        }
    }
}
