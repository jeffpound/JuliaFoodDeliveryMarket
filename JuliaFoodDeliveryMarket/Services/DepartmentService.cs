using JuliaFoodDeliveryMarket.Data;
using JuliaFoodDeliveryMarket.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        
    }
}
