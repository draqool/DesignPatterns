using System;

namespace Facade
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle draw");
        }
    }
}