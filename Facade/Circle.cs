using System;

namespace Facade
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle draw");
        }
    }
}