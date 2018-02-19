using System;

namespace AbstractFactory
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle - draw");
        }
    }
}