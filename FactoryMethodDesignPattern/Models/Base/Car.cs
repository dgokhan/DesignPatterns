namespace FactoryMethodDesignPattern.Models.Base
{
    public abstract class Car
    {
        public abstract int Wheel { get; }
        public abstract bool HasSunRoof { get; }
        public abstract bool IsElectric { get; }
    }
}
