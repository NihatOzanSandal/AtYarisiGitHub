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
        
        public ActionResult SetMain(Members ad, String Email)
        {
            var bilgiler = c.Members.FirstOrDefault(x => x.Email == ad.Email && x.Password == ad.Password);
            if (bilgiler != null)
            {
                //YANLIŞSA KONTROLÜ EKLENMELİ

                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                Session["Email"] = bilgiler.Email.ToString();

                Members uye = new Members();
                uye.Email = Email;

                return View(uye);
                //return RedirectToAction("SetMain","GirisYap");
                return View("MainMenuPage");
            }
            else
            {             
                return View("Login");
            }
        }
        //ANA EKRANDAN ÖNCESİ
        /*
        public ActionResult Login(Members ad)
        {
            var bilgiler = c.Members.FirstOrDefault(x => x.Email == ad.Email && x.Password == ad.Password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                Session["Email"] = bilgiler.Email.ToString();
                return RedirectToAction("MainMenuPage", "Main");
                //return View("MainMenuPage");
            }
            else
            {
                return View();
            }
        }

        public ActionResult SetMain(Members ad, String Email)
        {
            var bilgiler = c.Members.FirstOrDefault(x => x.Email == ad.Email && x.Password == ad.Password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                Session["Email"] = bilgiler.Email.ToString();

                Members uye = new Members();
                uye.Email = Email;

                return View(uye);
                //return View("MainMenuPage");
            }
            else
            {
                return View();
            }

        }

        */



    }
}