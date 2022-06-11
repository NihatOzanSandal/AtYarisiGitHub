using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using At_Yarisi.Models.siniflar;

namespace At_Yarisi.Controllers
{
    public class RaceController : Controller
    {
        private CONTEXT db = new CONTEXT();
        // GET: Race
        public ActionResult Index()
        {//Empty
            return View();
        }
        public ActionResult PastRacesPage(int id)
        {
            var bilgi = db.Bets.Where(x => x.MemberId == id);
            var Varmı = db.Bets.FirstOrDefault(x => x.MemberId == id);

            if (Varmı != null)
            {
                return View(bilgi.ToList());
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Geçmiş Yarışınız Bulunmamaktadır.');</script>");
                return View("/Views/GirisYap/SetMain.cshtml");
                return RedirectToAction("SetMain", "GirisYap");
            }
        }
        public ActionResult Race()
        {
 

            return View();
        }
        [HttpPost]
        public ActionResult Race(Bets model)
        {
            //      VERİLER DOĞRU BİR ŞEKİLDE ÇEKİLDİKTEN SONRA BETS VE WALLET TABLOSUNA YANSITILMALI

            var bilgiler = db.Members.FirstOrDefault(x => x.ID == model.MemberId);
            var CardUser = db.PaymentMethod.FirstOrDefault(x => x.MemberId == model.MemberId);
            if (model.MemberId == 0)
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Sisteme Login Olun Ve Tekrar Deneyin ');</script>");
                return View();
            }
            else if (model.CardId == 0)
            {
                Response.Write("<script lang='JavaScript'>alert('Kart Bilgilerinizi Kontrol Edin ve Tekrar Deneyin ');</script>");
                return View();
            }
            else
            {

                if (CardUser.Chip < model.AmountOfBet || model.AmountOfBet < 0)
                {
                    Response.Write("<script lang='JavaScript'>alert('Please Check Your Amount');</script>");
                    return View();
                }
                else
                {
                    if (bilgiler != null)
                    {

                        CardUser.Chip = model.TotalAmount;
                        Session.Remove("Chip");
                        Session["Chip"] = model.TotalAmount;


                        model.RaceId = db.Bets.Max(q => q.RaceId) + 1;

                        db.Bets.Add(model);

                        db.SaveChanges();
                        //db.Horse.Add(model);
                        //db.SaveChanges();

                        return View();
                    }
                    else
                    {
                        Response.Write("<script lang='JavaScript'>alert('Member Id Almada Sorun Yaşandı Tekrar Login Olunuz ');</script>");
                        return View();
                    }
                }
            }

        }

        /*Kullanılmayanlar -> */
        public ActionResult RaceParaEkleme()
        {

            return View();
        }
        public ActionResult HorseRaceJs()
        {
            return View();

        }
        public ActionResult HorseRace()
        {
            return View();

        }

    }
}