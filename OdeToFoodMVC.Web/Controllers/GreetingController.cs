﻿using OdeToFoodMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFoodMVC.Web.Controllers
{
    public class GreetingController : Controller
    {
        
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            model.proMessage = ConfigurationManager.AppSettings["disMessage"];
            model.Name = name ?? "NO name";       
            return View(model);
        }
    }
}