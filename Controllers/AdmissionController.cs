﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icarus.Controllers
{
    public class AdmissionController : Controller
    {
        // GET: Admission
        public ActionResult Index()
        {
            return View();
        }

        [Route("admission/")]
        public ActionResult Admission()
        {
            return View("Index");
        }

    }
}