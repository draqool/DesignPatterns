using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }

        public override string GetName()
        {
            return _pizza.GetName();
        }
    }
}
