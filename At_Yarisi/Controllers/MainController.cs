using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace At_Yarisi.Controllers
{
    public class MainController : Controller
    {
        // GET: Main

        //Main Menüden sonraki viewler için

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MainMenuPage()
        {
            return View();
        }
    }
}