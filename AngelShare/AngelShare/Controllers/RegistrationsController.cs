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
    public class RegistrationsController : Controller
    {
        private AngelShareContext db = new AngelShareContext();

        public ActionResult Index()
        {
            return View(new Member());
        }

        public RedirectToRouteResult Register(Member member)
        {
            member.Password = SHA256.Encode(member.Password);

            db.Members.Add(member);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
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
