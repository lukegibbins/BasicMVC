using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChillAndGrill.Pages
{
    public class GreeterModel : PageModel
    {
        private IGreeter _greeter;
        public string CurrentGreeting { get; set; }

        public GreeterModel(IGreeter greeter)
        {
            _greeter = greeter;
            //Could've had restaurant data in bere
        }

        public void OnGet(string name)
        {
            CurrentGreeting = $"{name}: {_greeter.GetMessageOfTheDay()}"; //String interpolation
            //Coudl've return restaurant data on a GET --> an alternative to MVC
        }

        //public void OnPost()...would be here
    }
}