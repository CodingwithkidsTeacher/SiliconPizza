using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiliconPizza.Models;
using SiliconPizza.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SiliconPizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;

        public HomeController(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PizzasOfTheWeek = _pizzaRepository.PizzasOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
