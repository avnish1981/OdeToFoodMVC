using OdeToFoodMVC.Web.Models;
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
        public ActionResult Index()
        {
            var model = new GreetingModel();
            model.proMessage = ConfigurationManager.AppSettings["disMessage"];
                      
            return View(model);
        }
    }
}