using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFoodMVC.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        public readonly IRestaurantData db = null;
        public RestaurantsController (IRestaurantData  db)
        {
            this.db = db;
        }
        // GET: Restaurants
        public ActionResult Index()
        {
            var model = db.GetAllRestaurant();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if(model  ==null)
            {
                return View("NotFound");
            }
            return View(model);

        }
    }
}