using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using personats.Data.Context;
using personats.Data.Entity;

namespace personats.Controllers
{
    public class GraduationsController : Controller
    {
        private Context db = new Context();

        // GET: Graduations
        public ActionResult Index()
        {
            return View(db.Graduations.ToList());
        }

        // GET: Graduations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Graduation graduation = db.Graduations.Find(id);
            if (graduation == null)
            {
                return HttpNotFound();
            }
            return View(graduation);
        }

        // GET: Graduations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Graduations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Cpf,Birthdate,Address,Genre,Formation")] Graduation graduation)
        {
            if (ModelState.IsValid)
            {
                db.Graduations.Add(graduation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(graduation);
        }

        // GET: Graduations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Graduation graduation = db.Graduations.Find(id);
            if (graduation == null)
            {
                return HttpNotFound();
            }
            return View(graduation);
        }

        // POST: Graduations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Cpf,Birthdate,Address,Genre,Formation")] Graduation graduation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(graduation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(graduation);
        }

        // GET: Graduations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Graduation graduation = db.Graduations.Find(id);
            if (graduation == null)
            {
                return HttpNotFound();
            }
            return View(graduation);
        }

        // POST: Graduations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Graduation graduation = db.Graduations.Find(id);
            db.Graduations.Remove(graduation);
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