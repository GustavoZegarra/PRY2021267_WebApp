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
    public class DistritosController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public DistritosController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: Distritos
        public async Task<IActionResult> Index()
        {
            var dbApiApplicationContext = _context.Distritos.Include(d => d.Provincia);
            return View(await dbApiApplicationContext.ToListAsync());
        }

        // GET: Distritos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distrito = await _context.Distritos
                .Include(d => d.Provincia)
                .FirstOrDefaultAsync(m => m.IdDistrito == id);
            if (distrito == null)
            {
                return NotFound();
            }

            return View(distrito);
        }

        // GET: Distritos/Create
        public IActionResult Create()
        {
            ViewData["IdProvincia"] = new SelectList(_context.Provincias, "IdProvincia", "IdProvincia");
            return View();
        }

        // POST: Distritos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDistrito,Nombre,IdProvincia")] Distrito distrito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(distrito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProvincia"] = new SelectList(_context.Provincias, "IdProvincia", "IdProvincia", distrito.IdProvincia);
            return View(distrito);
        }

        // GET: Distritos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distrito = await _context.Distritos.FindAsync(id);
            if (distrito == null)
            {
                return NotFound();
            }
            ViewData["IdProvincia"] = new SelectList(_context.Provincias, "IdProvincia", "IdProvincia", distrito.IdProvincia);
            return View(distrito);
        }

        // POST: Distritos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDistrito,Nombre,IdProvincia")] Distrito distrito)
        {
            if (id != distrito.IdDistrito)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(distrito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistritoExists(distrito.IdDistrito))
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
            ViewData["IdProvincia"] = new SelectList(_context.Provincias, "IdProvincia", "IdProvincia", distrito.IdProvincia);
            return View(distrito);
        }

        // GET: Distritos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distrito = await _context.Distritos
                .Include(d => d.Provincia)
                .FirstOrDefaultAsync(m => m.IdDistrito == id);
            if (distrito == null)
            {
                return NotFound();
            }

            return View(distrito);
        }

        // POST: Distritos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var distrito = await _context.Distritos.FindAsync(id);
            _context.Distritos.Remove(distrito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DistritoExists(int id)
        {
            return _context.Distritos.Any(e => e.IdDistrito == id);
        }
    }
}
