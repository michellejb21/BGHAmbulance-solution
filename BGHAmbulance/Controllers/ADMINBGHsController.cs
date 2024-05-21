using System;
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
    public class ADMINBGHsController : Controller
    {
        private BGHAmbulanceEntities db = new BGHAmbulanceEntities();

        // GET: ADMINBGHs
        public ActionResult Index()
        {
            return View(db.ADMINBGHs.ToList());
        }

        // GET: ADMINBGHs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINBGH aDMINBGH = db.ADMINBGHs.Find(id);
            if (aDMINBGH == null)
            {
                return HttpNotFound();
            }
            return View(aDMINBGH);
        }

        // GET: ADMINBGHs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ADMINBGHs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "adminid,name,phoneno,email")] ADMINBGH aDMINBGH)
        {
            if (ModelState.IsValid)
            {
                db.ADMINBGHs.Add(aDMINBGH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aDMINBGH);
        }

        // GET: ADMINBGHs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINBGH aDMINBGH = db.ADMINBGHs.Find(id);
            if (aDMINBGH == null)
            {
                return HttpNotFound();
            }
            return View(aDMINBGH);
        }

        // POST: ADMINBGHs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "adminid,name,phoneno,email")] ADMINBGH aDMINBGH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aDMINBGH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aDMINBGH);
        }

        // GET: ADMINBGHs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINBGH aDMINBGH = db.ADMINBGHs.Find(id);
            if (aDMINBGH == null)
            {
                return HttpNotFound();
            }
            return View(aDMINBGH);
        }

        // POST: ADMINBGHs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ADMINBGH aDMINBGH = db.ADMINBGHs.Find(id);
            db.ADMINBGHs.Remove(aDMINBGH);
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
