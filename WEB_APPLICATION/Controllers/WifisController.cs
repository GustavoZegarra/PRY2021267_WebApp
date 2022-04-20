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
    public class WifisController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public WifisController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: Wifis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Wifis.ToListAsync());
        }

        // GET: Wifis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wifi = await _context.Wifis
                .FirstOrDefaultAsync(m => m.IdWifi == id);
            if (wifi == null)
            {
                return NotFound();
            }

            return View(wifi);
        }

        // GET: Wifis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wifis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdWifi,Modelo,Standar,Protocolo,Red")] Wifi wifi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wifi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wifi);
        }

        // GET: Wifis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wifi = await _context.Wifis.FindAsync(id);
            if (wifi == null)
            {
                return NotFound();
            }
            return View(wifi);
        }

        // POST: Wifis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdWifi,Modelo,Standar,Protocolo,Red")] Wifi wifi)
        {
            if (id != wifi.IdWifi)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wifi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WifiExists(wifi.IdWifi))
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
            return View(wifi);
        }

        // GET: Wifis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wifi = await _context.Wifis
                .FirstOrDefaultAsync(m => m.IdWifi == id);
            if (wifi == null)
            {
                return NotFound();
            }

            return View(wifi);
        }

        // POST: Wifis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wifi = await _context.Wifis.FindAsync(id);
            _context.Wifis.Remove(wifi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WifiExists(int id)
        {
            return _context.Wifis.Any(e => e.IdWifi == id);
        }
    }
}
