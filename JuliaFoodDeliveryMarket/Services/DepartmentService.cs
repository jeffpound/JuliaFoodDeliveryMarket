using JuliaFoodDeliveryMarket.Data;
using JuliaFoodDeliveryMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuliaFoodDeliveryMarket.Services
{
    public class DepartmentService
    {
        private readonly JuliaFoodDeliveryMarketContext _context;

        public DepartmentService(JuliaFoodDeliveryMarketContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

        
    }
}
