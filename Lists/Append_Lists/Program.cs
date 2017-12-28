using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<string> result = new List<string>();
            for (int i = 0; i < inputNums.Count; i++)
            {
                string currentNumbers = inputNums[i];
                string[] numbers = currentNumbers.Split(new char[] { },
                    StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(numbers);

            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
