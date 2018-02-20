using BuilderPattern.PackingElements;
using System;

namespace BuilderPattern.Food
{
    public abstract class Burger : IItem
    {
        public abstract string Name();
        public abstract float Price();

        public IPacking Packing()
        {
            return new Wrapper();
        }
    }
}