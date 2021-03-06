using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB_APPLICATION.Models;
using WEB_APPLICATION.Util;
//using PagedList;

namespace WEB_APPLICATION.Controllers
{
    public class AlertasController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public AlertasController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: Alertas
        public async Task<IActionResult> Index(string currentFilter,string quebrada,int? pageNumber)
        {

            if (quebrada != null)
            {
                pageNumber = 1;
            }
            else
            {
                quebrada = currentFilter;
            }

            ViewData["currentFilter"] = quebrada;

            var AlertaLst= new List<string>();
            var AlertaQry = from qd in _context.Quebradas
                            orderby qd.IdQuebrada
                            select qd.Nombre;
            AlertaLst.AddRange(AlertaQry.Distinct());
            
            ViewBag.quebrada= new SelectList(AlertaLst);

            var alertas =  _context.Alertas.Include(a => a.Nivel).Include(a => a.Sensor).Include(a=>a.Sensor.Quebrada).AsQueryable();
        

            if (!String.IsNullOrEmpty(quebrada))
            {
                alertas = _context.Alertas.Include(a => a.Nivel).Include(a => a.Sensor).
                Include(a => a.Sensor.Quebrada).Where(p => p.Sensor.Quebrada.Nombre == quebrada).AsQueryable();
            }
            //return View( alertas);


            int pageSize = 5;
            return View(await PaginatedList<Alerta>.CreateAsync(alertas.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Alertas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alerta = await _context.Alertas
                .Include(a => a.Nivel)
                .Include(a => a.Sensor)
                .FirstOrDefaultAsync(m => m.IdAlerta == id);
            if (alerta == null)
            {
                return NotFound();
            }

            return View(alerta);
        }

        // GET: Alertas/Create
        public IActionResult Create()
        {
            ViewData["IdNivel"] = new SelectList(_context.Niveles, "IdNivel", "Riesgo");
            ViewData["IdSensor"] = new SelectList(_context.Sensores, "IdSensor", "Modelo");
            return View();
        }

        // POST: Alertas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAlerta,PrecipitacionProm,PrecipitacionMax,PrecipitacionMin,Descripcion,FechaRegistro,IdNivel,IdSensor")] Alerta alerta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alerta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdNivel"] = new SelectList(_context.Niveles, "IdNivel", "IdNivel", alerta.IdNivel);
            ViewData["IdSensor"] = new SelectList(_context.Sensores, "IdSensor", "IdSensor", alerta.IdSensor);
            return View(alerta);
        }

        // GET: Alertas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alerta = await _context.Alertas.FindAsync(id);
            if (alerta == null)
            {
                return NotFound();
            }
            ViewData["IdNivel"] = new SelectList(_context.Niveles, "IdNivel", "Riesgo", alerta.IdNivel);
            ViewData["IdSensor"] = new SelectList(_context.Sensores, "IdSensor", "Modelo", alerta.IdSensor);
            return View(alerta);
        }

        // POST: Alertas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAlerta,PrecipitacionProm,PrecipitacionMax,PrecipitacionMin,Descripcion,FechaRegistro,IdNivel,IdSensor")] Alerta alerta)
        {
            if (id != alerta.IdAlerta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alerta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlertaExists(alerta.IdAlerta))
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
            ViewData["IdNivel"] = new SelectList(_context.Niveles, "IdNivel", "IdNivel", alerta.IdNivel);
            ViewData["IdSensor"] = new SelectList(_context.Sensores, "IdSensor", "IdSensor", alerta.IdSensor);
            return View(alerta);
        }

        // GET: Alertas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alerta = await _context.Alertas
                .Include(a => a.Nivel)
                .Include(a => a.Sensor)
                .FirstOrDefaultAsync(m => m.IdAlerta == id);
            if (alerta == null)
            {
                return NotFound();
            }

            return View(alerta);
        }

        // POST: Alertas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alerta = await _context.Alertas.FindAsync(id);
            _context.Alertas.Remove(alerta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlertaExists(int id)
        {
            return _context.Alertas.Any(e => e.IdAlerta == id);
        }
    }
}
