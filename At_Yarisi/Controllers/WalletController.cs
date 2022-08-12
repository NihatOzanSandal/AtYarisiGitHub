using System.Linq;
using System.Web.Mvc;
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
        public ActionResult AddPaymentMethod(int id)
        {
            var KartVarmiKontrol = db.PaymentMethod.FirstOrDefault(x => x.MemberId == id);
            if (KartVarmiKontrol == null)
            {
                return View();
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Mevcut Kart Bulunmaktadır, Kart Eklemek İçin Fütfen Eski Kartınızı Siliniz');</script>");
                return View("WalletMenu");
                return RedirectToAction("WalletMenu", "Wallet");
            }
            
        }
        [HttpPost]
        public ActionResult AddPaymentMethod(PaymentMethod model)
        {
            bool TekKartKontrol = Session["TL"] == null;

            if (TekKartKontrol == true)
            {
                if (model != null)
                {
                    //model.MemberId = loginOlan.id
                    if (model.UserName != null && model.CardNumber != null && model.SecurityCode != 0 && model.Month != 0 && model.Year != 0)
                    {
                        if (model.CardNumber.Length == 16)
                        {
                            if (model.MemberId == 0)
                            {
                                Response.Write("<script lang='JavaScript'>alert(' ! Kullanıcı Id Çekme Hatası ! Lütfen Tekrardan Login Olun ');</script>");
                                return View("/Views/GirisYap/Login.cshtml");
                            }
                            else
                            {
                                Session["TL"] = model.Money;
                                Session["Chip"] = model.Chip;
                                Session["KartAdi"] = model.UserName;

                                db.PaymentMethod.Add(model);
                                db.SaveChanges();
                                var cardIdCek = db.PaymentMethod.FirstOrDefault(x => x.MemberId == model.MemberId);
                                Session["CardId"] = cardIdCek.ID;

                                Response.Write("<script lang='JavaScript'>alert('Kart Ekleme Başarılı, Kazanmaya Bir Adım Daha Yaklaştınız');</script>");
                                return View("/Views/GirisYap/SetMain.cshtml");
                                return RedirectToAction("SetMain", "GirisYap");
                            }
                        }
                        else
                        {
                            Response.Write("<script lang='JavaScript'>alert('Kart Numarası 16 hane olmalıdır');</script>");
                            return View();
                        }
                    }
                    else
                    {
                        Response.Write("<script lang='JavaScript'>alert('Hiçbir Bilgi Boş Geçilemez Lütfen Hepsini Doldurun');</script>");
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
                return RedirectToAction("WalletMenu", "Wallet");
            }


        }
        //KULLANILMAYAN
        public ActionResult DeleteChangePaymentMethod()
        {
            //db.PaymentMethod.Remove();
            return View();
        }
        /*------------*/
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
                return RedirectToAction("AddPaymentMethod", "Wallet");

            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Mevcut Kart Olmadığından Kartınız Silinemedi Lütfen Önce Kart Ekleyiniz');</script>");
                //return RedirectToAction("WalletMenu");
                return View("WalletMenu");
                return RedirectToAction("AddPaymentMethod", "Wallet");

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