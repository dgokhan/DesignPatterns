using DecoratorDesignPattern.Interfaces;

namespace DecoratorDesignPattern.Models.Base
{
    public class Espresso : ICoffee
    {
        public double GetCost() => 25;

        public string GetDescription() => "Espresso";
    }
}