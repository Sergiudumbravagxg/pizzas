using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Pizzas.Test
{
    [TestFixture]
    public class PizzaServiceTests
    {
        [Test]
        public void QueryPizzasByPopularity()
        {
            // Arrange
            var pizzas = new List<Pizza>()
            {
                new Pizza()
                {
                    Toppings = new List<string>
                    {
                        "Cheese",
                        "Vegies"
                    }
                },
                new Pizza()
                {
                    Toppings = new List<string>
                    {
                        "Cheese"
                    }
                },
                new Pizza()
                {
                    Toppings = new List<string>
                    {
                        "Cheese"
                    }
                }
            };

            //act
            var result = new PizzaService().GetPizzas(pizzas);

            //assert
            result.Count().Should().Be(2);
            result.First().Count.Should().Be(2);
            result.First().Pizza.Should().Be("Cheese");
            result.Last().Count.Should().Be(1);
            result.Last().Pizza.Should().Be("Cheese, Vegies");
        }
    }
}
