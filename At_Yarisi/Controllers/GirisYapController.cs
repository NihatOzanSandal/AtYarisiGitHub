using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using At_Yarisi.Models.siniflar;

namespace At_Yarisi.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        CONTEXT c = new CONTEXT();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Members ad)
        {
            var bilgiler = c.Members.FirstOrDefault(x => x.Email == ad.Email && x.Password == ad.Password);
            if (bilgiler != null)
            {

                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                Session["Email"] = bilgiler.Email.ToString();
                return RedirectToAction("MainMenuPage", "Main");
            }
            else
            {
                return View();
            }
        }
    }
}