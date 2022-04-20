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
    public class DNIsController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public DNIsController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: DNIs
        public async Task<IActionResult> Index()
        {
            var dbApiApplicationContext = _context.DNIs.Include(d => d.Distrito);
            return View(await dbApiApplicationContext.ToListAsync());
        }

        // GET: DNIs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dNI = await _context.DNIs
                .Include(d => d.Distrito)
                .FirstOrDefaultAsync(m => m.IdDni == id);
            if (dNI == null)
            {
                return NotFound();
            }

            return View(dNI);
        }

        // GET: DNIs/Create
        public IActionResult Create()
        {
            ViewData["IdDistrito"] = new SelectList(_context.Distritos, "IdDistrito", "IdDistrito");
            return View();
        }

        // POST: DNIs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDni,Dni,CodVerificacion,Direccion,Referencia,IdDistrito")] DNI dNI)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dNI);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDistrito"] = new SelectList(_context.Distritos, "IdDistrito", "IdDistrito", dNI.IdDistrito);
            return View(dNI);
        }

        // GET: DNIs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dNI = await _context.DNIs.FindAsync(id);
            if (dNI == null)
            {
                return NotFound();
            }
            ViewData["IdDistrito"] = new SelectList(_context.Distritos, "IdDistrito", "IdDistrito", dNI.IdDistrito);
            return View(dNI);
        }

        // POST: DNIs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDni,Dni,CodVerificacion,Direccion,Referencia,IdDistrito")] DNI dNI)
        {
            if (id != dNI.IdDni)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dNI);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DNIExists(dNI.IdDni))
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
            ViewData["IdDistrito"] = new SelectList(_context.Distritos, "IdDistrito", "IdDistrito", dNI.IdDistrito);
            return View(dNI);
        }

        // GET: DNIs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dNI = await _context.DNIs
                .Include(d => d.Distrito)
                .FirstOrDefaultAsync(m => m.IdDni == id);
            if (dNI == null)
            {
                return NotFound();
            }

            return View(dNI);
        }

        // POST: DNIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dNI = await _context.DNIs.FindAsync(id);
            _context.DNIs.Remove(dNI);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DNIExists(int id)
        {
            return _context.DNIs.Any(e => e.IdDni == id);
        }
    }
}
