using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCApp.Data;
using MVCApp.Data.Data;
using MVCApp.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
namespace MVCApp.Controllers;
public class DailyController : Controller
{
    private readonly ApplicationDbContext  _context;
    
    public DailyController(ApplicationDbContext context)
    {
        _context = context;
    }

      public async Task<IActionResult> Index()
    {
         var model = await _context.Daily.ToListAsync();
            return View(model);
    }
    // Create Person
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create([Bind("Madaily,Tendaily,Diachi,Nguoidaidien,SDT")]Daily daily)
    {
        if (ModelState.IsValid)
            {
                _context.Add(daily);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(daily);
    }
    // Edit Person

        public async Task<IActionResult> Edit(string id)
        {
            if (id ==null || _context.Daily == null)
            {
               return NotFound ();

            }
            var daily = await _context.Daily.FindAsync(id);
            if (daily == null)
            {
                return NotFound();

            }
            return View(daily);
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (string id, [Bind("Madaily,Tendaily,Diachi,Nguoidaidien,SDT")]Daily daily)
        {
               if (id != daily.Madaily)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(daily);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DailyExists (daily.Madaily))
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
            return View(daily);
        }
    // Delete Person

          public async Task<IActionResult>Delete(string id)
        {
            if (id == null)
            {
               return View("NotFound");

            }
            var daily = await _context.Daily.FirstOrDefaultAsync (m=> m.Madaily == id);
            if (daily == null)
            {
              return View("NotFound");

            }
            return View(daily);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Daily == null)
            {
                return Problem (" Entity set 'ApplicationDbContext.Daily' is null.");
            }
            var daily = await _context.Daily.FindAsync(id);
            if (daily != null)
            {
               _context.Daily.Remove(daily);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); 
        }
        private bool DailyExists(string id)
        {
          return (_context.Daily?.Any(e => e.Madaily == id)).GetValueOrDefault();
        }
}