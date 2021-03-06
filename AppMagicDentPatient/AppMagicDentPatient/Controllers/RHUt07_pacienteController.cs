﻿using System;
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
    public class RHUt07_pacienteController : Controller
    {
        private BDMagicDentEntities db = new BDMagicDentEntities();

        // GET: RHUt07_paciente
        public async Task<ActionResult> Index()
        {
            var rHUt07_paciente = db.RHUt07_paciente.Include(r => r.RHUt09_persona);
            return View(await rHUt07_paciente.ToListAsync());
        }

        // GET: RHUt07_paciente/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHUt07_paciente rHUt07_paciente = await db.RHUt07_paciente.FindAsync(id);
            if (rHUt07_paciente == null)
            {
                return HttpNotFound();
            }
            return View(rHUt07_paciente);
        }

        // GET: RHUt07_paciente/Create
        public ActionResult Create()
        {
            ViewBag.idPersona = new SelectList(db.RHUt09_persona, "idPersona", "nombrePersona");
            return View();
        }

        // POST: RHUt07_paciente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idPaciente,codPaciente,numHistoriaClinica,grupoSanguineo,info01,info02,info03,obsvPaciente,activo,fecRegistro,fecModificacion,fecEliminacion,idUsuario,idUsuarioModificar,idUsuarioEliminar,idPersona")] RHUt07_paciente rHUt07_paciente)
        {
            if (ModelState.IsValid)
            {
                db.RHUt07_paciente.Add(rHUt07_paciente);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idPersona = new SelectList(db.RHUt09_persona, "idPersona", "nombrePersona", rHUt07_paciente.idPersona);
            return View(rHUt07_paciente);
        }

        // GET: RHUt07_paciente/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHUt07_paciente rHUt07_paciente = await db.RHUt07_paciente.FindAsync(id);
            if (rHUt07_paciente == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPersona = new SelectList(db.RHUt09_persona, "idPersona", "nombrePersona", rHUt07_paciente.idPersona);
            return View(rHUt07_paciente);
        }

        // POST: RHUt07_paciente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idPaciente,codPaciente,numHistoriaClinica,grupoSanguineo,info01,info02,info03,obsvPaciente,activo,fecRegistro,fecModificacion,fecEliminacion,idUsuario,idUsuarioModificar,idUsuarioEliminar,idPersona")] RHUt07_paciente rHUt07_paciente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rHUt07_paciente).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idPersona = new SelectList(db.RHUt09_persona, "idPersona", "nombrePersona", rHUt07_paciente.idPersona);
            return View(rHUt07_paciente);
        }

        // GET: RHUt07_paciente/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHUt07_paciente rHUt07_paciente = await db.RHUt07_paciente.FindAsync(id);
            if (rHUt07_paciente == null)
            {
                return HttpNotFound();
            }
            return View(rHUt07_paciente);
        }

        // POST: RHUt07_paciente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            RHUt07_paciente rHUt07_paciente = await db.RHUt07_paciente.FindAsync(id);
            db.RHUt07_paciente.Remove(rHUt07_paciente);
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
