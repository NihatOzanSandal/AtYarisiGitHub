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
        //OK
        public ActionResult GetStartedPage()
        {
            ViewBag.Message = "Get Started Page ";

            return View();
        }       
        public ActionResult StartupSelectionPage()
        {
            ViewBag.Message = "Startup Selection Page ";

            return View();
        }

        //Değişebilir controllerlar =>
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
        
    }
}