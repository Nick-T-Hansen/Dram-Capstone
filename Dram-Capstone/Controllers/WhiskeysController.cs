﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dram_Capstone.Data;
using Dram_Capstone.Models;
using Microsoft.AspNetCore.Identity;
using Dram_Capstone.Models.WhiskeyViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security;



namespace Dram_Capstone.Controllers
{


    public class WhiskeysController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public WhiskeysController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Whiskeys
        public async Task<IActionResult> Index()
        {
            //In order to access user specific information, the current user must be identified
            var user = await GetCurrentUserAsync();

            //Information from the database is received for the current user
            var applicationDbContext = _context.Whiskey
                .Where(p => p.UserId == user.Id)
                .OrderBy(p => p.WhiskeyEntry);

            return View(await applicationDbContext.ToListAsync());
        }


        // GET: Whiskeys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // need the whiskey details and the review
            var whiskey = await _context.Whiskey
                .Include(m => m.Review)
                .Include(m => m.Review.FragrantFlavor)
                .Include(m => m.Review.FruityFlavor)
                .Include(m => m.Review.GrainyFlavor)
                .Include(m => m.Review.GrassyFlavor)
                .Include(m => m.Review.PeatyFlavor)
                .Include(m => m.Review.WineyFlavor)
                .Include(m => m.Review.WoodyFlavor)
                .Include(m => m.Review.OffNoteFlavor)
                .FirstOrDefaultAsync(m => m.WhiskeyId == id);
            if (whiskey == null)
            {
                return NotFound();
            }

