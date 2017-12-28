using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var total = 0;
            for (int i = 1; i <= number; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                switch (ingredients)
                {
                    case "cheese":
                        total += 500;
                        break;
                    case "tomato sauce":
                        total += 150;
                        break;
                    case "salami":
                        total += 600;
                        break;
                    case "pepper":
                        total += 50;
                        break;
                }
            }
            Console.WriteLine($"Total calories: {total}");
        }
    }
}
