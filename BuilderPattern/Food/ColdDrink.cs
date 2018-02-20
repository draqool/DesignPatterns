using BuilderPattern.PackingElements;

namespace BuilderPattern.Food
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name();
        public abstract float Price();

        public IPacking Packing()
        {
            return new Bottle();
        }
    }
}