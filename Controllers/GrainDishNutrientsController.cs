﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodPlanner.Models;
using FoodPlanner.Models.SoupNutrients;

namespace FoodPlanner.Controllers
{
    public class GrainDishNutrientsController : Controller
    {
        private readonly FoodPlannerContext _context;

        public GrainDishNutrientsController(FoodPlannerContext context)
        {
            _context = context;
        }

        // GET: GrainDishNutrients
        public async Task<IActionResult> Index()
        {
            var graindish = await _context.GrainDishes.ToListAsync();
            ViewData["graindish"] = graindish;
            
            var karomainIngredients = await _context.MainIngredients.ToListAsync();
            ViewData["karomainIngredients"] = karomainIngredients;
            return View(await _context.GrainDishNutrient.ToListAsync());
        }

        // GET: GrainDishNutrients/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            var result = await _context.GrainDishNutrient.FirstOrDefaultAsync(x => x.Id == id);
            var graindish = await _context.GrainDishes.ToListAsync();
            ViewData["graindish"] = graindish;
            
            var karomainIngredients = await _context.MainIngredients.ToListAsync();
            ViewData["karomainIngredients"] = karomainIngredients;
            int indx = 0;
            int indx2 = 0;

            foreach (var graMainIng in karomainIngredients)
            {

                if (result.KaroMainIngredientsId == graMainIng.Id)
                {
                    ViewData["indGrainDish"] = indx;
                    break;
                }
                indx++;
            }


            foreach (var graFood in graindish)
            {

                if (result.GrainName == graFood.Id)
                {
                    ViewData["indGrain"] = indx2;
                    break;
                }
                indx2++;
            }

            if (id == null)
            {
                return NotFound();
            }

            var grainDishNutrient = await _context.GrainDishNutrient
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grainDishNutrient == null)
            {
                return NotFound();
            }

            return View(grainDishNutrient);
        }

        // GET: GrainDishNutrients/Create
        public async Task<IActionResult> Create()
        {
            var graindish = await _context.GrainDishes.ToListAsync();
            ViewData["graindish"] = graindish;
            var karomainIngredients = await _context.MainIngredients.ToListAsync();
            ViewData["karomainIngredients"] = karomainIngredients;
            return View();
        }

        // POST: GrainDishNutrients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GrainName,SoupRequired,KaroMainIngredientsId")]
        GrainDishNutrient grainDishNutrient, int karoingredient, int grainselect, bool soupRequired)
        {
            grainDishNutrient.SoupRequired = soupRequired;
            grainDishNutrient.GrainName = grainselect;
            grainDishNutrient.KaroMainIngredientsId = karoingredient;
            if (ModelState.IsValid)
            {
                _context.Add(grainDishNutrient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grainDishNutrient);
        }

        // GET: GrainDishNutrients/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            var graindish = await _context.GrainDishes.ToListAsync();
            ViewData["graindish"] = graindish;

            var karomainIngredients = await _context.MainIngredients.ToListAsync();
            ViewData["karomainIngredients"] = karomainIngredients;
            
            if (id == null)
            {
                return NotFound();
            }

            var grainDishNutrient = await _context.GrainDishNutrient.FindAsync(id);
            if (grainDishNutrient == null)
            {
                return NotFound();
            }
            return View(grainDishNutrient);
        }

        // POST: GrainDishNutrients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,GrainName,SoupRequired,KaroMainIngredientsId")] GrainDishNutrient grainDishNutrient,
            int karoingredient, int grainselect, bool soupRequired)
        {
            grainDishNutrient.SoupRequired = soupRequired;
            grainDishNutrient.GrainName = grainselect;
            grainDishNutrient.KaroMainIngredientsId = karoingredient;
            if (id != grainDishNutrient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grainDishNutrient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrainDishNutrientExists(grainDishNutrient.Id))
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
            return View(grainDishNutrient);
        }

        // GET: GrainDishNutrients/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            var result = await _context.GrainDishNutrient.FirstOrDefaultAsync(x => x.Id == id);
            var graindish = await _context.GrainDishes.ToListAsync();
            ViewData["graindish"] = graindish;

            var karomainIngredients = await _context.MainIngredients.ToListAsync();
            ViewData["karomainIngredients"] = karomainIngredients;
            int indx = 0;
            int indx2 = 0;

            foreach (var graMainIng in karomainIngredients)
            {

                if (result.KaroMainIngredientsId == graMainIng.Id)
                {
                    ViewData["indGrainDish"] = indx;
                    break;
                }
                indx++;
            }


            foreach (var graFood in graindish)
            {

                if (result.GrainName == graFood.Id)
                {
                    ViewData["indGrain"] = indx2;
                    break;
                }
                indx2++;
            }

            if (id == null)
            {
                return NotFound();
            }

            var grainDishNutrient = await _context.GrainDishNutrient
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grainDishNutrient == null)
            {
                return NotFound();
            }

            return View(grainDishNutrient);
        }

        // POST: GrainDishNutrients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var grainDishNutrient = await _context.GrainDishNutrient.FindAsync(id);
            _context.GrainDishNutrient.Remove(grainDishNutrient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GrainDishNutrientExists(long id)
        {
            return _context.GrainDishNutrient.Any(e => e.Id == id);
        }
    }
}
