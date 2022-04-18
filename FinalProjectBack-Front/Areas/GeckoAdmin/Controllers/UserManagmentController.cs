﻿using FinalProjectBack_Front.DAL;
using FinalProjectBack_Front.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Areas.GeckoAdmin.Controllers
{
    [Area("GeckoAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class UserManagmentController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInResult;

        public UserManagmentController(AppDbContext context,UserManager<AppUser> userManager,RoleManager<IdentityRole> roleManager,SignInManager<AppUser> signInResult)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInResult = signInResult;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Users.Count() / 6);
            ViewBag.CurrentPage = page;

            List<AppUser> users = _context.Users.Skip((page - 1) * 6).Take(6).ToList();
            return View(users);
        }

        public async Task<IActionResult> RoleChanger(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user.IsAdmin)
            {
                user.IsAdmin = false;
                var role = (await _userManager.GetRolesAsync(user))[0];
                await _userManager.RemoveFromRoleAsync(user,role);
                await _userManager.AddToRoleAsync(user, "Member");
            }
            else
            {
                user.IsAdmin = true;
                var role = (await _userManager.GetRolesAsync(user))[0];
                await _userManager.RemoveFromRoleAsync(user, role);
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
