using JuliaFoodDeliveryMarket.Models;
using JuliaFoodDeliveryMarket.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuliaFoodDeliveryMarket.Data
{
    public class SeedingService
    {
        private JuliaFoodDeliveryMarketContext _context;

        public SeedingService(JuliaFoodDeliveryMarketContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "McDonald's");
            Department d2 = new Department(2, "Pizzaria Forlen");
            Department d3 = new Department(3, "Burger King");
            Department d4 = new Department(4, "Mr. Pizza");

            Seller s1 = new Seller(1, "Jeff Pound", "jeffpound@gmail.com", new DateTime(1976, 2, 19), 1000.0, d1);
            Seller s2 = new Seller(2, "Júlia Firmino", "julia@gmail.com", new DateTime(2017, 3, 21), 3500.0, d2);
            Seller s3 = new Seller(3, "Bravinha", "bravinha@gmail.com", new DateTime(2014, 2, 19), 800.0, d3);
            Seller s4 = new Seller(4, "Edna", "edna@gmail.com", new DateTime(2010, 2, 19), 100.0, d1);
            Seller s5 = new Seller(5, "Susamara", "susamara@gmail.com", new DateTime(1980, 1, 7), 258.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 11000.0, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13), 11000.0, SalesStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 20), 11000.0, SalesStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 1), 11000.0, SalesStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 21), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 15), 11000.0, SalesStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 7), 11000.0, SalesStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8);

            _context.SaveChanges();
        }
    }
}
