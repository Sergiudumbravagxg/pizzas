using System.Collections.Generic;
using System.Linq;

namespace Pizzas
{
    public interface IPizzaService
    {
        IEnumerable<PizzaFrequency> GetPizzas(List<Pizza> pizzas);
    }

    public class PizzaService : IPizzaService
    {
        public IEnumerable<PizzaFrequency> GetPizzas(List<Pizza> pizzas)
        {
            // query the list of objects
            var result =
                from pizza in pizzas
                let p = string.Join(", ", pizza.Toppings)
                group p by p
                into pg
                orderby pg.Count() descending
                select new PizzaFrequency(pg.Key, pg.Count());
            return result;
        }
    }
}