using FactoryMethodDesignPattern;
using FactoryMethodDesignPattern.Enums;
using FactoryMethodDesignPattern.Models.Base;

CarFactory factory = new CarFactory();
Car myCar = factory.Create(CarTypes.Sedan);

Console.WriteLine($"Araç teker sayısı: {myCar.Wheel}");
Console.WriteLine($"Sunroof varmı?: {myCar.HasSunRoof}");
Console.WriteLine($"Elektrikli mi?: {myCar.IsElectric}");
Console.ReadLine();