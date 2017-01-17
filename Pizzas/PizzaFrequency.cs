namespace Pizzas
{
    public class PizzaFrequency
    {
        public string Pizza { get; }
        public int Count { get; }

        public PizzaFrequency(string pizza, int count)
        {
            Pizza = pizza;
            Count = count;
        }
    }
}