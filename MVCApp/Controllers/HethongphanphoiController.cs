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
using OfficeOpenXml;
using X.PagedList;

namespace MVCApp.Controllers
{
    public class HethongphanphoiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HethongphanphoiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hethongphanphoi
        public async Task<IActionResult> Index( int? page, int? PageSize )
        {
            ViewBag.PageSize = new List<SelectListItem>()
        {
            new SelectListItem() {Value="3", Text = "3"},
            new SelectListItem() {Value="5", Text = "5"},
            new SelectListItem() {Value="10", Text = "10"},
            new SelectListItem() {Value="15", Text = "15"},
            new SelectListItem() {Value="25", Text = "25"},


        };
        int pagesize = (PageSize ?? 3);
        ViewBag.psize = pagesize;
        var model = _context.Hethongphanphoi.ToList().ToPagedList (page ?? 1, pagesize);
        return View (model);
        }

        // GET: Hethongphanphoi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Hethongphanphoi == null)
            {
                return NotFound();
            }

            var hethongphanphoi = await _context.Hethongphanphoi
                .FirstOrDefaultAsync(m => m.MaHTPP == id);
            if (hethongphanphoi == null)
            {
                return NotFound();
            }

            return View(hethongphanphoi);
        }

        // GET: Hethongphanphoi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hethongphanphoi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHTPP,TenHTPP")] Hethongphanphoi hethongphanphoi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hethongphanphoi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hethongphanphoi);
        }

        // GET: Hethongphanphoi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Hethongphanphoi == null)
            {
                return NotFound();
            }

            var hethongphanphoi = await _context.Hethongphanphoi.FindAsync(id);
            if (hethongphanphoi == null)
            {
                return NotFound();
            }
            return View(hethongphanphoi);
        }

        // POST: Hethongphanphoi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaHTPP,TenHTPP")] Hethongphanphoi hethongphanphoi)
        {
            if (id != hethongphanphoi.MaHTPP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hethongphanphoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HethongphanphoiExists(hethongphanphoi.MaHTPP))
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
            return View(hethongphanphoi);
        }

        // GET: Hethongphanphoi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Hethongphanphoi == null)
            {
                return NotFound();
            }

            var hethongphanphoi = await _context.Hethongphanphoi
                .FirstOrDefaultAsync(m => m.MaHTPP == id);
            if (hethongphanphoi == null)
            {
                return NotFound();
            }

            return View(hethongphanphoi);
        }

        // POST: Hethongphanphoi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Hethongphanphoi == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Hethongphanphoi'  is null.");
            }
            var hethongphanphoi = await _context.Hethongphanphoi.FindAsync(id);
            if (hethongphanphoi != null)
            {
                _context.Hethongphanphoi.Remove(hethongphanphoi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HethongphanphoiExists(string id)
        {
          return (_context.Hethongphanphoi?.Any(e => e.MaHTPP == id)).GetValueOrDefault();
        }
    private ExcelProcess _excelProcess = new ExcelProcess();     
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
                            var htpp = new Hethongphanphoi();
                            //set values for attribiutes
                            htpp.MaHTPP = dt.Rows[i][0].ToString();
                            htpp.TenHTPP = dt.Rows[i][1].ToString();
                             
                            //add oject to context
                            _context.Hethongphanphoi.Add(htpp);
                        }
                        //save to database
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return View();
        }

         public IActionResult Download()
        {
            var fileName = "YourFileName" + ".xlsx";
            using (ExcelPackage excelPackage =new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");
                worksheet.Cells["A1"].Value = "MaHTPP";
                worksheet.Cells["B1"].Value = "TenHTPP";

                var htppList = _context.Hethongphanphoi.ToList();
                worksheet.Cells["A2"].LoadFromCollection(htppList);
                var stream = new MemoryStream(excelPackage.GetAsByteArray());
                return File (stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
        }
    }
}
