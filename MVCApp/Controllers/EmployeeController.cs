using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCApp.Data;
using MVCApp.Data.Data;
using MVCApp.Models;
using SQLitePCL;
namespace MVCApp.Controllers;
public class EmployeeController : Controller
{
    // Khai bao application lam viec voi database
    private readonly ApplicationDbContext _context;
    public EmployeeController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Index Employee ( tra ve view 1 list du lieu Employee trong csdl)

    public async Task<IActionResult> Index()
    {
        var model = await _context.Employee.ToListAsync();
        return View(model);
    }

    // Create Employee (tra ve view thuc hien them moi 1 csdl)
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create([Bind("EmployeeId,Name, SDT,Age,")] Employee emp)
    {
        if (ModelState.IsValid)
        {
            _context.Add(emp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(emp);
    }

    //Edit thuc hien sua thong tin
    public async Task<IActionResult> Edit(string id)

    {
        if (id == null || _context.Employee == null)
        {
            return NotFound();
        }
        var emp = await _context.Employee.FindAsync(id);
        if (emp == null)
        {
            return NotFound();
        }

        return View(emp);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task< IActionResult> Edit(string id,[Bind("EmployeeId,Name,SDT,Age")] Employee emp)
    {
        if (id != emp.EmployeeId)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            try{
                _context.Update(emp);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists (emp.EmployeeId))
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
        return View (emp);
    }
    // Delete Employee
    public async Task <IActionResult> Delete (string id)
    {
         if (id == null)
            {
               return View("NotFound");

            }
            var emp = await _context.Employee.FirstOrDefaultAsync (m=> m.EmployeeId == id);
            if (emp == null)
            {
              return View("NotFound");

            }
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Employee == null)
            {
                return Problem (" Entity set 'ApplicationDbContext.Person' is null.");
            }
            var emp = await _context.Employee.FindAsync(id);
            if (emp != null)
            {
               _context.Employee.Remove(emp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); 
    }
    // kiem tra 1 employee co ton tai trong csdl khong (pthuc Exists)

    private bool EmployeeExists(string id)
    {
        return (_context.Employee?.Any(e => e.EmployeeId == id)).GetValueOrDefault();
    }
    
}