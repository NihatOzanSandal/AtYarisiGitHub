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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WalletMenu()
        {
            return View();
        }

        public ActionResult AddMoney()
        {
            return View();
        }

        //*************************************************************



        public ActionResult AddPaymentMethod()
        {
            return View();
        }
       /*
        [HttpPost]
        public ActionResult AddPaymentMethod(PaymentMethod model)
        {
            

            //if e girmemeli, ne yapmalıyım
            if (model != null)
            //if (model.Month!= 0 )
            {
                //model.MemberId = loginOlan.id
                db.PaymentMethod.Add(model);
                db.SaveChanges();
                Response.Write("<script lang='JavaScript'>alert('Kart Ekleme Başarılı, Kazanmaya Bir Adım Daha Yaklaştınız');</script>");
                return View("WalletMenu");
            }
            else
            {               
                Response.Write("<script lang='JavaScript'>alert('Lütfen Girdiğiniz Bilgileri Kontrol Edip Tekrar Deneyin');</script>");
                return View();
            }
        }
        */

        //*************************************************************
        public ActionResult WithdrawYourMoney()
        {
            return View();
        }
        public ActionResult DeleteChangePaymentMethod()
        {
            return View();
        }



    }
}