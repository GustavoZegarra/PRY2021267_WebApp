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
    public class DNIController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public DNIController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: DNI
        public async Task<IActionResult> Index()
        {
            var dbApiApplicationContext = _context.DNIs.Include(d => d.Distrito);
            return View(await dbApiApplicationContext.ToListAsync());
        }

        // GET: DNI/Details/5
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

        // GET: DNI/Create
        public IActionResult Create()
        {
            ViewData["IdDistrito"] = new SelectList(_context.Distritos, "IdDistrito", "Nombre");
            return View();
        }

        // POST: DNI/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDni,Dni,CodVerificacion,Direccion,Referencia,IdDistrito")] DNI odni)
        {
            if (ModelState.IsValid)
            {
                _context.Add(odni);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDistrito"] = new SelectList(_context.Distritos, "IdDistrito", "IdDistrito", odni.IdDistrito);
            return View(odni);
        }

        // GET: DNI/Edit/5
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
            ViewData["IdDistrito"] = new SelectList(_context.Distritos, "IdDistrito", "Nombre", dNI.IdDistrito);
            return View(dNI);
        }

        // POST: DNI/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDni,Dni,CodVerificacion,Direccion,Referencia,IdDistrito")] DNI odni)
        {
            if (id != odni.IdDni)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(odni);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DNIExists(odni.IdDni))
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
            ViewData["IdDistrito"] = new SelectList(_context.Distritos, "IdDistrito", "IdDistrito", odni.IdDistrito);
            return View(odni);
        }

        // GET: DNI/Delete/5
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

        // POST: DNI/Delete/5
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
