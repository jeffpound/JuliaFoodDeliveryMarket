﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuliaFoodDeliveryMarket.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Item { get; set; }
    }
}
