using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiliconPizza.Models
{
    public class PizzaRepository: IPizzaRepository
    {
        private readonly ApplicationDbContext _db;

        public PizzaRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Pizza> AllPizzas
        {
            get
            {
                //at the top, add the "using Microsoft.EntityFrameworkCore;"
                return _db.Pizzas.Include(c => c.Category); 
            }

        }

        public IEnumerable<Pizza> PizzasOfTheWeek
        {
            get
            {
                return _db.Pizzas.Include(c => c.Category).Where(p => p.IsPizzaOfTheWeek);
            }
        }

        public Pizza GetPizzaById(int pizzaId)
        {
            return _db.Pizzas.FirstOrDefault(p => p.PizzaId == pizzaId);
        }
    }
}
