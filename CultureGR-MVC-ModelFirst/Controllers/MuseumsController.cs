using CultureGR_MVC_ModelFirst.Data;   // Για πρόσβαση στο DbContext
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;   // Για ερωτήματα LINQ στη βάση

namespace CultureGR_MVC_ModelFirst.Controllers
{
    public class MuseumsController : Controller
    {
        private readonly CultureGRDBContext _context;

        public MuseumsController(CultureGRDBContext context)
        {
            _context = context;
        }

        // GET: Museums/Index
        public async Task<IActionResult> Index()
        {
            var museumsList = await _context.Museums.ToListAsync();
            return View(museumsList);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var museum = await _context.Museums
                .FirstOrDefaultAsync(m => m.Id == id);

            if (museum == null)
            {
                return NotFound();
            }

            return View(museum);
        }
        //  CRUD ACTIONS BELOW
        public IActionResult Create()
        {
            return View();
        }

        // POST: Museums/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mus_name,mus_desc,mus_address,mus_phone,mus_open,category_Id,collection_Id,timeperiod_Id")] Museum museum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(museum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(museum);
        }

        // GET: Museums/Edit/
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var museum = await _context.Museums.FindAsync(id);
            if (museum == null)
            {
                return NotFound();
            }
            return View(museum);
        }

        // POST: Museums/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,mus_name,mus_desc,mus_address,mus_phone,mus_open,category_Id,collection_Id,timeperiod_Id")] Museum museum)
        {
            if (id != museum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(museum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MuseumExists(museum.Id))
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
            return View(museum);
        }

        // GET: Museums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var museum = await _context.Museums
                .FirstOrDefaultAsync(m => m.Id == id);

            if (museum == null)
            {
                return NotFound();
            }

            return View(museum);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var museum = await _context.Museums.FindAsync(id);
            if (museum != null)
            {
                _context.Museums.Remove(museum);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        // Έλεγχος αν υπάρχει το μουσείο
        private bool MuseumExists(int id)
        {
            return _context.Museums.Any(e => e.Id == id);
        }
    }
}

