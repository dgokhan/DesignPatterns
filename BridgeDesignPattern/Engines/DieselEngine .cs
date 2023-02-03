using BridgeDesignPattern.Interfaces;

namespace BridgeDesignPattern.Engines
{
    public class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting diesel engine");
        }
    }
}
