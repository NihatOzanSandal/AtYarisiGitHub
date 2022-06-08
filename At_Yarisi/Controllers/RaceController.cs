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
            if (bilgi != null)
            {
                //Session["AmountOfBet"] = bilgi.AmountOfBet;
                //Session["HorseId"] = bilgi.HorseId;
                //Session["EarningAmount"] = bilgi.EarningAmount;

                return View(bilgi.ToList());
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Geçmiş Yarışınız Bulunmamakta');</script>");
                return View("SetMain");
            }
        }
        public ActionResult Race()
        {
            Session["MevcutYarisId"] = db.Bets.Max(q => q.ID);
            Convert.ToInt16(Session["MevcutYarisId"]);

            var bilgi = db.Horse.Where(x => x.HorseName != "BoşIsim");
            return View(bilgi.ToList());

        }
        [HttpPost]
        public ActionResult Race(Bets model)
        {
            //      VERİLER DOĞRU BİR ŞEKİLDE ÇEKİLDİKTEN SONRA BETS VE WALLET TABLOSUNA YANSITILMALI

            var bilgiler = db.Members.FirstOrDefault(x => x.ID == model.MemberId);
            var CardUser = db.PaymentMethod.FirstOrDefault(x => x.MemberId == model.MemberId);
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

                    model.RaceId += 1;
                    db.Bets.Add(model);
                    db.SaveChanges();

                    Session.Remove("Chip");
                    Session["Chip"] = model.TotalAmount;
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

        public ActionResult RaceParaEkleme()
        {

            return View();
        }







        /*Kullanılmayanlar -> */
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