using System.Collections.Generic;
using OdeToFood.Data.Models;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class clsInMemoryData : IRestaurantData
    {
        List<Restaurant> objRes = null;
        public clsInMemoryData()
        {
            objRes = new List<Restaurant>
            {
               new Restaurant {  Id = 1, Name = "Avnish Restaurant", Location = "London", Cuisine = CuisineType.Indian },
               new Restaurant { Id = 2, Name = "Arti Restaurant", Location = "Delhi", Cuisine = CuisineType.Mexican },
               new Restaurant { Id = 3, Name = "Twinkle Restaurant", Location = "Ranchi", Cuisine = CuisineType.Indian },
               new Restaurant { Id = 4, Name = "Vedaant Restaurant", Location = "Ranchi", Cuisine = CuisineType.Mexican  }

             };
        }

        public Restaurant Get(int id)
        {
            return objRes.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable <Restaurant> GetAllRestaurant()
        {
            return objRes.OrderBy(r => r.Id );
        }
    }
}
