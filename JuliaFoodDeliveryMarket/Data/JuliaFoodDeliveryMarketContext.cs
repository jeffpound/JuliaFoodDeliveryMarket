using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuliaFoodDeliveryMarket.Models;

namespace JuliaFoodDeliveryMarket.Data
{
    public class JuliaFoodDeliveryMarketContext : DbContext
    {
        public JuliaFoodDeliveryMarketContext (DbContextOptions<JuliaFoodDeliveryMarketContext> options)
            : base(options)
        {
        }

        public DbSet<JuliaFoodDeliveryMarket.Models.Department> Department { get; set; }
    }
}
