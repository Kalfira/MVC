using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SampleSite.Models;
using SampleSite.DAL;

namespace SampleSite.Controllers
{
    public class UserController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Logins
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: Logins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User logins = db.Users.Find(id);
            if (logins == null)
            {
                return HttpNotFound();
            }
            return View(logins);
        }

        // GET: Logins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Logins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Pass")] User logins)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(logins);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(logins);
        }

        // GET: Logins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Logins logins = db.Logins.Find(id);
            if (logins == null)
            {
                return HttpNotFound();
            }
            return View(logins);
        }

        // POST: Logins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Pass")] Logins logins)
        {
            if (ModelState.IsValid)
            {
                db.Entry(logins).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(logins);
        }

        // GET: Logins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User logins = db.Users.Find(id);
            if (logins == null)
            {
                return HttpNotFound();
            }
            return View(logins);
        }

        // POST: Logins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User logins = db.Users.Find(id);
            db.Users.Remove(logins);
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
