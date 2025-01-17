﻿using System;
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

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
    }
}
