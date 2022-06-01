using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using At_Yarisi.Models.siniflar;

namespace At_Yarisi.Controllers
{
    public class WalletController : Controller
    {
        private CONTEXT db;

        public WalletController()
        {
            db = new CONTEXT();
        }
        // GET: Wallet        
        public ActionResult WalletMenu()
        {
            return View();
        }
        public ActionResult AddMoney()
        {
            return View();
        }
        public ActionResult AddPaymentMethod()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPaymentMethod(PaymentMethod model)
        {
            //KART EKLENİNCE SESSİON EKLENMELİ
            bool TekKartKontrol = Session["TL"] == null;

            if (TekKartKontrol == true)
            {
                if (model != null)
                {
                    //model.MemberId = loginOlan.id
                    if (model.CardNumber.Length == 16)
                    {
                        Session["TL"] = model.Money;
                        Session["Chip"] = model.Chip;
                        Session["KartAdi"] = model.UserName;
                        db.PaymentMethod.Add(model);
                        db.SaveChanges();
                        Response.Write("<script lang='JavaScript'>alert('Kart Ekleme Başarılı, Kazanmaya Bir Adım Daha Yaklaştınız');</script>");
                        return View("WalletMenu");
                    }
                    else
                    {
                        Response.Write("<script lang='JavaScript'>alert('Kart Numarası 16 hane olmalıdır');</script>");
                        return View();
                    }
                }
                else
                {
                    Response.Write("<script lang='JavaScript'>alert('Lütfen Girdiğiniz Bilgileri Kontrol Edip Tekrar Deneyin');</script>");
                    return View();
                }

            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Mevcut Kart Bulunmaktadır, Kart Ekleme Başarısız Kart Eklemek İçin Eski Kartınızı Siliniz');</script>");
                return View("WalletMenu");
            }



        }
        //KULLANILMAYAN
        public ActionResult DeleteChangePaymentMethod()
        {
            //db.PaymentMethod.Remove();
            return View();
        }
        public ActionResult WithdrawYourMoney()
        {
            return View();
        }
        public ActionResult DeletePaymentMethod(int id)
        {

            var bilgi = db.PaymentMethod.FirstOrDefault(x => x.MemberId == id);
            if (bilgi != null)
            {
                Session.Remove("TL");
                Session.Remove("Chip");
                Session.Remove("KartAdi");
                db.PaymentMethod.Remove(bilgi);
                db.SaveChanges();
                Response.Write("<script lang='JavaScript'>alert('Kartınız Başarı İle Silinmiştir Yeni Kartınızı Ekleyebilirsiniz');</script>");
                //return RedirectToAction("AddPaymentMethod");

                return View("AddPaymentMethod");
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Mevcut Kart Olmadığından Kartınız Silinemedi Lütfen Önce Kart Ekleyiniz');</script>");
                //return RedirectToAction("WalletMenu");
                return View("WalletMenu");
            }


        }

    }
}

/*
          var KartSorgu = db.PaymentMethod.FirstOrDefault(x => x.ID == model.MemberId);
          if (KartSorgu != null)
          {
              Session["TL"] = KartSorgu.Money;
              Session["Chip"] = KartSorgu.Chip;
              return RedirectToAction("SetMain", "GirisYap");
          }
          else
          {
              return RedirectToAction("SetMain", "GirisYap");
          }
          */
/*
            var b = db.PaymentMethod.Find(id);
            if (id != 0)
            {
                db.PaymentMethod.Remove(b);
                db.SaveChanges();
                Response.Write("<script lang='JavaScript'>alert('Kartınız Başarı İle Silinmiştir Yeni Kartınızı Ekleyebilirsiniz');</script>");
                //return RedirectToAction("AddPaymentMethod");
                return View("AddPaymentMethod");
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Mevcut Kart Olmadığından Kartınız Silinemedi Lütfen Önce Kart Ekleyiniz');</script>");
                //return RedirectToAction("WalletMenu");
                return View("WalletMenu");
            }
            */