using BridgeDesignPattern.Interfaces;
using BridgeDesignPattern.Brands.Base;

namespace BridgeDesignPattern.Brands
{
    public class Toyota : Car
    {
        public Toyota(IEngine engine) : base(engine) { }

        public override void Start()
        {
            Console.WriteLine("Starting Toyota car");
            engine.Start();
        }
    }
}
