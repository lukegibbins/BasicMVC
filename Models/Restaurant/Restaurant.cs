using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ChillAndGrill.Models
{
    //This is now simply the entity which resembles the restaurant object in the database.
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name = "Restaurant Name")]
        [Required, MaxLength(80)]
        public string Name { get; set; }

        [Display(Name= "Cuisine Type")]
        public CuisineType Cuisine { get; set; }
    }
}
