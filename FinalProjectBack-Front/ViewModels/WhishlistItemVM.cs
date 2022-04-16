using FinalProjectBack_Front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.ViewModels
{
    public class WhishlistItemVM
    {
        public Product Product { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
