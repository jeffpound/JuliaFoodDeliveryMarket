using JuliaFoodDeliveryMarket.Data;
using JuliaFoodDeliveryMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuliaFoodDeliveryMarket.Services
{
    public class SellerService
    {
        private readonly JuliaFoodDeliveryMarketContext _context;

        public SellerService(JuliaFoodDeliveryMarketContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);

            _context.SaveChanges();
        }
    }
}
