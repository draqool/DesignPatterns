namespace BuilderPattern.Food
{
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "Chicken burger";
        }

        public override float Price()
        {
            return 50.0f;
        }
    }
}