using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace At_Yarisi.Controllers
{
    public class WalletController : Controller
    {
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
        [HttpPost]
        public ActionResult AddPaymentMethod(FormCollection form)
        {
            return View();
        }



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