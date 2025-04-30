using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace mvc.Controllers
{
    public class TourismController : Controller
    {
        private readonly DBContext _context;

        public TourismController(DBContext context)
        {
            _context = context;
        }

        // GET: Tourism
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tourism.ToListAsync());
        }

        // GET: Tourism/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tourism = await _context.Tourism
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tourism == null)
            {
                return NotFound();
            }

            return View(tourism);
        }

        // GET: Tourism/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tourism/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LocationName,Description,Country,City,PricePerDay,IsAvailable,ImageUrl,LastUpdated")] Tourism tourism)
        {
            if (ModelState.IsValid)
            {
                tourism.LastUpdated = DateTime.Now;
                _context.Add(tourism);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tourism);
        }

        // GET: Tourism/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tourism = await _context.Tourism.FindAsync(id);
            if (tourism == null)
            {
                return NotFound();
            }
            return View(tourism);
        }

        // POST: Tourism/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LocationName,Description,Country,City,PricePerDay,IsAvailable,ImageUrl,LastUpdated")] Tourism tourism)
        {
            if (id != tourism.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tourism.LastUpdated = DateTime.Now;
                    _context.Update(tourism);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TourismExists(tourism.Id))
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
            return View(tourism);
        }

        // GET: Tourism/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tourism = await _context.Tourism
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tourism == null)
            {
                return NotFound();
            }

            return View(tourism);
        }

        // POST: Tourism/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tourism = await _context.Tourism.FindAsync(id);
            if (tourism != null)
            {
                _context.Tourism.Remove(tourism);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TourismExists(int id)
        {
            return _context.Tourism.Any(e => e.Id == id);
        }
    }
}