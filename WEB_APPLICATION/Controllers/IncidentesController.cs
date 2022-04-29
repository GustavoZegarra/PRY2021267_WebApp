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
    public class IncidentesController : Controller
    {
        private readonly DbApiApplicationContext _context;

        public IncidentesController(DbApiApplicationContext context)
        {
            _context = context;
        }

        // GET: Incidentes
        public async Task<IActionResult> Index()
        {
            var dbApiApplicationContext = _context.Incidentes.Include(i => i.GPS).Include(i => i.Motivo).Include(i => i.Quebrada).Include(i => i.Usuario);
            return View(await dbApiApplicationContext.ToListAsync());
        }

        // GET: Incidentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidente = await _context.Incidentes
                .Include(i => i.GPS)
                .Include(i => i.Motivo)
                .Include(i => i.Quebrada)
                .Include(i => i.Usuario)
                .FirstOrDefaultAsync(m => m.IdIncidente == id);
            if (incidente == null)
            {
                return NotFound();
            }

            return View(incidente);
        }

        // GET: Incidentes/Create
        public IActionResult Create()
        {
            ViewData["IdGPS"] = new SelectList(_context.GPSes, "IdGps", "IdGps");
            ViewData["IdMotivo"] = new SelectList(_context.Motivos, "IdMotivo", "Detalle");
            ViewData["IdQuebrada"] = new SelectList(_context.Quebradas, "IdQuebrada", "Nombre");
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "Nombre");
            return View();
        }

        public async Task<IActionResult> RenderImage(int id)
        {
            Incidente item = await _context.Incidentes.FindAsync(id);

            byte[] photoBack = item.Imagen;

            return File(photoBack, "image/png");
        }



        // POST: Incidentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdIncidente,Descripcion,Imagen,FechaRegistro,FechaActualizacion,Resuelto,IdUsuario,IdQuebrada,IdMotivo,IdGPS")] Incidente incidente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incidente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdGPS"] = new SelectList(_context.GPSes, "IdGps", "IdGps", incidente.IdGPS);
            ViewData["IdMotivo"] = new SelectList(_context.Motivos, "IdMotivo", "IdMotivo", incidente.IdMotivo);
            ViewData["IdQuebrada"] = new SelectList(_context.Quebradas, "IdQuebrada", "IdQuebrada", incidente.IdQuebrada);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", incidente.IdUsuario);
            return View(incidente);
        }

        // GET: Incidentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidente = await _context.Incidentes.FindAsync(id);
            if (incidente == null)
            {
                return NotFound();
            }
            ViewData["IdGPS"] = new SelectList(_context.GPSes, "IdGps", "IdGps", incidente.IdGPS);
            ViewData["IdMotivo"] = new SelectList(_context.Motivos, "IdMotivo", "Detalle", incidente.IdMotivo);
            ViewData["IdQuebrada"] = new SelectList(_context.Quebradas, "IdQuebrada", "Nombre", incidente.IdQuebrada);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "Nombre", incidente.IdUsuario);
            return View(incidente);
        }

        // POST: Incidentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdIncidente,Descripcion,Imagen,FechaRegistro,FechaActualizacion,Resuelto,IdUsuario,IdQuebrada,IdMotivo,IdGPS")] Incidente incidente)
        {
            if (id != incidente.IdIncidente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incidente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncidenteExists(incidente.IdIncidente))
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
            ViewData["IdGPS"] = new SelectList(_context.GPSes, "IdGps", "IdGps", incidente.IdGPS);
            ViewData["IdMotivo"] = new SelectList(_context.Motivos, "IdMotivo", "IdMotivo", incidente.IdMotivo);
            ViewData["IdQuebrada"] = new SelectList(_context.Quebradas, "IdQuebrada", "IdQuebrada", incidente.IdQuebrada);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", incidente.IdUsuario);
            return View(incidente);
        }

        // GET: Incidentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidente = await _context.Incidentes
                .Include(i => i.GPS)
                .Include(i => i.Motivo)
                .Include(i => i.Quebrada)
                .Include(i => i.Usuario)
                .FirstOrDefaultAsync(m => m.IdIncidente == id);
            if (incidente == null)
            {
                return NotFound();
            }

            return View(incidente);
        }

        // POST: Incidentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var incidente = await _context.Incidentes.FindAsync(id);
            _context.Incidentes.Remove(incidente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncidenteExists(int id)
        {
            return _context.Incidentes.Any(e => e.IdIncidente == id);
        }
    }
}
