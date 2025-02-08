using CultureGR_MVC_ModelFirst.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CultureGR_MVC_ModelFirst.Controllers
{
    public class MonumentController : Controller
    {
        private readonly CultureGRDBContext _context;


        public MonumentController(CultureGRDBContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var monuments = await _context.Monuments.ToListAsync();
            return View(monuments);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monument = await _context.Monuments
                .FirstOrDefaultAsync(m => m.Id == id);

            if (monument == null)
            {
                return NotFound();
            }

            return View(monument);
        }
    }
}

