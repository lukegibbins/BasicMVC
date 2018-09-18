using ChillAndGrill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillAndGrill.Services
{
    public interface IRestaurantData
    {
        //This method will be used to get restaurant data. The method can be overrided by a inherited class to provide
        //#1. In-memory data
        //#2. Data from a DB
        IEnumerable<Restaurant> GetAllRestaurants();
        Restaurant GetSpecificRestaurant(int id);  //return type goes first in interfaces.
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant restaurant);
    }
}
