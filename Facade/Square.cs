using System;

namespace Facade
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square draw");
        }
    }
}