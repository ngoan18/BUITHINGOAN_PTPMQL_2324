using Microsoft.AspNetCore.Mvc;
using Webmvc.Data;
using Webmvc.Models;
using Microsoft.EntityFrameworkCore;
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
            return View();
        }
        public IActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
                _context.Add(std);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(std);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string name)
        {
            if (id==null)
            {
                return NotFound();
            }
            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}

