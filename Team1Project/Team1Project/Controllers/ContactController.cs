using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Team1Project.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Doctor()
        {
            return View();
        }
        public ActionResult Manager()
        {
            return View();
        }
        public ActionResult Rmanager()
        {
            return View();
        }
    }
}