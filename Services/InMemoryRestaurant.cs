using ChillAndGrill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace ChillAndGrill.Services
//{
//    public class InMemoryRestaurant : IRestaurantData
//    {
//        public InMemoryRestaurant()
//        {
//            _restaurants = new List<Restaurant>
//            {
//                new Restaurant{Id = 1, Name = "KFC"},
//                new Restaurant{Id = 2, Name = "Pizza Hut"},
//                new Restaurant{Id = 3, Name = "POC"}
//            };
//        }

//        public IEnumerable<Restaurant> GetAllRestaurants()
//        {
//            return _restaurants.OrderBy(n => n.Name);
//        }

//        public Restaurant GetSpecificRestaurant(int id)
//        {
//            return _restaurants.FirstOrDefault(r => r.Id == id);
//        }

//        public Restaurant Add(Restaurant restaurant)
//        {
//            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
//            _restaurants.Add(restaurant); //Add to a list of in-memory restaurants
//            return restaurant;
//        }

//        List<Restaurant> _restaurants;
//    }
//}
