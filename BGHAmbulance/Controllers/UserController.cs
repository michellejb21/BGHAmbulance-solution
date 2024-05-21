using BGHAmbulance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BGHAmbulance.Controllers
{
    public class UserController : Controller
    {
        private BGHAmbulanceEntities db = new BGHAmbulanceEntities();

        // GET
        public ActionResult Index()
        {
            return View(db.AspNetUsers.ToList());
        }

        public ActionResult ManageRole(string id)
        {
            UserRole model = new UserRole();
            model.Id = id;
            model.U = db.AspNetUsers.Find(id);
            model.Roles = db.AspNetRoles.ToList();
            return View(model);
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ManageRole(UserRole model)
        {
            if (ModelState.IsValid)
            {
                db.sp_AddUpdateUserRole(model.Id, model.RoleId);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}