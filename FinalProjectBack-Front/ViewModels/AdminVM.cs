using FinalProjectBack_Front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.ViewModels
{
    public class AdminVM
    {
        public List<Product> Products { get; set; }
        public List<Comment> Comments { get; set; }
        public List<AppUser> Users { get; set; }
        public List<Order> Orders { get; set; }
        public List<ContactMessage> UserMessages { get; set; }
        public List<Subscribe> Subscribes { get; set; }
        public List<Brand> Brands { get; set; }
    }
}
