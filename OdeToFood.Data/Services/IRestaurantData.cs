using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.Services
{
    public  interface IRestaurantData
    {
        IEnumerable <Restaurant> GetAllRestaurant();
        Restaurant Get(int id);
        void Add(Restaurant restaurant);
        void  Update(Restaurant restaurant );
        
    }
}
