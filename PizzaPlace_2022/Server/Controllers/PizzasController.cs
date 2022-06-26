﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPlace_2022.Server;
using PizzaPlace_2022.Shared;
using System.Linq;


namespace PizzaPlace_2022.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly PizzaPlaceDbContext db;
        public PizzasController(PizzaPlaceDbContext db)
        {
            this.db = db;
        }

        [HttpGet("/pizzas")]
        public IQueryable<Pizza> GetPizzas()
        => this.db.Pizzas;

        [HttpPost("/pizzas")]
        public IActionResult InsertPizza([FromBody] Pizza pizza)
        {
            db.Pizzas.Add(pizza);
            db.SaveChanges();
            return Created($"pizzas/{pizza.Id}", pizza);
        }
    }
}

