// See https://aka.ms/new-console-template for more information
using FactoryMethodDesignPattern;
using FactoryMethodDesignPattern.Enums;
using FactoryMethodDesignPattern.Models.Base;

CarFactory factory = new CarFactory();
Car myCar = factory.Create(CarTypes.Sedan);

Console.ReadLine();