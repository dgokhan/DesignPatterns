using BridgeDesignPattern.Interfaces;

namespace BridgeDesignPattern.Engines
{
    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting petrol engine");
        }
    }
}
