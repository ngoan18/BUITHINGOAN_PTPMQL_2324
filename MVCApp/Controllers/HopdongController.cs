using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCApp.Data;
using MVCApp.Models;
using MVCApp.Models.Process;

namespace MVCApp.Controllers
{
    public class HopdongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HopdongController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hopdong
        public async Task<IActionResult> Index()
        {
              return _context.Hopdong != null ? 
                          View(await _context.Hopdong.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Hopdong'  is null.");
        }

        // GET: Hopdong/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Hopdong == null)
            {
                return NotFound();
            }

            var hopdong = await _context.Hopdong
                .FirstOrDefaultAsync(m => m.Mahp == id);
            if (hopdong == null)
            {
                return NotFound();
            }

            return View(hopdong);
        }

        // GET: Hopdong/Create
        public IActionResult Create()
        {
            ViewData[("Madaily")] = new SelectList (_context.Daily,"Madaily","Madaily");
            return View();
        }

        // POST: Hopdong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mahp,Tenhp,Madaily")] Hopdong hopdong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hopdong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData[("Madaily")] =new SelectList (_context.Daily,"Madaily","Madaily", hopdong.Madaily);
            return View(hopdong);
        }

        // GET: Hopdong/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Hopdong == null)
            {
                return NotFound();
            }

            var hopdong = await _context.Hopdong.FindAsync(id);
            if (hopdong == null)
            {
                return NotFound();
            }
            return View(hopdong);
        }

        // POST: Hopdong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Mahp,Tenhp")] Hopdong hopdong)
        {
            if (id != hopdong.Mahp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hopdong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HopdongExists(hopdong.Mahp))
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
            return View(hopdong);
        }

        // GET: Hopdong/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Hopdong == null)
            {
                return NotFound();
            }

            var hopdong = await _context.Hopdong
                .FirstOrDefaultAsync(m => m.Mahp == id);
            if (hopdong == null)
            {
                return NotFound();
            }

            return View(hopdong);
        }

        // POST: Hopdong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Hopdong == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Hopdong'  is null.");
            }
            var hopdong = await _context.Hopdong.FindAsync(id);
            if (hopdong != null)
            {
                _context.Hopdong.Remove(hopdong);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HopdongExists(string id)
        {
          return (_context.Hopdong?.Any(e => e.Mahp == id)).GetValueOrDefault();
        
        }
        private ExcelProcess _excelProcess=new ExcelProcess();
         public async Task<IActionResult> Upload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Upload(IFormFile file)
        {
            if (file!=null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if (fileExtension != ".xls" && fileExtension != ".xlsx")
                {
                    ModelState.AddModelError("", "Please choose excel file to upload!");
                }
                else
                {
                    //rename file when upload to sever
                    var fileName = DateTime.Now.ToShortTimeString() + fileExtension;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads/Excels", fileName);
                    var fileLocation = new FileInfo(filePath).ToString();
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        //save file to server
                        await file.CopyToAsync(stream);
                        //read data from file and write to database
                        var dt = _excelProcess.ExcelToDataTable(fileLocation);
                        //dùng vòng l?p for d? d?c d? li?u d?ng hd
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //create a new Student object
                            var hp = new Hopdong();
                            //set values for attribiutes
                            hp.Mahp = dt.Rows[i][0].ToString();
                            hp.Tenhp = dt.Rows[i][1].ToString();
                          
                             
                            //add oject to context
                            _context.Hopdong.Add(hp);
                        }
                        //save to database
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
         
            return View();
         }
    }
}
