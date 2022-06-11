using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using At_Yarisi.Models.siniflar;

namespace At_Yarisi.Controllers
{
    public class SettingsController : Controller
    {
        private CONTEXT db = new CONTEXT();
        // GET: Settings
        public ActionResult ChangeName()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangeName(string isim, int UserId)
        {
            var bilgiler = db.Members.FirstOrDefault(x => x.ID == UserId );

            if (bilgiler != null)
            {

                bilgiler.UserName = isim;

                db.SaveChanges();

                Session.Remove("UserName");
                Session["UserName"] = isim;
                Response.Write("<script lang='JavaScript'>alert('Kullanıcı Adı Başarı İle Değiştirildi');</script>");
                return View("/Views/GirisYap/SetMain.cshtml");
                return RedirectToAction("SetMain", "GirisYap");
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Member Id Çekme Başarısız Lütfen tekrar Login Olunuz');</script>");
                return View();
            }
        }

        public ActionResult ChangeEmail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangeEmail(string email, int UserId)
        {
            var bilgiler = db.Members.FirstOrDefault(x => x.ID == UserId);

            if (bilgiler != null)
            {

                bilgiler.Email = email;

                db.SaveChanges();

                Response.Write("<script lang='JavaScript'>alert('Kullanıcı Emaili Başarı İle Değiştirildi');</script>");
                return View("/Views/GirisYap/SetMain.cshtml");
                return RedirectToAction("SetMain", "GirisYap");
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Member Id Çekme Başarısız Lütfen tekrar Login Olunuz');</script>");
                return View();
            }
        }
        public ActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangePassword(string sifre, int UserId)
        {
            var bilgiler = db.Members.FirstOrDefault(x => x.ID == UserId);

            if (bilgiler != null)
            {

                bilgiler.Password = sifre;

                db.SaveChanges();
                Response.Write("<script lang='JavaScript'>alert('Kullanıcı Şifresi Başarı İle Değiştirildi');</script>");
                return View("/Views/GirisYap/SetMain.cshtml");
                return RedirectToAction("SetMain", "GirisYap");
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Member Id Çekme Başarısız Lütfen tekrar Login Olunuz');</script>");
                return View();
            }
        }
    }
}