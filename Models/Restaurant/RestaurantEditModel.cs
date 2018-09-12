using ChillAndGrill.Models;
using System.ComponentModel.DataAnnotations;

namespace ChillAndGrill.Controllers
{
    //This class is a model to represent the fields which have values been sent in a form.
    //In this example, the only data being sent in the post request is the cuisine type and 
    //restaurant name, so we need to make sure this is the only data being accepted and nothing has been missed out.
    
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}