﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ColorChooser()
        {
            return View();
        }

        public ActionResult MileToMetric()
        {
            return View();
        }
    }
}