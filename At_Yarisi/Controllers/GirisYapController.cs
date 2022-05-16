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
        public ActionResult Login(Members model)
        {
            var bilgiler = c.Members.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                Session["Email"] = bilgiler.Email.ToString();               
                return RedirectToAction("SetMain", "GirisYap");
                //!!ANA EKRANA KULLANICI ID DÖNMELİ
                //Paymet Method tablosu 12 char olmalı 
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Kullanıcı Girişi Başarısız Lütfen Tekrar Deneyin');</script>");
                return View();
            }
        }
        public ActionResult SetMain()
        {            
            return View();
        }
    }
}


/***************************************************/
/*
        var bilgiler = c.Members.FirstOrDefault(x => x.Email == ad.Email && x.Password == ad.Password);
        if (bilgiler != null)
        {
            //YANLIŞSA KONTROLÜ EKLENMELİ

            FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
            Session["Email"] = bilgiler.Email.ToString();

            Members uye = new Members();
            uye.Email = Email;


            //return RedirectToAction("SetMain","GirisYap");

            return View(uye);
            return View("MainMenuPage");



        }
        else
        {
            Response.Write("<script lang='JavaScript'>alert('Kullanıcı Girişi Başarısız Lütfen Tekrar Deneyin');</script>");
            return View("Login");
        }*/