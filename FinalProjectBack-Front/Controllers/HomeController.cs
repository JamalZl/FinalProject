using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using FinalProjectBack_Front.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                Products = _context.Products.Include(p=>p.ProductColors).ThenInclude(pc=>pc.Color).Include(p=>p.ProductSizes).ThenInclude(ps=>ps.Size).Include(p=>p.ProductCategories).ThenInclude(pc=>pc.Category).Include(p=>p.Campaign).Include(p => p.ProductImages).Take(4).Where(p => p.IsDeleted == false).ToList(),
                Tags = _context.Tags.ToList(),
                Sliders = _context.Sliders.ToList(),
                BestSellerProducts= _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p=>p.ProductColors).ThenInclude(pc=>pc.Color).Include(p=>p.ProductSizes).ThenInclude(ps=>ps.Size).Include(p => p.Campaign).Include(p => p.ProductImages).Where(p => p.IsDeleted == false).OrderByDescending(p=>p.SellCount).Take(4).ToList(),
                FeaturedProducts= _context.Products.Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).Skip(4).Take(10).Where(p => p.IsDeleted == false).ToList(),
            };

            return View(homeVM);
        }

        public IActionResult Search(string keyword)
        {
            List<Product> products = _context.Products.Include(p=>p.ProductCategories).ThenInclude(pc=>pc.Category).Include(p => p.ProductImages).Include(p => p.Brand).Where(p => p.Name.Trim().ToLower().Contains(keyword.Trim().ToLower()) || p.Brand.Name.ToLower().Trim().Contains(keyword.Trim().ToLower())).Where(p => p.IsDeleted == false).ToList();
            return PartialView("_SearchPartialView", products);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SubscribeVM subscribeVM)
        {
            HomeVM homeVM = new HomeVM
            {
                FooterSocials = _context.FooterSocials.ToList(),
                Categories = _context.Categories.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Brands = _context.Brands.ToList(),
                Products = _context.Products.Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).Take(4).Where(p => p.IsDeleted == false).ToList(),
                Tags = _context.Tags.ToList(),
                Sliders = _context.Sliders.ToList(),
                BestSellerProducts = _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.Campaign).Include(p => p.ProductImages).Where(p => p.IsDeleted == false).OrderByDescending(p => p.SellCount).Take(4).ToList(),
                FeaturedProducts = _context.Products.Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).Include(p => p.Campaign).Include(p => p.ProductImages).Skip(4).Take(10).Where(p => p.IsDeleted == false).ToList(),
            };
            if (!ModelState.IsValid) return View();
            Subscribe emailCheck = _context.Subscribers.FirstOrDefault(s => s.Email == subscribeVM.Email);
            if (emailCheck != null)
            {
                ModelState.AddModelError("", "This email address is already subscriber,please enter different email address");
                return View(homeVM);
            }
            Subscribe subscriber = new Subscribe
            {
                Email = subscribeVM.Email,
            };

            
            string link = "https://localhost:44349/home/index";
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("czeynalli00@gmail.com", "Gecko");
            mail.To.Add(new MailAddress(subscriber.Email));


            mail.Subject = "New Subscriber";
            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/assets/template/subscribe.html"))
            {
                body = reader.ReadToEnd();
            }

            string aboutText = $"<strong>Dear subscriber</strong>,Welcome to our website";
            body = body.Replace("{{link}}", link);
            mail.Body = body.Replace("{{aboutText}}", aboutText);
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("czeynalli00@gmail.com", "sendmaillesssecureapps0078");
            smtp.Send(mail);
            _context.Subscribers.Add(subscriber);
            _context.SaveChanges();

            return RedirectToAction("index", "home");
        }

        //public IActionResult SubscriberVerifyEmail(string email)
        //{
        //    Subscribe subscribe = _context.Subscribers.FirstOrDefault(s => s.Email == email);

        //    if (subscribe == null) return BadRequest();

        //    subscribe.IsConfirmed = true;

        //    return RedirectToAction("index", "home");
        //}
    }
}
