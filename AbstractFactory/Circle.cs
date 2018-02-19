using System;

namespace AbstractFactory
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle - draw");
        }
    }
}