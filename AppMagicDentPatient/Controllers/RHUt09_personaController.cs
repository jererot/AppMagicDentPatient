using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppMagicDentPatient.Models;

namespace AppMagicDentPatient.Controllers
{
    public class RHUt09_personaController : Controller
    {
        private BDMagicDentEntities db = new BDMagicDentEntities();

        // GET: RHUt09_persona
        public async Task<ActionResult> Index()
        {
            var rHUt09_persona = db.RHUt09_persona.Include(r => r.RHUt05_estadoCivil).Include(r => r.RHUt12_tipoDocIdentidad).Include(r => r.UBIt01_distrito).Include(r => r.UBIt04_via).Include(r => r.UBIt05_zona);
            return View(await rHUt09_persona.ToListAsync());
        }

        // GET: RHUt09_persona/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHUt09_persona rHUt09_persona = await db.RHUt09_persona.FindAsync(id);
            if (rHUt09_persona == null)
            {
                return HttpNotFound();
            }
            return View(rHUt09_persona);
        }

        // GET: RHUt09_persona/Create
        public ActionResult Create()
        {
            ViewBag.idEstadoCivil = new SelectList(db.RHUt05_estadoCivil, "idEstadoCivil", "descEstadoCivil");
            ViewBag.idTipoDocIdentidad = new SelectList(db.RHUt12_tipoDocIdentidad, "idTipoDocIdentidad", "descTipoDocIdentidad");
            ViewBag.idDistrito = new SelectList(db.UBIt01_distrito, "idDistrito", "nombreDistrito");
            ViewBag.idVia = new SelectList(db.UBIt04_via, "idVia", "descVia");
            ViewBag.idZona = new SelectList(db.UBIt05_zona, "idZona", "descZona");

            return View();
        }

        // POST: RHUt09_persona/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idPersona,nombrePersona,apellidoPaterno,apellidoMaterno,numDocIdentidad,razonSocial,fecNacimiento,nombreVia,numVia,nombreZona,direccion01,direccion02,numTelefonico01,numTelefonico02,email01,email02,sexo,difunto,fecDefuncion,pathFoto,activo,fecRegistro,fecModificacion,fecEliminacion,idUsuario,idUsuarioModificar,idUsuarioEliminar,idVia,idZona,idTipoDocIdentidad,idDistrito,idEstadoCivil")] RHUt09_persona rHUt09_persona)
        {
            if (ModelState.IsValid)
            {
                db.RHUt09_persona.Add(rHUt09_persona);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idEstadoCivil = new SelectList(db.RHUt05_estadoCivil, "idEstadoCivil", "descEstadoCivil", rHUt09_persona.idEstadoCivil);
            ViewBag.idTipoDocIdentidad = new SelectList(db.RHUt12_tipoDocIdentidad, "idTipoDocIdentidad", "descTipoDocIdentidad", rHUt09_persona.idTipoDocIdentidad);
            ViewBag.idDistrito = new SelectList(db.UBIt01_distrito, "idDistrito", "nombreDistrito", rHUt09_persona.idDistrito);
            ViewBag.idVia = new SelectList(db.UBIt04_via, "idVia", "descVia", rHUt09_persona.idVia);
            ViewBag.idZona = new SelectList(db.UBIt05_zona, "idZona", "descZona", rHUt09_persona.idZona);
            return View(rHUt09_persona);
        }

        // GET: RHUt09_persona/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHUt09_persona rHUt09_persona = await db.RHUt09_persona.FindAsync(id);
            if (rHUt09_persona == null)
            {
                return HttpNotFound();
            }
            ViewBag.idEstadoCivil = new SelectList(db.RHUt05_estadoCivil, "idEstadoCivil", "descEstadoCivil", rHUt09_persona.idEstadoCivil);
            ViewBag.idTipoDocIdentidad = new SelectList(db.RHUt12_tipoDocIdentidad, "idTipoDocIdentidad", "descTipoDocIdentidad", rHUt09_persona.idTipoDocIdentidad);
            ViewBag.idDistrito = new SelectList(db.UBIt01_distrito, "idDistrito", "nombreDistrito", rHUt09_persona.idDistrito);
            ViewBag.idVia = new SelectList(db.UBIt04_via, "idVia", "descVia", rHUt09_persona.idVia);
            ViewBag.idZona = new SelectList(db.UBIt05_zona, "idZona", "descZona", rHUt09_persona.idZona);
            return View(rHUt09_persona);
        }

        // POST: RHUt09_persona/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idPersona,nombrePersona,apellidoPaterno,apellidoMaterno,numDocIdentidad,razonSocial,fecNacimiento,nombreVia,numVia,nombreZona,direccion01,direccion02,numTelefonico01,numTelefonico02,email01,email02,sexo,difunto,fecDefuncion,pathFoto,activo,fecRegistro,fecModificacion,fecEliminacion,idUsuario,idUsuarioModificar,idUsuarioEliminar,idVia,idZona,idTipoDocIdentidad,idDistrito,idEstadoCivil")] RHUt09_persona rHUt09_persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rHUt09_persona).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idEstadoCivil = new SelectList(db.RHUt05_estadoCivil, "idEstadoCivil", "descEstadoCivil", rHUt09_persona.idEstadoCivil);
            ViewBag.idTipoDocIdentidad = new SelectList(db.RHUt12_tipoDocIdentidad, "idTipoDocIdentidad", "descTipoDocIdentidad", rHUt09_persona.idTipoDocIdentidad);
            ViewBag.idDistrito = new SelectList(db.UBIt01_distrito, "idDistrito", "nombreDistrito", rHUt09_persona.idDistrito);
            ViewBag.idVia = new SelectList(db.UBIt04_via, "idVia", "descVia", rHUt09_persona.idVia);
            ViewBag.idZona = new SelectList(db.UBIt05_zona, "idZona", "descZona", rHUt09_persona.idZona);
            return View(rHUt09_persona);
        }

        // GET: RHUt09_persona/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHUt09_persona rHUt09_persona = await db.RHUt09_persona.FindAsync(id);
            if (rHUt09_persona == null)
            {
                return HttpNotFound();
            }
            return View(rHUt09_persona);
        }

        // POST: RHUt09_persona/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            RHUt09_persona rHUt09_persona = await db.RHUt09_persona.FindAsync(id);
            db.RHUt09_persona.Remove(rHUt09_persona);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
