using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsAdmin { get; set; }
        public int Age { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public List<WhishlistItem> WhishlistItems { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<Order> Orders { get; set; }
    }
}
