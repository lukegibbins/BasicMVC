using ChillAndGrill.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillAndGrill.Data
{
    public class ChillAndGrillDBContext: DbContext
    {
        public ChillAndGrillDBContext(DbContextOptions options)
            : base(options) //database connection info
        {
            
        }
        public DbSet<Restaurant> Restaurants { get; set; } //table in DB
    }
}
