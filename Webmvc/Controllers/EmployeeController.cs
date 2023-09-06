using Microsoft.AspNetCore.Mvc;
using Webmvc.Data;
using Webmvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace Webmvc.Controllers

{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Employee.ToListAsync();
            return View(model);
        }
        public IActionResult Create ()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer,"CustomerId","CustomerId");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("EmployeeId,EmployeeName,Address,CustomerId")] Customer emp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
               
            }
            ViewData["CustomerId"] = new SelectList(_context.Faculty, "CustomerId", "CustomerId", emp.CustomerId);
            return View(emp);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string name, string address)
        {
            if (id==null)
            {
               return View("NotFound");

            }
            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return View("NotFound");

            }
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (string id, [Bind("EmployeeId, EmployeeName, Address")] Employee emp)
        {
               if (id != emp.EmployeeId)
            {
                return View("NotFound");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(emp.EmployeeId))
                    {
                        return View("NotFound");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(emp);
        }
    
       public async Task<IActionResult>Delete(string id)
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
            var emp = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(emp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); 
        }
        private bool EmployeeExists(string id)
        {
            return _context.Employee.Any(e => e.EmployeeId == id);

        }
    }
}
