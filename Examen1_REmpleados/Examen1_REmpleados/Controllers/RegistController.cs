using Examen1_REmpleados.Data;
using Examen1_REmpleados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1_REmpleados.Controllers
{
    public class RegistController : Controller
    {
        private readonly ApplicationDbContext db;

         public RegistController(ApplicationDbContext db)
          {
            this.db = db;
          }

        public async Task<IActionResult> Index(string search)
        {
            if (search == null)
            {
                return View(await db.Registros.ToListAsync());
            }

            return View(await db.Registros
                .Where(r => r.RegistNombre.Contains(search))
                .ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reg = await db.Registros.FirstOrDefaultAsync(b => b.RegistId == id);
            if (reg == null)
            {
                return NotFound();
            }
            return View(reg);

        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Regist regist)
        {
            if (ModelState.IsValid)
            {
                db.Add(regist);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(regist);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reg = await db.Registros.FindAsync(id);

            if (reg == null)
            {
                return NotFound();
            }

            return View(reg);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Regist regist)
        {
            if (id != regist.RegistId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(regist);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));


            }
            return View(regist);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reg= await db.Registros.FindAsync(id);

            if (reg == null)
            {
                return NotFound();
            }

            return View(reg);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Regist regist)
        {
            var reg = await db.Registros.FindAsync(id);
            db.Registros.Remove(reg);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

