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
    public class ContinentesController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public ContinentesController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: Continentes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Continentes.ToListAsync());
        }

        // GET: Continentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var continente = await _context.Continentes
                .FirstOrDefaultAsync(m => m.IdContinente == id);
            if (continente == null)
            {
                return NotFound();
            }

            return View(continente);
        }

        // GET: Continentes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Continentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdContinente,Nombre,Codigo")] Continente continente)
        {
            if (ModelState.IsValid)
            {
                var conti = _context.Continentes.ToList();
                bool flag = false;
                foreach (Continente con in conti)
                {
                    if (con.Nombre == continente.Nombre)
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    Response.StatusCode = 400;
                    return Content("<center><h2>El Continente registrado ya existe</h2></center>", "text/html");
                }

                _context.Add(continente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(continente);
        }

        // GET: Continentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var continente = await _context.Continentes.FindAsync(id);
            if (continente == null)
            {
                return NotFound();
            }
            return View(continente);
        }

        // POST: Continentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdContinente,Nombre,Codigo")] Continente continente)
        {
            if (id != continente.IdContinente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(continente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContinenteExists(continente.IdContinente))
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
            return View(continente);
        }

        // GET: Continentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var continente = await _context.Continentes
                .FirstOrDefaultAsync(m => m.IdContinente == id);
            if (continente == null)
            {
                return NotFound();
            }

            return View(continente);
        }

        // POST: Continentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var continente = await _context.Continentes.FindAsync(id);
            _context.Continentes.Remove(continente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContinenteExists(int id)
        {
            return _context.Continentes.Any(e => e.IdContinente == id);
        }
    }
}
