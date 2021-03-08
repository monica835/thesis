using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icarus.Controllers
{
    public class AssertionController : Controller
    {
        // GET: Assertion
        public ActionResult Index()
        {
            return View();
        }

        [Route("assertion/")]
        public ActionResult Assertion()
        {
            return View("Index");
        }
    }
}