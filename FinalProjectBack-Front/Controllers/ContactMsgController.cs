using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Controllers
{
    public class ContactMsgController : Controller
    {
        private readonly AppDbContext _context;

        public ContactMsgController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Message(ContactMessage mssg)
        {
            if (!ModelState.IsValid) return View();
            ContactMessage cm = new ContactMessage
            {
                Message = mssg.Message,
                Fullname=mssg.Fullname,
                Number=mssg.Number,
                Email = mssg.Email,
                SendDate = DateTime.Now
            };
            _context.ContactMessages.Add(cm);
            _context.SaveChanges();
            return RedirectToAction("index", "home");
        }
    }
}
