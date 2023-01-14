using FactoryMethodDesignPattern.Models.Base;

namespace FactoryMethodDesignPattern.Models
{
    public class Hatchback : Car
    {
        public override int Wheel => 4;
        public override bool HasSunRoof => false;
        public override bool IsElectric => true;
    }
}
