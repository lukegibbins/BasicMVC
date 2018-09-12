using ChillAndGrill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillAndGrill.ViewModels
{
    //A VIEW MODEL encapsulates everything the view needs.
    //A standard MODEL represents the entity which corresponds with the database item.
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}
