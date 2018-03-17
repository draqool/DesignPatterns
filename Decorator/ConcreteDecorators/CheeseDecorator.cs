using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorators
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza)
            : base(pizza)
        {
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 2.15;
        }

        public override string GetName()
        {
            return base.GetName() + " Cheese";
        }
    }
}