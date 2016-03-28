using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AngelShare.Models;
using AngelShare.Models.Repository;

namespace AngelShare.Controllers
{
    public class WhiskeysController : Controller
    {

        WhiskeyRepository repository = new WhiskeyRepository();

        public ActionResult Details(int id)
        {
            Whiskey whiskey = repository.Get(id);
            if (whiskey == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(whiskey);
            }
        }

        //EXAMPLE OF GETTING JUST THE SOLO ARTIST. DERIVED FROM THE ARTIST REPOSITORY: GETSOLOARTIST();
        //ALSO EXAMPLE OF INHERITANCE... SOLOARTIST:ARTIST
        //public ActionResult Index()
        //{
        //    return View(repository.GetSoloArtists());
        //}

        //GETS ALL ARTISTS
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Whiskey whiskey)
        {
            repository.Add(whiskey);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
