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
    public class SensoresController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public SensoresController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: Sensores
        public async Task<IActionResult> Index()
        {
            var dbApiApplicationContext = _context.Sensores.Include(s => s.Quebrada).Include(s => s.Wifi);
            return View(await dbApiApplicationContext.ToListAsync());
        }

        // GET: Sensores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sensor = await _context.Sensores
                .Include(s => s.Quebrada)
                .Include(s => s.Wifi)
                .FirstOrDefaultAsync(m => m.IdSensor == id);
            if (sensor == null)
            {
                return NotFound();
            }

            return View(sensor);
        }

        // GET: Sensores/Create
        public IActionResult Create()
        {
            ViewData["IdQuebrada"] = new SelectList(_context.Quebradas, "IdQuebrada", "Nombre");
            ViewData["IdWifi"] = new SelectList(_context.Wifis, "IdWifi", "Modelo");
            return View();
        }

        // POST: Sensores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSensor,Modelo,PrecipitacionMax,PrecipitacionMin,IdQuebrada,IdWifi")] Sensor sensor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sensor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdQuebrada"] = new SelectList(_context.Quebradas, "IdQuebrada", "IdQuebrada", sensor.IdQuebrada);
            ViewData["IdWifi"] = new SelectList(_context.Wifis, "IdWifi", "IdWifi", sensor.IdWifi);
            return View(sensor);
        }

        // GET: Sensores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sensor = await _context.Sensores.FindAsync(id);
            if (sensor == null)
            {
                return NotFound();
            }
            ViewData["IdQuebrada"] = new SelectList(_context.Quebradas, "IdQuebrada", "Nombre", sensor.IdQuebrada);
            ViewData["IdWifi"] = new SelectList(_context.Wifis, "IdWifi", "Modelo", sensor.IdWifi);
            return View(sensor);
        }

        // POST: Sensores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSensor,Modelo,PrecipitacionMax,PrecipitacionMin,IdQuebrada,IdWifi")] Sensor sensor)
        {
            if (id != sensor.IdSensor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sensor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SensorExists(sensor.IdSensor))
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
            ViewData["IdQuebrada"] = new SelectList(_context.Quebradas, "IdQuebrada", "IdQuebrada", sensor.IdQuebrada);
            ViewData["IdWifi"] = new SelectList(_context.Wifis, "IdWifi", "IdWifi", sensor.IdWifi);
            return View(sensor);
        }

        // GET: Sensores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sensor = await _context.Sensores
                .Include(s => s.Quebrada)
                .Include(s => s.Wifi)
                .FirstOrDefaultAsync(m => m.IdSensor == id);
            if (sensor == null)
            {
                return NotFound();
            }

            return View(sensor);
        }

        // POST: Sensores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sensor = await _context.Sensores.FindAsync(id);
            _context.Sensores.Remove(sensor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SensorExists(int id)
        {
            return _context.Sensores.Any(e => e.IdSensor == id);
        }
    }
}
