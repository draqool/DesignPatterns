namespace BuilderPattern.Food
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg burger";
        }

        public override float Price()
        {
            return 25.0f;
        }
    }
}