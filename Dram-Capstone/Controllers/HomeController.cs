using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dram_Capstone.Models;
using Dram_Capstone.Data;
using Microsoft.AspNetCore.Identity;
using Dram_Capstone.Models.WhiskeyViewModels;
using Microsoft.EntityFrameworkCore;

namespace Dram_Capstone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Whiskeys 
        public async Task<IActionResult> LandingPage()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {

            //In order to access user specific information, the current user must be identified
            var user = await GetCurrentUserAsync();

            //Whiskey reviews completed by other users and displays the whiskey entry and user name
            var othersWhiskey = _context.Whiskey
                .Include(p => p.User)
                .Where(p => p.User_Id != user.Id)
                .Where(p => p.Review_Id != null)
                .OrderBy(p => p.Review.DateCreated)
                .ToList();

            WhiskeyHomeIndexView WHIV = new WhiskeyHomeIndexView();

            WHIV.OthersWhiskeys = othersWhiskey;

            return View(WHIV);

        }
    }
}



        

