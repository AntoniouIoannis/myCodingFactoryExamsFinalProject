using CultureGR_MVC_ModelFirst.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CultureGR_MVC_ModelFirst.Controllers
{
    public class ArchaeologicalSitesController : Controller
    {
        private readonly CultureGRDBContext _context;


        public ArchaeologicalSitesController(CultureGRDBContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var archaeologicalSites = await _context.ArchaeologicalSites.ToListAsync();
            return View(archaeologicalSites); // Επιστρέφει τα δεδομένα στο αντίστοιχο View
        }

        // Ενέργεια που θα εμφανίζει τις λεπτομέρειες ενός συγκεκριμένου αρχαιολογικού μνημείου
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var archaeologicalSite = await _context.ArchaeologicalSites
        //        .FirstOrDefaultAsync(m => m.Id == id);

        //    if (archaeologicalSite == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(archaeologicalSite);
        //}
    }
}
