using BridgeDesignPattern.Interfaces;
using BridgeDesignPattern.Brands.Base;

namespace BridgeDesignPattern.Brands
{
    public class Ford : Car
    {
        public Ford(IEngine engine) : base(engine) { }

        public override void Start()
        {
            Console.WriteLine("Starting Ford car");
            engine.Start();
        }
    }
}
