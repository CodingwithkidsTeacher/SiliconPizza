using Microsoft.AspNetCore.Mvc;
using SiliconPizza.Models;
using SiliconPizza.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiliconPizza.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PizzaController(IPizzaRepository pizzaRepository, ICategoryRepository categoryRepository)
        {
            _pizzaRepository = pizzaRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            PizzasListViewModel pizzasListViewModel = new PizzasListViewModel();
            pizzasListViewModel.Pizzas = _pizzaRepository.AllPizzas;
            pizzasListViewModel.CurrentCategory = "Meat Pizza";

            return View(pizzasListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pizza = _pizzaRepository.GetPizzaById(id);
            if (pizza == null)
                return NotFound();

            return View(pizza);
        }
    }
}
