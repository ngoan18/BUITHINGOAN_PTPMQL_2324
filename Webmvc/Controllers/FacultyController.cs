using Microsoft.AspNetCore.Mvc;
using Webmvc.Data;
using Webmvc.Models;
using Microsoft.EntityFrameworkCore;
namespace Webmvc.Controllers

{
    public class FacultyController : Controller
    {
        private readonly ApplicationDbContext _context;
        public FacultyController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Faculty.ToListAsync();
            return View(model);
        }
        public IActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Faculty emt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emt);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string name)
        {
            if (id==null)
            {
               return View("NotFound");

            }
            var faculty = await _context.Faculty.FindAsync(id);
            if ( faculty== null)
            {
                return View("NotFound");

            }
            return View(faculty);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (string id, [Bind("FacultyID, FacultyName")] Faculty emt)
        {
               if (id != emt.FacultyID)
            {
                return View("NotFound");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacultyExists(emt.FacultyID))
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
            return View(emt);
        }
    
       public async Task<IActionResult>Delete(string id)
        {
            if (id == null)
            {
               return View("NotFound");

            }
            var emt = await _context.Faculty.FirstOrDefaultAsync (m=> m.FacultyID== id);
            if (emt == null)
            {
              return View("NotFound");

            }
            return View(emt);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var emt = await _context.Faculty.FindAsync(id);
            _context.Faculty.Remove(emt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); 
        }
        private bool FacultyExists(string id)
        {
            return _context.Faculty.Any(e => e.FacultyID == id);

        }
    }
}
