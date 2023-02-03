using BridgeDesignPattern.Interfaces;

namespace BridgeDesignPattern.Brands.Base
{
    public abstract class Car
    {
        protected IEngine engine;

        protected Car(IEngine engine)
        {
            this.engine = engine;
        }

        public abstract void Start();
    }
}
