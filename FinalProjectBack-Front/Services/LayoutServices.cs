﻿using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using FinalProjectBack_Front.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;
        //public List<FooterSocial> FooterSocials { get; set; }
        public LayoutServices(AppDbContext context)
        {
            _context = context;
        }

        public Setting GetSettingData()
        {
            Setting data = _context.Settings.FirstOrDefault();
            return data;
        }
        
        public List<FooterSocial> GetSocials()
        {
            List<FooterSocial> footerSocials = _context.FooterSocials.ToList();
            return footerSocials;
        }
    }
}
