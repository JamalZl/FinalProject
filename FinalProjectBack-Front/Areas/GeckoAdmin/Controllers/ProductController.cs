using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Extensions;
using FinalProjectBack_Front.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Areas.GeckoAdmin.Controllers
{
    [Area("GeckoAdmin")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Products.Count() / 6);
            ViewBag.CurrentPage = page;
            List<Product> products = _context.Products.Include(p=>p.Comments).ThenInclude(c=>c.AppUser).Include(p => p.ProductImages).Skip((page - 1) * 6).Take(6).ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Sizes = _context.Sizes.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Sizes = _context.Sizes.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            if (!ModelState.IsValid) return View();
            if (product.CampaignId == 0)
            {
                product.CampaignId = null;
            }
            product.ProductCategories = new List<ProductCategory>();
            product.ProductColors = new List<ProductColor>();
            product.ProductSizes = new List<ProductSize>();
            product.ProductImages = new List<ProductImage>();
            product.DescriptionImages = new List<ProductDescriptionImage>();

            if (product.CategoryIds == null)
            {
                ModelState.AddModelError("CategoryIds", "Please choose at least one category");
                return View();
            }
            foreach (var id in product.CategoryIds)
            {
                ProductCategory pCategory = new ProductCategory
                {
                    Product = product,
                    CategoryId = id
                };
                product.ProductCategories.Add(pCategory);
            }
            if (product.ColorIds == null)
            {
                ModelState.AddModelError("ColorIds", "Please choose at least one color");
                return View();
            }
            foreach (var id in product.ColorIds)
            {
                ProductColor pColor = new ProductColor
                {
                    Product = product,
                    ColorId = id
                };
                product.ProductColors.Add(pColor);
            }
            if (product.SizeIds == null)
            {
                ModelState.AddModelError("SizeIds", "Please choose at least one size");
                return View();
            }
            foreach (var id in product.SizeIds)
            {
                ProductSize pSize = new ProductSize
                {
                    Product = product,
                    SizeId = id
                };
                product.ProductSizes.Add(pSize);
            }
            if (product.ImageFiles == null)
            {
                ModelState.AddModelError("ImageFiles", "Please dont leave empty images area");
                return View();
            }
            if (product.ImageFiles.Count > 5)
            {
                ModelState.AddModelError("ImageFiles", "You can choose maximum 4 images");
                return View();
            }
            foreach (var img in product.ImageFiles)
            {
                if (!img.IsImage())
                {
                    ModelState.AddModelError("ImageFiles", "Please insert a valid image type such as jpg,png,jpeg etc");
                    return View();
                }
                if (!img.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFiles", "Image size can not be more than 2MB");
                    return View();
                }
            }
            foreach (var img in product.ImageFiles)
            {
                ProductImage pImage = new ProductImage
                {
                    Image = img.SaveImg(_env.WebRootPath, "assets/images"),
                    Product = product
                };
                product.ProductImages.Add(pImage);
            }

            if (product.DescImageFiles==null)
            {
                ModelState.AddModelError("DescImageFiles", "Please dont leave empty images area");
                return View();
            }
            if (product.DescImageFiles.Count!=3)
            {
                ModelState.AddModelError("DescImageFiles", "You have to choose 3 images");
                return View();
            }
            foreach (var descImg in product.DescImageFiles)
            {
                if (!descImg.IsImage())
                {
                    ModelState.AddModelError("DescImageFiles", "Please insert a valid image type such as jpg,png,jpeg etc");
                    return View();
                }
                if (!descImg.IsSizeOkay(2))
                {
                    ModelState.AddModelError("DescImageFiles", "Image size can not be more than 2MB");
                    return View();
                }
            }
            foreach (var descImg in product.DescImageFiles)
            {
                ProductDescriptionImage descImage = new ProductDescriptionImage
                {
                    Image = descImg.SaveImg(_env.WebRootPath, "assets/images"),
                    Product = product
                };
                product.DescriptionImages.Add(descImage);
            }

           
            _context.Products.Add(product);
            _context.SaveChanges();
            List<Subscribe> subscribes = _context.Subscribers.ToList();
            foreach (var sub in subscribes)
            {
                string link = "https://localhost:44349/products/details/" + product.Id+$"?categoryId={product.ProductCategories.FirstOrDefault().CategoryId}";
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("czeynalli00@gmail.com", "Gecko");
                mail.To.Add(new MailAddress(sub.Email));


                mail.Subject = "New product";
                string body = string.Empty;

                using (StreamReader reader = new StreamReader("wwwroot/assets/template/subscribenews.html"))
                {
                    body = reader.ReadToEnd();
                }

                string aboutText = $"<strong>Hello</strong><br /> a new <strong>{product.Brand.Name} {product.Name}</strong> product added to our shop <br/>click the link down below to discover new product";
                body = body.Replace("{{link}}", link);
                mail.Body = body.Replace("{{aboutText}}", aboutText);
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                smtp.Credentials = new NetworkCredential("czeynalli00@gmail.com", "sendmaillesssecureapps0078");
                smtp.Send(mail);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Sizes = _context.Sizes.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            Product product = _context.Products.Include(p=>p.ProductImages).Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p=>p.DescriptionImages).FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Sizes = _context.Sizes.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            Product existedProduct = _context.Products.Include(p=>p.ProductImages).Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p=>p.DescriptionImages).FirstOrDefault(p => p.Id == product.Id);
            if (!ModelState.IsValid) return View();
            if (existedProduct == null) return NotFound();

            if (product.ImageFiles != null)
            {
                if (product.ImageFiles.Count > 5)
                {
                    ModelState.AddModelError("ImageFiles", "You can choose maximum 4 images");
                    return View(existedProduct);
                }
                foreach (var img in product.ImageFiles)
                {
                    if (!img.IsImage())
                    {
                        ModelState.AddModelError("ImageFiles", "Please insert a valid image type such as jpg,png,jpeg etc");
                        return View(existedProduct);
                    }
                    if (!img.IsSizeOkay(2))
                    {
                        ModelState.AddModelError("ImageFiles", "Image size can not be more than 2MB");
                        return View(existedProduct);
                    }
                }
                List<ProductImage> removableImages = existedProduct.ProductImages.Where(pi => product.ImageIds.Contains(pi.Id)).ToList();

                existedProduct.ProductImages.RemoveAll(pi => removableImages.Any(ri => ri.Id == pi.Id));

                foreach (var rImage in removableImages)
                {
                    Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", rImage.Image);
                }

                foreach (var img in product.ImageFiles)
                {
                    ProductImage pImage = new ProductImage
                    {
                        Image = img.SaveImg(_env.WebRootPath, "assets/images"),
                        ProductId = existedProduct.Id
                    };
                    existedProduct.ProductImages.Add(pImage);
                }

            }
            if (product.DescImageFiles != null)
            {
                if (product.DescImageFiles.Count != 3)
                {
                    ModelState.AddModelError("ImageFiles", "You have to choose  3 images");
                    return View(existedProduct);
                }
                foreach (var img in product.DescImageFiles)
                {
                    if (!img.IsImage())
                    {
                        ModelState.AddModelError("DescImageFiles", "Please insert a valid image type such as jpg,png,jpeg etc");
                        return View(existedProduct);
                    }
                    if (!img.IsSizeOkay(2))
                    {
                        ModelState.AddModelError("DescImageFiles", "Image size can not be more than 2MB");
                        return View(existedProduct);
                    }
                }
                List<ProductDescriptionImage> removableImages = existedProduct.DescriptionImages.Where(di => product.DescImageIds.Contains(di.Id)).ToList();

                existedProduct.DescriptionImages.RemoveAll(di => removableImages.Any(ri => ri.Id == di.Id));

                foreach (var rImage in removableImages)
                {
                    Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", rImage.Image);
                }

                foreach (var img in product.ImageFiles)
                {
                    ProductDescriptionImage dImage = new ProductDescriptionImage
                    {
                        Image = img.SaveImg(_env.WebRootPath, "assets/images"),
                        ProductId = existedProduct.Id
                    };
                    existedProduct.DescriptionImages.Add(dImage);
                }

            }
            if (product.CategoryIds == null)
            {
                ModelState.AddModelError("CategoryIds", "Please choose at least one category");
                return View(existedProduct);
            }
            List<ProductCategory> removableCategories = existedProduct.ProductCategories.Where(pc => !product.CategoryIds.Contains(pc.Id)).ToList();

            existedProduct.ProductCategories.RemoveAll(pc => removableCategories.Any(rc => pc.Id == rc.Id));
            foreach (var categoryId in product.CategoryIds)
            {
                ProductCategory productCategory = existedProduct.ProductCategories.FirstOrDefault(fc => fc.CategoryId == categoryId);
                if (productCategory == null)
                {
                    ProductCategory pCategory = new ProductCategory
                    {
                        CategoryId = categoryId,
                        ProductId = existedProduct.Id
                    };
                    existedProduct.ProductCategories.Add(pCategory);
                }
            }

            if (product.ColorIds == null)
            {
                ModelState.AddModelError("ColorIds", "Please choose at least one color");
                return View(existedProduct);
            }

            List<ProductColor> removableColors = existedProduct.ProductColors.Where(pc => !product.ColorIds.Contains(pc.Id)).ToList();

            existedProduct.ProductColors.RemoveAll(pc => removableColors.Any(rc => pc.Id == rc.Id));
            foreach (var colorId in product.ColorIds)
            {
                ProductColor productColor = existedProduct.ProductColors.FirstOrDefault(fc => fc.ColorId == colorId);
                if (productColor == null)
                {
                    ProductColor pColor = new ProductColor
                    {
                        ColorId = colorId,
                        ProductId = existedProduct.Id
                    };
                    existedProduct.ProductColors.Add(pColor);
                }
            }

            if (product.SizeIds == null)
            {
                ModelState.AddModelError("SizeIds", "Please choose at least one size");
                return View(existedProduct);
            }

            List<ProductSize> removableSizes = existedProduct.ProductSizes.Where(pc => !product.SizeIds.Contains(pc.Id)).ToList();

            existedProduct.ProductSizes.RemoveAll(pc => removableSizes.Any(rc => pc.Id == rc.Id));
            foreach (var sizeId in product.SizeIds)
            {
                ProductSize productSize = existedProduct.ProductSizes.FirstOrDefault(fc => fc.SizeId == sizeId);
                if (productSize == null)
                {
                    ProductSize pSize = new ProductSize
                    {
                        SizeId = sizeId,
                        ProductId = existedProduct.Id
                    };
                    existedProduct.ProductSizes.Add(pSize);
                }
            }
            if (product.CampaignId == 0)
            {
                product.CampaignId = null;
            }

            existedProduct.BrandId = product.BrandId;
            existedProduct.CampaignId = product.CampaignId;
            existedProduct.TagId = product.TagId;
            existedProduct.Description = product.Description;
            existedProduct.InStock = product.InStock;
            existedProduct.IsDeleted = product.IsDeleted;
            existedProduct.Name = product.Name;
            existedProduct.Price = product.Price;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int id)
        {
            Product product = _context.Products.FirstOrDefault(c => c.Id == id);
            Product existedProduct = _context.Products.FirstOrDefault(c => c.Id == product.Id);
            if (existedProduct == null) return NotFound();
            if (product == null) return Json(new { status = 404 });
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Json(new { status = 200 });
        }

        public IActionResult Comments(int ProductId)
        {
            if (!_context.Comments.Any(c => c.ProductId == ProductId)) return RedirectToAction("index", "product");
            List<Comment> comments = _context.Comments.Include(c => c.AppUser).Where(c => c.ProductId == ProductId).ToList();
            return View(comments);
        }
        public IActionResult CStatusChange(int id)
        {
            if (!_context.Comments.Any(c => c.Id == id)) return RedirectToAction("Index", "Product");
            Comment comment = _context.Comments.SingleOrDefault(c => c.Id == id);
            comment.IsVisible = comment.IsVisible ? false : true;
            _context.SaveChanges();
            return RedirectToAction("Comments", "Product", new { ProductId = comment.ProductId });

        }
    }
}
