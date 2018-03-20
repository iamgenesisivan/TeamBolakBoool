﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchulerPrototype.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/superadmin/Index.cshtml");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
     public class taskController : Controller
        { 
        public ActionResult student()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult teacher()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}