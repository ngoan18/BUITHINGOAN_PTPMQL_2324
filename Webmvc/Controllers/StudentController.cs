using Microsoft.AspNetCore.Mvc;
using Webmvc.Data;
using Webmvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Webmvc.Controllers

{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Student.ToListAsync();
            return View(model);
        }
        public IActionResult Create ()
        {
            ViewData["FacultyID"] = new SelectList(_context.Faculty,"FacultyID","FacultyID");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create ([Bind("StudentID,Name,FacultyID")] Student std)
        {
            if (ModelState.IsValid)
            {
                _context.Add(std);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
             ViewData["FacultyID"] = new SelectList(_context.Faculty,"FacultyID","FacultyID",std.FacultyID);
            return View(std);
        }
        private bool StudentExists(string id)
        {
            return _context.Student.Any(e => e.StudentID == id);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string name)
        {
            if (id==null)
            {
               return View("NotFound");

            }
            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return View("NotFound");

            }
            return View(student);
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (string id, [Bind("StudentId, Name")] Student std)
        {
            if (id != std.StudentID)
            {
                return View("NotFound");
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(std);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(std.StudentID))
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
            return View(std);
        }
    
        public async Task<IActionResult>Delete(string id)
        {
            if (id == null)
            {
               return View("NotFound");

            }
            var std = await _context.Student.FirstOrDefaultAsync (m=> m.StudentID == id);
            if (std == null)
            {
              return View("NotFound");

            }
            return View(std);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var std = await _context.Student.FindAsync(id);
            _context.Student.Remove(std);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); 
        }
    }
}

