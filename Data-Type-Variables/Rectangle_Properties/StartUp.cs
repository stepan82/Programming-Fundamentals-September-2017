using System;

namespace Rectangle_Properties
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double periemter = 2 * width + 2 * height;
            double area = width * height;
            double diagonal = Math.Sqrt(width * width + height * height);
            Console.WriteLine(periemter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
