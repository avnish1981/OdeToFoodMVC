using OdeToFood.Data.Models;
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
        [HttpGet ]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost ]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            //if(string.IsNullOrEmpty(restaurant.Name ))
            //{
            //    ModelState.AddModelError(nameof(restaurant.Name), "The Name is required");
            //}
            if (ModelState.IsValid)
            {
                db.Add(restaurant);
                //return RedirectToAction("Index");
                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View();
        }

       
        [HttpGet ]
        public ActionResult Edit(int id )
        {
            var model = db.Get(id);
            if(model==null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken ]
        public ActionResult Edit(Restaurant updatedrestaurant )
        {
            if(ModelState.IsValid )
            {
                db.Update(updatedrestaurant);
                return RedirectToAction("Details", new { id = updatedrestaurant.Id });
            }
            return View(updatedrestaurant);
        }

        
    }
}