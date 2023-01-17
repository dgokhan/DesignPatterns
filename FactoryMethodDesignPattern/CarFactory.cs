using FactoryMethodDesignPattern.Enums;
using FactoryMethodDesignPattern.Models;
using FactoryMethodDesignPattern.Models.Base;

namespace FactoryMethodDesignPattern
{
    public class CarFactory
    {
        public Car Create(CarTypes type)
        {
            switch (type)
            {
                case CarTypes.Sedan:
                    return new Sedan();
                case CarTypes.SUV:
                    return new SUV();
                case CarTypes.Hatchback:
                    return new Hatchback();
                default:
                    throw new Exception("Invalid car type");
            }
        }
    }
}
