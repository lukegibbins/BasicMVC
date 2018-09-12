using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillAndGrill.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Contact()
        {
            return Content("0191 5225491");
        }

        public IActionResult CountryCode()
        {
            return Content("UK");
        }
    }
}
