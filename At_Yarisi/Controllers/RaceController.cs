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
        public ActionResult Race()
        {
            
                var bilgi = db.Horse.Where(x => x.HorseName != "BoşIsim");
                return View(bilgi.ToList());
                    
        }
        [HttpPost]
        public ActionResult Race(Horse model)
        {
           
            var bilgiler = db.Horse.FirstOrDefault(x => x.HorseName == model.HorseName);
            

            if (bilgiler != null)
            {
                Session["HorseName"] = bilgiler.HorseName;
                Session["HorseRatio"] = bilgiler.HorseRatio;
                Session["HorseNumber"] = bilgiler.HorseNumber;
                //db.Horse.Add(model);
                //db.SaveChanges();
                return View();
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Lütfen Girdiğiniz Bilgileri Kontrol Edip Tekrar Deneyin');</script>");
                return View();
            }
        }
        public ActionResult PastRacesPage(int id)
        {
            //SORU BİR BU KOŞULA UYAN BÜTÜN SORGULARI NASIL ÇEKERİM

            var bilgi = db.Bets.Where(x => x.MemberId == id);
            //var bilgi = db.Bets.Find(x => x.MemberId == id);
            if (bilgi != null)
            {
                //Session["AmountOfBet"] = bilgi.AmountOfBet;
                //Session["HorseId"] = bilgi.HorseId;
                //Session["EarningAmount"] = bilgi.EarningAmount;

                //SORU 2 BURDA BETS YERİNE BİLGİ Mİ KULLANILMALI
                return View(bilgi.ToList());
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Geçmiş Yarışınız Bulunmamakta');</script>");
                return View("SetMain");
            }
        }
        public ActionResult HorseRace()
        {    
            return View();

        }
    }
}