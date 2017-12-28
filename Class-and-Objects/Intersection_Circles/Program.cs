using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            var circleParametres_1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var circleParametres_2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

           
            double xResult = Math.Pow((Math.Abs(circleParametres_1[0] - circleParametres_2[0])), 2);
            double yResult = Math.Pow((Math.Abs(circleParametres_1[1] - circleParametres_2[1])), 2);
            double distanceBetweenCenters = Math.Sqrt(xResult + yResult);
            double radiusSum = circleParametres_1[2] + circleParametres_2[2];
            if (distanceBetweenCenters <= radiusSum)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
