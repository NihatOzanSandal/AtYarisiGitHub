using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            return View();
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
    }
}