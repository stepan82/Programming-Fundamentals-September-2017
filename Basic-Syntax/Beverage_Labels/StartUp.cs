
namespace Beverage_Labels
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());
            double energy_10_ml = energyContent / 10.00;
            double sugar_10_ml = sugarContent / 10.00;
            double volume_10_ml = volume / 10.00;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy_10_ml * volume_10_ml}kcal, {sugar_10_ml * volume_10_ml}g sugars");
        }
    }
}
