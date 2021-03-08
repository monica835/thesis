using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icarus.Controllers
{
    public class ResidentActivityController : Controller
    {
        // GET: ResidentActivity
        public ActionResult Index()
        {
            return View();
        }

        [Route("residentactivity/")]
        public ActionResult ResidentActivity()
        {
            return View("Index");
        }
    }
}