            return View(whiskey);
        }

        // GET: Whiskeys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Whiskeys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Whiskey whiskey)
        {

            ModelState.Remove("UserId");
            ModelState.Remove("User");
            var user = await GetCurrentUserAsync();


            if (ModelState.IsValid)
            {
                whiskey.UserId = user.Id;
                _context.Add(whiskey);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(whiskey);
        }

        // GET: Whiskeys/Edit/5

        public async Task<IActionResult> Edit(int id)
        {


            //need to ensure a user can edit all user input information (whiskey details, review details, dropdown selection options). Need whiskey id, whiskey object, review object, review dropdown values
            var whiskey = await _context.Whiskey
                     .Include(m => m.Review)
                     .Include(m => m.Review.FragrantFlavor)
                     .Include(m => m.Review.FruityFlavor)
                     .Include(m => m.Review.GrainyFlavor)
                     .Include(m => m.Review.GrassyFlavor)
                     .Include(m => m.Review.PeatyFlavor)
                     .Include(m => m.Review.WineyFlavor)
                     .Include(m => m.Review.WoodyFlavor)
                     .FirstOrDefaultAsync(m => m.WhiskeyId == id);

            var FragrantFlavorData = _context.FragrantFlavor;
            var FruityFlavorData = _context.FruityFlavor;
            var GrainyFlavorData = _context.GrainyFlavor;
            var GrassyFlavorData = _context.GrassyFlavor;
            var OffNoteFlavorData = _context.OffNoteFlavor;
            var PeatyFlavorData = _context.PeatyFlavor;
            var WineyFlavorData = _context.WineyFlavor;
            var WoodyFLavorData = _context.WoodyFlavor;

            List<SelectListItem> FragrantFlavorList = new List<SelectListItem>();
            List<SelectListItem> FruityFlavorList = new List<SelectListItem>();
            List<SelectListItem> GrainyFlavorList = new List<SelectListItem>();
            List<SelectListItem> GrassyFlavorList = new List<SelectListItem>();
            List<SelectListItem> OffNoteFlavorList = new List<SelectListItem>();
            List<SelectListItem> PeatyFlavorList = new List<SelectListItem>();
            List<SelectListItem> WineyFlavorList = new List<SelectListItem>();
            List<SelectListItem> WoodyFlavorList = new List<SelectListItem>();

            // include the select option in the product type list

            //FragrantFlavorList.Insert(0, new SelectListItem
            //{
            //    Text = "Select",
            //    Value = ""
            //});

            //FruityFlavorList.Insert(0, new SelectListItem
            //{
            //    Text = "Select",
            //    Value = ""
            //});

            //GrainyFlavorList.Insert(0, new SelectListItem
            //{
            //    Text = "Select",
            //    Value = ""
            //});

            //GrassyFlavorList.Insert(0, new SelectListItem
            //{
            //    Text = "Select",
            //    Value = ""
            //});

            //OffNoteFlavorList.Insert(0, new SelectListItem
            //{
            //    Text = "Select",
            //    Value = ""
            //});

            //PeatyFlavorList.Insert(0, new SelectListItem
            //{
            //    Text = "Select",
            //    Value = ""
            //});

            //WineyFlavorList.Insert(0, new SelectListItem
            //{
            //    Text = "Select",
            //    Value = ""
            //});

            //WoodyFlavorList.Insert(0, new SelectListItem
            //{
            //    Text = "Select",
            //    Value = ""
            //});

            foreach (var f in FragrantFlavorData)
            {
                SelectListItem li = new SelectListItem
                {
                    Value = f.FragrantFlavor_Id.ToString(),
                    Text = f.Name
                };
                FragrantFlavorList.Add(li);
            };

            foreach (var f in FruityFlavorData)
            {
                SelectListItem li = new SelectListItem
                {
                    Value = f.FruityFlavor_Id.ToString(),
                    Text = f.Name
                };
                FruityFlavorList.Add(li);
            };

            foreach (var f in GrainyFlavorData)
            {
                SelectListItem li = new SelectListItem
                {
                    Value = f.GrainyFlavor_Id.ToString(),
                    Text = f.Name
                };
                GrainyFlavorList.Add(li);
            };

            foreach (var f in GrassyFlavorData)
            {
                SelectListItem li = new SelectListItem
                {
                    Value = f.GrassyFlavor_Id.ToString(),
                    Text = f.Name
                };
                GrassyFlavorList.Add(li);
            };

            foreach (var f in OffNoteFlavorData)
            {
                SelectListItem li = new SelectListItem
                {
                    Value = f.OffNoteFlavor_Id.ToString(),
                    Text = f.Name
                };
                OffNoteFlavorList.Add(li);
            };

            foreach (var f in PeatyFlavorData)
            {
                SelectListItem li = new SelectListItem
                {
                    Value = f.PeatyFlavor_Id.ToString(),
                    Text = f.Name
                };
                PeatyFlavorList.Add(li);
            };

            foreach (var f in WineyFlavorData)
            {
                SelectListItem li = new SelectListItem
                {
                    Value = f.WineyFlavor_Id.ToString(),
                    Text = f.Name
                };
                WineyFlavorList.Add(li);
            };

            foreach (var f in WoodyFLavorData)
            {
                SelectListItem li = new SelectListItem
                {
                    Value = f.WoodyFlavor_Id.ToString(),
                    Text = f.Name
                };
                WoodyFlavorList.Add(li);
            };

            WhiskeyEditViewModel WEVM = new WhiskeyEditViewModel();

            WEVM.FragrantFlavors = FragrantFlavorList;
            WEVM.FruityFlavors = FruityFlavorList;
            WEVM.GrainyFlavors = GrainyFlavorList;
            WEVM.GrassyFlavors = GrassyFlavorList;
            WEVM.OffNoteFlavors = OffNoteFlavorList;
            WEVM.PeatyFlavors = PeatyFlavorList;
            WEVM.WineyFlavors = WineyFlavorList;
            WEVM.WoodyFlavors = WoodyFlavorList;

            WEVM.Whiskey = whiskey;

            var user = await GetCurrentUserAsync();

            if (user.Id == whiskey.UserId)
            {
                return View(WEVM);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }



        // POST: Whiskeys/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, WhiskeyEditViewModel viewModel)
        {
            var whiskeyId = id;


            //ModelState.Remove("Whiskey.Review_Id");
            ModelState.Remove("UserId");
            ModelState.Remove("User");


            if (ModelState.IsValid)
            {
                try
                {
                    var whiskeyUser = viewModel.Whiskey.UserId;
                    var user = await GetCurrentUserAsync();

                    viewModel.Whiskey.UserId = user.Id;

                    _context.Update(viewModel.Whiskey);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WhiskeyExists(viewModel.Whiskey.WhiskeyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(viewModel);
        }

        // GET: Whiskeys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var whiskey = await _context.Whiskey
                .FirstOrDefaultAsync(m => m.WhiskeyId == id);
            if (whiskey == null)
            {
                return NotFound();
            }

            //If a user manually tries to change access the edit or delete functions of another persons whiskies in the url, that user will be redirected to ther whiskey library
            var user = await GetCurrentUserAsync();

            if (user.Id == whiskey.UserId)
            {
                return View(whiskey);
                
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        // POST: Whiskeys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var whiskey = await _context.Whiskey.FindAsync(id);
            _context.Whiskey.Remove(whiskey);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WhiskeyExists(int id)
        {
            return _context.Whiskey.Any(e => e.WhiskeyId == id);
        }
    }
}
