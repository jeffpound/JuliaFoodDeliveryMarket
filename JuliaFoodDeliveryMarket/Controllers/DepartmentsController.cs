using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuliaFoodDeliveryMarket.Models;
using Microsoft.AspNetCore.Mvc;

namespace JuliaFoodDeliveryMarket.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "Pizza Hut" });
            list.Add(new Departament { Id = 2, Name = "Domino's Pizza" });
            list.Add(new Departament { Id = 2, Name = "Hamburgueria Le Pinguê" });

            return View(list);
        }
    }
}
