﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BGHAmbulance;

namespace BGHAmbulance.Controllers
{
    [Authorize]
    public class AmbulancesController : Controller
    {
        private BGHAmbulanceEntities db = new BGHAmbulanceEntities();

        // GET: Ambulances
        public ActionResult Index()
        {
            return View(db.Ambulances.ToList());
        }

        // GET: Ambulances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ambulance ambulance = db.Ambulances.Find(id);
            if (ambulance == null)
            {
                return HttpNotFound();
            }
            return View(ambulance);
        }

        // GET: Ambulances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ambulances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AmbName,AmbNo,AmbMake,AmbModel,AmbDriver")] Ambulance ambulance)
        {
            if (ModelState.IsValid)
            {
                db.Ambulances.Add(ambulance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ambulance);
        }

        // GET: Ambulances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ambulance ambulance = db.Ambulances.Find(id);
            if (ambulance == null)
            {
                return HttpNotFound();
            }
            return View(ambulance);
        }

        // POST: Ambulances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AmbName,AmbNo,AmbMake,AmbModel,AmbDriver")] Ambulance ambulance)
        {
            if (ModelState.IsValid)
            {
                ambulance.AmbUpadtedBy= User.Identity.Name;
                ambulance.AmbUpdatedOn = DateTime.Now;
                db.Entry(ambulance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ambulance);
        }

        // GET: Ambulances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ambulance ambulance = db.Ambulances.Find(id);
            if (ambulance == null)
            {
                return HttpNotFound();
            }
            return View(ambulance);
        }

        // POST: Ambulances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ambulance ambulance = db.Ambulances.Find(id);
            db.Ambulances.Remove(ambulance);
            db.SaveChanges();
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
