
using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFoodMVC.Web.Controllers
{
    public class HomeController : Controller
    {         
       private readonly IRestaurantData db;
        //public HomeController ()
        //{
        //    db = new clsInMemoryData();
        //}
        public HomeController(IRestaurantData db)
        {
            this.db = db;

        }
        public ActionResult  Index()
        {
            var model = db.GetAllRestaurant();
            return View(model);
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
}