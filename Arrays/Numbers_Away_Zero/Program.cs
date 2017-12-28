using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Away_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
              .Split(' ')
              .Select(double.Parse)
              .ToArray();
            foreach (var number in arr)
            {
                Console.WriteLine("{0} => {1}", number, Math.Round(number, 0,
            MidpointRounding.AwayFromZero));
            }
        }
    }
}
