using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillAndGrill.ViewComponents
{
    public class GreeterViewComponent : ViewComponent
    {
        //This class is solely used for the greeter message from the service. An alternative to creating a 'ViewModel'  
        //Remember when referencing a service or interface it HAS to be initialised in the ctor
        private IGreeter _greeter;

        public GreeterViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetMessageOfTheDay();
            return View("Default", model); //Only requires the default if the model is of type:String
        }
    }
}
