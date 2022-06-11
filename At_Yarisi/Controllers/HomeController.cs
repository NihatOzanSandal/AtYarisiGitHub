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
        private CONTEXT db;

        public HomeController()
        {
            db = new CONTEXT();
        }
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
        public ActionResult CreateAccountPage()
        {
            ViewBag.Message = "Create Account Page ";

            return View();
        }
        [HttpPost]
        public ActionResult CreateAccountPage(Members model)
        {

            ViewBag.Message = "Create Account Page ";
            try
            {
                db.Members.Add(model);
                db.SaveChanges();

                Response.Write("<script lang='JavaScript'>alert('Hesap Oluşturma Başarılı Kazanmaya Bir Adım Daha Yaklaştınız :) ');</script>");
                //LOGİN SAYFASINA DÖNMELİ Return View
                return View("/Views/GirisYap/Login.cshtml");
                return RedirectToAction("Login", "GirisYap");
            }
            catch (Exception)
            {
                Response.Write("<script lang='JavaScript'>alert('Bir Hata Oluştu Birth Day Verisini Lütfen Yıl - Ay - Gün şeklinde girin !Aralara '-' veya Boşluk( ) Koyun, Örnek: 2001-12-21');</script>");
                return View();
                throw;
            }


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
        [HttpPost]
        public ActionResult ForgetPasswordPage(Members model)
        {
            //string Soru ="";
            var bilgi = db.Members.FirstOrDefault(x => x.UserName == model.UserName && x.Email == model.Email);

            if (bilgi != null)
            {
                Session["UserId"] = bilgi.ID;
                Session["SecurityQuestion"] = bilgi.SecurityQuestion;
                return RedirectToAction("QuestionPage", "Home");
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Bir Hata Oluştu Lütfen User Name ve Email Bilgilerinizi Kontrol Edip Tekrar Deneyiniz.');</script>");
                return View();
            }
        }
        public ActionResult QuestionPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult QuestionPage(string Answer, int UserId)
        {
            var bilgi = db.Members.FirstOrDefault(x => x.Answer == Answer && x.ID == UserId);

            if (bilgi != null)
            {
                Session.Remove("SecurityQuestion");
                return RedirectToAction("ForgetPassword2Page", "Home");
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Bir Hata Oluştu Lütfen User Name ve Email Bilgilerinizi Kontrol Edip Tekrar Deneyiniz.');</script>");
                return View();
            }
        }

        public ActionResult ForgetPassword2Page()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgetPassword2Page(int UserId, string NewPassword, string NewPasswordAgain)
        {
            var bilgi = db.Members.FirstOrDefault(x => x.ID == UserId);
            bool ayniKontrol = NewPassword == NewPasswordAgain;
            if (bilgi != null && ayniKontrol == true)
            {
                Session.Remove("UserId");
                bilgi.Password = NewPassword;
                db.SaveChanges();
                Response.Write("<script lang='JavaScript'>alert('Şifre Değiştirme Başarılı Yeni Şifreniz İle Login Olmayı Deneyebilrisiniz.');</script>");
                return View("/Views/GirisYap/Login.cshtml");
                return RedirectToAction("Login", "GirisYap");
            }
            else if (ayniKontrol == false)
            {
                Response.Write("<script lang='JavaScript'>alert('Şifre Değiştirme Başarısız, Girdiğiniz Şifreler Uyuşmamaktadır Lütfen Şifrenizi Aynı Girerek Tekrar Deneyin');</script>");
                return View();
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Id Çekmede Bir sorun Yaşandı Tekrardan şifre Sıfırlamayı Deneyin');</script>");
                return View("/Views/Home/ForgetPasswordPage.cshtml");
                return RedirectToAction("ForgetPasswordPage", "Home");
            }
        }

        //YAPIM AŞAMASINDA MAİL
        public ActionResult SendMailPage()
        {
            ViewBag.Message = "Create Account Second Page ";

            return View();
        }
        public ActionResult ContactPage()
        {
            ViewBag.Message = "Contact Page ";

            return View();
        }
        public ActionResult SettingsPage()
        {
            ViewBag.Message = "Settings Page ";

            return View();
        }
        public ActionResult TamamlanmamisEkran()
        {
            ViewBag.Message = "Contact Page ";

            return View();
        }
    }
}