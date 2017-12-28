using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();

            var dayTime = new DateTime(input[2], input[1], input[0]);

            Console.WriteLine(dayTime.DayOfWeek);
        }
    }
}
