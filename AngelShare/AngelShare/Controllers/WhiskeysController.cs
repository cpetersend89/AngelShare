using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AngelShare.Models;

namespace AngelShare.Controllers
{
    public class WhiskeysController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Whiskeys
        public ActionResult Index()
        {
            return View(db.Whiskeys.ToList());
        }

        // GET: Whiskeys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Whiskey whiskey = db.Whiskeys.Find(id);
            if (whiskey == null)
            {
                return HttpNotFound();
            }
            return View(whiskey);
        }

        // GET: Whiskeys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Whiskeys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,ProductName,Description,Proof,Age,Cost")] Whiskey whiskey)
        {
            if (ModelState.IsValid)
            {
                db.Whiskeys.Add(whiskey);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(whiskey);
        }

        // GET: Whiskeys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Whiskey whiskey = db.Whiskeys.Find(id);
            if (whiskey == null)
            {
                return HttpNotFound();
            }
            return View(whiskey);
        }

        // POST: Whiskeys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,ProductName,Description,Proof,Age,Cost")] Whiskey whiskey)
        {
            if (ModelState.IsValid)
            {
                db.Entry(whiskey).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(whiskey);
        }

        // GET: Whiskeys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Whiskey whiskey = db.Whiskeys.Find(id);
            if (whiskey == null)
            {
                return HttpNotFound();
            }
            return View(whiskey);
        }

        // POST: Whiskeys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Whiskey whiskey = db.Whiskeys.Find(id);
            db.Whiskeys.Remove(whiskey);
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
