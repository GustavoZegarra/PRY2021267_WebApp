using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB_APPLICATION.Models;

namespace WEB_APPLICATION.Controllers
{
    public class PasaportesController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public PasaportesController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: Pasaportes
        public async Task<IActionResult> Index()
        {
            var dbApiApplicationContext = _context.Pasaportes.Include(p => p.Pais);
            return View(await dbApiApplicationContext.ToListAsync());
        }

        // GET: Pasaportes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pasaporte = await _context.Pasaportes
                .Include(p => p.Pais)
                .FirstOrDefaultAsync(m => m.IdPasaporte == id);
            if (pasaporte == null)
            {
                return NotFound();
            }

            return View(pasaporte);
        }

        // GET: Pasaportes/Create
        public IActionResult Create()
        {
            ViewData["IdPais"] = new SelectList(_context.Pais, "IdPais", "IdPais");
            return View();
        }

        // POST: Pasaportes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPasaporte,Numero,IdPais")] Pasaporte pasaporte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pasaporte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPais"] = new SelectList(_context.Pais, "IdPais", "IdPais", pasaporte.IdPais);
            return View(pasaporte);
        }

        // GET: Pasaportes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pasaporte = await _context.Pasaportes.FindAsync(id);
            if (pasaporte == null)
            {
                return NotFound();
            }
            ViewData["IdPais"] = new SelectList(_context.Pais, "IdPais", "IdPais", pasaporte.IdPais);
            return View(pasaporte);
        }

        // POST: Pasaportes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPasaporte,Numero,IdPais")] Pasaporte pasaporte)
        {
            if (id != pasaporte.IdPasaporte)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pasaporte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PasaporteExists(pasaporte.IdPasaporte))
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
            ViewData["IdPais"] = new SelectList(_context.Pais, "IdPais", "IdPais", pasaporte.IdPais);
            return View(pasaporte);
        }

        // GET: Pasaportes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pasaporte = await _context.Pasaportes
                .Include(p => p.Pais)
                .FirstOrDefaultAsync(m => m.IdPasaporte == id);
            if (pasaporte == null)
            {
                return NotFound();
            }

            return View(pasaporte);
        }

        // POST: Pasaportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pasaporte = await _context.Pasaportes.FindAsync(id);
            _context.Pasaportes.Remove(pasaporte);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PasaporteExists(int id)
        {
            return _context.Pasaportes.Any(e => e.IdPasaporte == id);
        }
    }
}
