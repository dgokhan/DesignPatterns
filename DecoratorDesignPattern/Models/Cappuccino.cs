using DecoratorDesignPattern.Interfaces;

namespace DecoratorDesignPattern.Models
{
    public class Cappuccino : ICoffee
    {
        private readonly ICoffee coffee;
        public Cappuccino(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public double GetCost() => this.coffee.GetCost() + 2;
        
        public string GetDescription() => this.coffee.GetDescription() + " & Milk";
    }
}
