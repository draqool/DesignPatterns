using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponents;
using DecoratorPattern.ConcreteDecorators;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new CheeseDecorator(largePizza);

            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}
