using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using At_Yarisi.Models.siniflar;

namespace At_Yarisi.Controllers
{
    public class UsersController : Controller
    {
        private CONTEXT db = new CONTEXT();
        // GET: Users
        public ActionResult Index()
        {
            return View(db.Members.ToList());
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]//HttpPost Araştır 
        public ActionResult Register(Members member)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(member);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Some Error Occured!");
            }
            return View(member);
        }

    }
}