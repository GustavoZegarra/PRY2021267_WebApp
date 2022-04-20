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
    public class GPSController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public GPSController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: GPS
        public async Task<IActionResult> Index()
        {
            return View(await _context.GPSes.ToListAsync());
        }

        // GET: GPS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gPS = await _context.GPSes
                .FirstOrDefaultAsync(m => m.IdGps == id);
            if (gPS == null)
            {
                return NotFound();
            }

            return View(gPS);
        }

        // GET: GPS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GPS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGps,Latitud,Longitud")] GPS gPS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gPS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gPS);
        }

        // GET: GPS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gPS = await _context.GPSes.FindAsync(id);
            if (gPS == null)
            {
                return NotFound();
            }
            return View(gPS);
        }

        // POST: GPS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdGps,Latitud,Longitud")] GPS gPS)
        {
            if (id != gPS.IdGps)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gPS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GPSExists(gPS.IdGps))
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
            return View(gPS);
        }

        // GET: GPS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gPS = await _context.GPSes
                .FirstOrDefaultAsync(m => m.IdGps == id);
            if (gPS == null)
            {
                return NotFound();
            }

            return View(gPS);
        }

        // POST: GPS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gPS = await _context.GPSes.FindAsync(id);
            _context.GPSes.Remove(gPS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GPSExists(int id)
        {
            return _context.GPSes.Any(e => e.IdGps == id);
        }
    }
}
