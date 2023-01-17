using DecoratorDesignPattern.Interfaces;
using DecoratorDesignPattern.Models;
using DecoratorDesignPattern.Models.Base;

ICoffee c = new Espresso();
Console.WriteLine(c.GetCost());
Console.WriteLine(c.GetDescription());

c = new Cappuccino(c);

Console.WriteLine(c.GetCost()); 
Console.WriteLine(c.GetDescription());

Console.ReadKey();