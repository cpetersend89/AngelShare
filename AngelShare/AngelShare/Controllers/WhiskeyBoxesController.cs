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
    public class WhiskeyBoxesController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: WhiskeyBoxes
        public ActionResult Index()
        {
            return View(db.WhiskeyBoxes.ToList());
        }

        // GET: WhiskeyBoxes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WhiskeyBox whiskeyBox = db.WhiskeyBoxes.Find(id);
            if (whiskeyBox == null)
            {
                return HttpNotFound();
            }
            return View(whiskeyBox);
        }

        // GET: WhiskeyBoxes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WhiskeyBoxes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WhiskeyID")] WhiskeyBox whiskeyBox)
        {
            if (ModelState.IsValid)
            {
                db.WhiskeyBoxes.Add(whiskeyBox);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(whiskeyBox);
        }

        // GET: WhiskeyBoxes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WhiskeyBox whiskeyBox = db.WhiskeyBoxes.Find(id);
            if (whiskeyBox == null)
            {
                return HttpNotFound();
            }
            return View(whiskeyBox);
        }

        // POST: WhiskeyBoxes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WhiskeyID")] WhiskeyBox whiskeyBox)
        {
            if (ModelState.IsValid)
            {
                db.Entry(whiskeyBox).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(whiskeyBox);
        }

        // GET: WhiskeyBoxes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WhiskeyBox whiskeyBox = db.WhiskeyBoxes.Find(id);
            if (whiskeyBox == null)
            {
                return HttpNotFound();
            }
            return View(whiskeyBox);
        }

        // POST: WhiskeyBoxes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WhiskeyBox whiskeyBox = db.WhiskeyBoxes.Find(id);
            db.WhiskeyBoxes.Remove(whiskeyBox);
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
