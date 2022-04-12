using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using At_Yarisi.Models.siniflar;
using System.Web.Security;

namespace At_Yarisi.Controllers
{
    public class HomeController : Controller
    {
        private CONTEXT db = new CONTEXT();
        public ActionResult LoginPage()
        {
            ViewBag.Message = "Login Page";

            return View();
        }
        [HttpPost]
        /*
         //c.admins first or default ne oluyor onu öğren düzenle
         
        public ActionResult Login(Members ad)
        {
            //var bilgiler = CONTEXT.Members.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);

            var bilgiler =Members.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);

            if (bilgiler != null)
            {

                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        */
        public ActionResult GetStartedPage()
        {
            ViewBag.Message = "Get Started Page ";

            return View();
        }
        //Kullanıcı başlangıç login işlemi seçme ekranı ->       
        public ActionResult CreateAccountPage()
        {
            ViewBag.Message = "Create Account Page ";

            return View();
        }
        public ActionResult CreateAccount2Page()
        {
            ViewBag.Message = "Create Account Second Page ";

            return View();
        }
        public ActionResult ForgetPasswordPage()
        {
            ViewBag.Message = "Forget Password Screen-1 ";

            return View();
        }
        public ActionResult ForgetPassword2Page()
        {
            ViewBag.Message = "Forget Password Screen-2 ";

            return View();
        }
        public ActionResult StartupSelectionPage()
        {
            ViewBag.Message = "Startup Selection Page ";

            return View();
        }
        public ActionResult RulesPage()
        {
            ViewBag.Message = "Rules Page";

            return View();
        }

    }
}