using FactoryMethodDesignPattern.Models.Base;

namespace FactoryMethodDesignPattern.Models
{
    public class SUV : Car
    {
        public override int Wheel => 4;
        public override bool HasSunRoof => true;
        public override bool IsElectric => false;
    }
}
