﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icarus.Controllers
{
    public class VendorsController : Controller
    {
        // GET: Vendors
        public ActionResult Index()
        {
            return View();
        }

        [Route("vendors/")]
        public ActionResult Vendors()
        {
            return View("Index");
        }
    }
}