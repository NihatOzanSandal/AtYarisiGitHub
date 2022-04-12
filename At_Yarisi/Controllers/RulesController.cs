using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using At_Yarisi.Models.siniflar;

namespace At_Yarisi.Controllers
{
    public class RulesController : Controller
    {
        private CONTEXT db = new CONTEXT();
        // GET: Rules
        public ActionResult RulesIndex()
        {
            return View(db.Rules.ToList());
        }
    }
}