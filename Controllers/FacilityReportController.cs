using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icarus.Controllers
{
    public class FacilityReportController : Controller
    {
        // GET: FacilityReport
        public ActionResult Index()
        {
            return View();
        }

        [Route("facilityreport/")]
        public ActionResult FacilityReport()
        {
            return View("Index");
        }
    }
}