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
    public class SexualitiesController : Controller
    {
        private Context db = new Context();

        // GET: Sexualities
        public ActionResult Index()
        {
            return View(db.Sexualities.ToList());
        }

        // GET: Sexualities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sexuality sexuality = db.Sexualities.Find(id);
            if (sexuality == null)
            {
                return HttpNotFound();
            }
            return View(sexuality);
        }

        // GET: Sexualities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sexualities/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Cpf,Birthdate,Address,Genre,Formation")] Sexuality sexuality)
        {
            if (ModelState.IsValid)
            {
                db.Sexualities.Add(sexuality);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sexuality);
        }

        // GET: Sexualities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sexuality sexuality = db.Sexualities.Find(id);
            if (sexuality == null)
            {
                return HttpNotFound();
            }
            return View(sexuality);
        }

        // POST: Sexualities/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Cpf,Birthdate,Address,Genre,Formation")] Sexuality sexuality)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sexuality).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sexuality);
        }

        // GET: Sexualities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sexuality sexuality = db.Sexualities.Find(id);
            if (sexuality == null)
            {
                return HttpNotFound();
            }
            return View(sexuality);
        }

        // POST: Sexualities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sexuality sexuality = db.Sexualities.Find(id);
            db.Sexualities.Remove(sexuality);
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