﻿using System.Web.Mvc;

namespace AspNetBoilerplateSample.Web.Controllers
{
    public class HomeController : AspNetBoilerplateSampleControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}