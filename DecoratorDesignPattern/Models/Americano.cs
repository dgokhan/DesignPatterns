using DecoratorDesignPattern.Interfaces;

namespace DecoratorDesignPattern.Models
{
    public class Americano : ICoffee
    {
        private readonly ICoffee coffee;
        public Americano(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public double GetCost() => this.coffee.GetCost() + 3;
        
        public string GetDescription() => this.coffee.GetDescription() + " & Hot Water";
    }
}
