using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChillAndGrill.Data;
using ChillAndGrill.Models;

namespace ChillAndGrill.Services
{
    public class SQLRestaurantData : IRestaurantData
    {
        private ChillAndGrillDBContext _context;

        public SQLRestaurantData(ChillAndGrillDBContext context)
        {
            _context = context; //Gets a reference to the DB Class to use methods to add/edit/create objects and store in DB
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant); //Doesn't contact DB directly. Adds to a list of restaurants
            _context.SaveChanges();   //Insert into DB occurs using this method 'SaveChange()'
            return restaurant;
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return _context.Restaurants.OrderBy(r => r.Name); //Use IQueryable datatype if using hundreds restaurants
        }

        public Restaurant GetSpecificRestaurant(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }
    }
}
