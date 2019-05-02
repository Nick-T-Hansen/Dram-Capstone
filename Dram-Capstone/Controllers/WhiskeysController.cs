using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dram_Capstone.Data;
using Dram_Capstone.Models;

namespace Dram_Capstone.Controllers
{
    public class WhiskeysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WhiskeysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Whiskeys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Whiskey.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("WhiskeyId,Name,Distillery,WhiskeyReview_Id,User_Id,Favorite")] Whiskey whiskey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(whiskey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(whiskey);
        }

        // GET: Whiskeys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var whiskey = await _context.Whiskey.FindAsync(id);
            if (whiskey == null)
            {
                return NotFound();
            }
            return View(whiskey);
        }

        // POST: Whiskeys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WhiskeyId,Name,Distillery,WhiskeyReview_Id,User_Id,Favorite")] Whiskey whiskey)
        {
            if (id != whiskey.WhiskeyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(whiskey);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WhiskeyExists(whiskey.WhiskeyId))
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
            return View(whiskey);
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

            return View(whiskey);
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
