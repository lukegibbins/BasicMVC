using ChillAndGrill.Models;
using ChillAndGrill.Services;
using ChillAndGrill.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillAndGrill.Controllers
{
   
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData; //reference to the requested list of restaurant data from startup/ConfigureServices
        private IGreeter _greeter;               // ""

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData; //Initalises the above data
            _greeter = greeter;
        }

        //Action method - Always use IAction result as the return type of an action/method in a controller.
        public IActionResult Index() 
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantData.GetAllRestaurants();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();

            return View(model);
        }

        public IActionResult Details(int Id)
        {
            var model = _restaurantData.GetSpecificRestaurant(Id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index)); //returns the index page if no results are found.
                //N.B - A error page could also be presented here...
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditModel editModel)
        {
            if (ModelState.IsValid)
            {
                var newRestaurant = new Restaurant();
                newRestaurant.Name = editModel.Name;
                newRestaurant.Cuisine = editModel.Cuisine;

                newRestaurant = _restaurantData.Add(newRestaurant);

                return RedirectToAction(nameof(Details), new { id = newRestaurant.Id });
            }
            else
            {
                return View();
            }
        }
    }
}
