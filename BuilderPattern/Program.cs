using BuilderPattern.Builders;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.PrepareVegMeal();
            vegMeal.ShowItems();

            Console.WriteLine();

            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            vegMeal.ShowItems();

            Console.ReadKey();
        }
    }
}
