using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc;
using At_Yarisi.Models.siniflar;

namespace At_Yarisi.Controllers
{
    public class RaceController : Controller
    {
        private CONTEXT db = new CONTEXT();
        // GET: Race
        public ActionResult Index()
        {//Empty
            return View();
        }
        public ActionResult Race()
        {
            return View();
        }
        public ActionResult PastRacesPage()
        {
            ViewBag.Message = "Past Races Page ";

            return View(db.Rules.ToList());
        }
    }
}