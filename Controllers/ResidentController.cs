using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icarus.Controllers
{
    public class ResidentController : Controller
    {
        // GET: Resident
        public ActionResult Index()
        {
            return View();
        }

        [Route("resident/")]
        public ActionResult Resident()
        {
            return View("Index");
        }
    }
}