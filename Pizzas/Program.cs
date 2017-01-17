using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Pizzas
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the file
            var sr = new StreamReader(@"c:\dev\pizzas.json");
            var pizzasContent = sr.ReadToEnd();

            // convert to objects
            var pizzas = JsonConvert.DeserializeObject<List<Pizza>>(pizzasContent);

            IPizzaService pizzaService = new PizzaService();
            var result = pizzaService.GetPizzas(pizzas);

            // print the results
            foreach (var r in result.Take(10))
            {
                Console.WriteLine("{0} - {1}", r.Count, r.Pizza);
            }
        }
    }
}
