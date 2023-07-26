using Microsoft.AspNetCore.Mvc;
using Payment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Payment.Models;

namespace Payment.Controllers
{
    public class RecordController : Controller
    {

        private readonly PaymentsContext _context;


        public RecordController(PaymentsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Record.ToListAsync());
        }

        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RecordViewModels model)
        {

            if (ModelState.IsValid)
            {
                var record = new Record()
                {

                    Concept = model.Concept,
                    Amount = model.Amount,
                };
                _context.Add(record);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);

        }

    }
}
