using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodPlanner.Models;
using FoodPlanner.Models.SoupCategory;

namespace FoodPlanner.Controllers
{
    public class GrainDishSoupsController : Controller
    {
        private readonly FoodPlannerContext _context;

        public GrainDishSoupsController(FoodPlannerContext context)
        {
            _context = context;
        }

        // GET: GrainDishSoups
        public async Task<IActionResult> Index()

        {
            var graindishsoup = await _context.Soups.ToListAsync();
            ViewData["graindishsoup"] = graindishsoup;
            return View(await _context.GrainDishSoup.ToListAsync());
        }

        // GET: GrainDishSoups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var result = await _context.GrainDishSoup.FirstOrDefaultAsync(x => x.Id == id);
            var graindishsoup = await _context.Soups.ToListAsync();
            ViewData["graindishsoup"] = graindishsoup;

            
            int indx2 = 0;

            

            foreach (var graFood in graindishsoup)
            {

                if (result.SoupName == graFood.Id)
                {
                    ViewData["indGrainDishSoup"] = indx2;
                    break;
                }
                indx2++;
            }
            if (id == null)
            {
                return NotFound();
            }

            var grainDishSoup = await _context.GrainDishSoup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grainDishSoup == null)
            {
                return NotFound();
            }

            return View(grainDishSoup);
        }

        // GET: GrainDishSoups/Create
        public async Task<IActionResult> Create()
        {
            var graindishsoup = await _context.Soups.ToListAsync();
            ViewData["graindishsoup"] = graindishsoup;
            return View();
        }

        // POST: GrainDishSoups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SoupName")] GrainDishSoup grainDishSoup , int grainselect)
        {
            grainDishSoup.SoupName = grainselect;
            if (ModelState.IsValid)
            {
                _context.Add(grainDishSoup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grainDishSoup);
        }

        // GET: GrainDishSoups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var graindishsoup = await _context.Soups.ToListAsync();
            ViewData["graindishsoup"] = graindishsoup;
            if (id == null)
            {
                return NotFound();
            }

            var grainDishSoup = await _context.GrainDishSoup.FindAsync(id);
            if (grainDishSoup == null)
            {
                return NotFound();
            }
            return View(grainDishSoup);
        }

        // POST: GrainDishSoups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SoupName")] GrainDishSoup grainDishSoup, int grainselect)
        {
            grainDishSoup.SoupName = grainselect;
            if (id != grainDishSoup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grainDishSoup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrainDishSoupExists(grainDishSoup.Id))
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
            return View(grainDishSoup);
        }

        // GET: GrainDishSoups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var result = await _context.GrainDishSoup.FirstOrDefaultAsync(x => x.Id == id);
            var graindishsoup = await _context.Soups.ToListAsync();
            ViewData["graindishsoup"] = graindishsoup;


            int indx2 = 0;



            foreach (var graFood in graindishsoup)
            {

                if (result.SoupName == graFood.Id)
                {
                    ViewData["indGrainDishSoup"] = indx2;
                    break;
                }
                indx2++;
            }
            if (id == null)
            {
                return NotFound();
            }

            var grainDishSoup = await _context.GrainDishSoup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grainDishSoup == null)
            {
                return NotFound();
            }

            return View(grainDishSoup);
        }

        // POST: GrainDishSoups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grainDishSoup = await _context.GrainDishSoup.FindAsync(id);
            _context.GrainDishSoup.Remove(grainDishSoup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GrainDishSoupExists(int id)
        {
            return _context.GrainDishSoup.Any(e => e.Id == id);
        }
    }
}
