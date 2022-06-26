using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Pizzas = new List<Pizza> {
                    //new Pizza(1, "Quần Jean", 8.99M, Spiciness.Spicy),
                    //new Pizza(2, "Áo Oversize", 7.99M, Spiciness.None),
                    //new Pizza(3, "Áo Blazer", 8.55M, Spiciness.Hot)

                    new Pizza(4, "Áo sơ mi", 50 , Spiciness.Ao1),
                    new Pizza(5, "Áo Polo", 60 , Spiciness.Ao2),
                    new Pizza(6, "Áo Thun", 65 , Spiciness.Ao3),
                    new Pizza(7, "Áo Blazer", 40 , Spiciness.Ao4),
                    new Pizza(8, "Áo Oversize", 70 , Spiciness.Ao5),
                    new Pizza(9, "Áo khoác", 80 , Spiciness.Ao6),
                }
             });
    }
}

