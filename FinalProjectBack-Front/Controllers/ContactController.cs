using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ContactVM contactVM = new ContactVM
            {
                Contact = _context.Contacts.FirstOrDefault()
            };
            return View(contactVM);
        }
    }
}
