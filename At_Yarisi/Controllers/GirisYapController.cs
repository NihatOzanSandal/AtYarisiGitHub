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
        public ActionResult Login(Members model, PaymentMethod Para)
        {
            var bilgiler = c.Members.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
            
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                //Session["Email"] = bilgiler.Email.ToString();  
                Session["UserId"] = bilgiler.ID;
                Session["UserName"] = bilgiler.UserName;
                var paraBilgisi = c.PaymentMethod.FirstOrDefault(x => x.MemberId == bilgiler.ID);
                if (paraBilgisi != null)
                {
                    Session["CardId"] = paraBilgisi.ID;
                    Session["TL"] = paraBilgisi.Money;
                    Session["Chip"] = paraBilgisi.Chip;
                    Session["KartAdi"] = paraBilgisi.UserName;
                    return RedirectToAction("SetMain", "GirisYap");
                }
                else
                {
                    return RedirectToAction("SetMain", "GirisYap");
                }
                //c.Members.Remove();

                //session id atıp tutulur ,cookie de tutulur local storage temp de 

            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Kullanıcı Girişi Başarısız Kullanıcı E-mail inizi ve Şifrenizi Kontrol Edip Lütfen Tekrar Deneyin');</script>");
                return View();
            }
        }
        public ActionResult RiskFreeLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RiskFreeLogin(Members model, PaymentMethod Para)
        {
            var bilgiler = c.Members.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);

            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                //Session["Email"] = bilgiler.Email.ToString();  
                Session["UserId"] = bilgiler.ID;
                Session["UserName"] = bilgiler.UserName;
                var paraBilgisi = c.PaymentMethod.FirstOrDefault(x => x.MemberId == bilgiler.ID);
                if (paraBilgisi != null)
                {
                    Session["CardId"] = paraBilgisi.ID;
                    Session["TL"] = paraBilgisi.Money;
                    Session["Chip"] = paraBilgisi.Chip;
                    Session["KartAdi"] = paraBilgisi.UserName;
                    return RedirectToAction("SetMain", "GirisYap");
                }
                else
                {
                    return RedirectToAction("SetMain", "GirisYap");
                }
                //c.Members.Remove();

                //session id atıp tutulur ,cookie de tutulur local storage temp de 

            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Kullanıcı Girişi Başarısız Kullanıcı E-mail inizi ve Şifrenizi Kontrol Edip Lütfen Tekrar Deneyin');</script>");
                return View();
            }
        }
        public ActionResult SetMain(PaymentMethod Para)
        {
            var paraBilgisi = c.PaymentMethod.FirstOrDefault(x => x.ID == Para.ID);
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