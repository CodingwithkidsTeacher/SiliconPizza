using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiliconPizza.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Meat Pizza" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Veggie Pizza" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Vegetarian Pizza" });

            //seed pies

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 1,
                Name = "Pepperoni Pizza",
                Price = 8.95M,
                ShortDescription = "Our famous pepperoni pizza!",
                LongDescription = "Large pepperoni pizza with american cheese which comes with a side sauce and a small soft drink",
                CategoryId = 1,
                ImageUrl = "https://i.ibb.co/VHwKty8/pepperoni.png",
                InStock = true,
                IsPizzaOfTheWeek = true,
                ImageThumbnailUrl = "https://i.ibb.co/VHwKty8/pepperoni.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 2,
                Name = "Veggie Pizza",
                Price = 7.99M,
                ShortDescription = "Our famous Veggie pizza!",
                LongDescription = "Large veggies pizza with american cheese which comes with a side sauce and a small soft drink",
                CategoryId = 1,
                ImageUrl = "https://i.ibb.co/pfPZR6Y/veggies.jpg",
                InStock = true,
                IsPizzaOfTheWeek = true,
                ImageThumbnailUrl = "https://i.ibb.co/pfPZR6Y/veggies.jpg",
                AllergyInformation = ""
            });
        }
    }
}
