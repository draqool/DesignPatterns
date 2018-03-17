namespace Decorator.Pizza
{
    public class LargePizza : Pizza
    {
        public override double CalculateCost()
        {
            return 50.00;
        }

        public override string GetName()
        {
            return "Large Pizza";
        }
    }
}