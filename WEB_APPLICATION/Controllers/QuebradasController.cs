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
    public class QuebradasController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public QuebradasController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: Quebradas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quebradas.ToListAsync());
        }

        // GET: Quebradas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quebrada = await _context.Quebradas
                .FirstOrDefaultAsync(m => m.IdQuebrada == id);
            if (quebrada == null)
            {
                return NotFound();
            }

            return View(quebrada);
        }

        // GET: Quebradas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quebradas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdQuebrada,Nombre,Descripcion")] Quebrada quebrada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quebrada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quebrada);
        }

        // GET: Quebradas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quebrada = await _context.Quebradas.FindAsync(id);
            if (quebrada == null)
            {
                return NotFound();
            }
            return View(quebrada);
        }

        // POST: Quebradas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdQuebrada,Nombre,Descripcion")] Quebrada quebrada)
        {
            if (id != quebrada.IdQuebrada)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quebrada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuebradaExists(quebrada.IdQuebrada))
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
            return View(quebrada);
        }

        // GET: Quebradas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quebrada = await _context.Quebradas
                .FirstOrDefaultAsync(m => m.IdQuebrada == id);
            if (quebrada == null)
            {
                return NotFound();
            }

            return View(quebrada);
        }

        // POST: Quebradas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quebrada = await _context.Quebradas.FindAsync(id);
            _context.Quebradas.Remove(quebrada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuebradaExists(int id)
        {
            return _context.Quebradas.Any(e => e.IdQuebrada == id);
        }
    }
}
