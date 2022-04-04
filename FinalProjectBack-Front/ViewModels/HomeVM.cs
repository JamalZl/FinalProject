using FinalProjectBack_Front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.ViewModels
{
    public class HomeVM
    {
        public Setting Setting { get; set; }
        public List<FooterSocial> FooterSocials { get; set; }
        public List<Brand> Brands { get; set; }
    }
}
