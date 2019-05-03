using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dram_Capstone.Data;
using Dram_Capstone.Models;
using Microsoft.AspNetCore.Identity;
using Dram_Capstone.Models.ReviewViewModels;

namespace Dram_Capstone.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReviewsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.Review.ToListAsync());
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .FirstOrDefaultAsync(m => m.Review_Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Reviews/Create
        public IActionResult Create(int whiskeyId)
        {
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
            FragrantFlavorList.Insert(0, new SelectListItem
            {
                Text = "Select",
                Value = ""
            });

            FruityFlavorList.Insert(0, new SelectListItem
            {
                Text = "Select",
                Value = ""
            });

            GrainyFlavorList.Insert(0, new SelectListItem
            {
                Text = "Select",
                Value = ""
            });

            GrassyFlavorList.Insert(0, new SelectListItem
            {
                Text = "Select",
                Value = ""
            });

            OffNoteFlavorList.Insert(0, new SelectListItem
            {
                Text = "Select",
                Value = ""
            });

            PeatyFlavorList.Insert(0, new SelectListItem
            {
                Text = "Select",
                Value = ""
            });

            WineyFlavorList.Insert(0, new SelectListItem
            {
                Text = "Select",
                Value = ""
            });

            WoodyFlavorList.Insert(0, new SelectListItem
            {
                Text = "Select",
                Value = ""
            });

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

            ReviewCreateViewModel RCVM = new ReviewCreateViewModel();

            RCVM.FragrantFlavors = FragrantFlavorList;
            RCVM.FruityFlavors = FruityFlavorList;
            RCVM.GrainyFlavors = GrainyFlavorList;
            RCVM.GrassyFlavors = GrassyFlavorList;
            RCVM.OffNoteFlavors = OffNoteFlavorList;
            RCVM.PeatyFlavors = PeatyFlavorList;
            RCVM.WineyFlavors = WineyFlavorList;
            RCVM.WoodyFlavors = WoodyFlavorList;

            return View(RCVM);
        }

        // POST: Reviews/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Review_Id,DateCreated,TastingNotes,ReviewScore,WoodyFlavor_Id,WineyFlavor_Id,OffNoteFlavor_Id,FruityFlavor_Id,FragrantFlavor_Id,PeatyFlavor_Id,GrainyFlavor_Id,GrassyFlavor_Id")] Review review)
        {
            
            if (ModelState.IsValid)
            {
                
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(review);
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Review_Id,DateCreated,TastingNotes,ReviewScore,WoodyFlavor_Id,WineyFlavor_Id,OffNoteFlavor_Id,FruityFlavor_Id,FragrantFlavor_Id,PeatyFlavor_Id,GrainyFlavor_Id,GrassyFlavor_Id")] Review review)
        {
            if (id != review.Review_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.Review_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }

        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .FirstOrDefaultAsync(m => m.Review_Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _context.Review.FindAsync(id);
            _context.Review.Remove(review);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _context.Review.Any(e => e.Review_Id == id);
        }
    }
}
