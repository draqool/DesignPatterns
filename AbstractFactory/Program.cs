using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.Create(ShapeEnum.Circle);
            shape1.Draw();

            IShape shape2 = shapeFactory.Create(ShapeEnum.Rectangle);
            shape2.Draw();

            IShape shape3 = shapeFactory.Create(ShapeEnum.Square);
            shape3.Draw();

            Console.ReadKey();
        }
    }
}