using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icarus.Controllers
{
    public class InquiryController : Controller
    {
        // GET: Inquiry
        public ActionResult Index()
        {
            return View();
        }

        [Route("inquiry/")]
        public ActionResult Inquiry()
        {
            return View("Index");
        }
    }
}