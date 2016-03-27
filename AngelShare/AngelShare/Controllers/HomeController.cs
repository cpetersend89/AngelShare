using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngelShare.Models;
using Microsoft.AspNet.Identity;

namespace AngelShare.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext db = new MyDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            string userId = User.Identity.GetUserId();
            List<Survey> surveys = db.Surveys.Select(m => m).Where(s => s.UserId == userId).ToList();
            
            return View(surveys.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}