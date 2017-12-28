using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input_1 = Console.ReadLine().TrimStart(new char[] { '0' }).ToCharArray().Reverse();
            var input_2 = Console.ReadLine().ToCharArray().Reverse();
            List<int> number_1 = input_1.Select(c => Convert.ToInt32(c.ToString())).ToList();
            List<int> number_2 = input_2.Select(c => Convert.ToInt32(c.ToString())).ToList();
            List<int> numberResult = new List<int>();

            int remainder = 0;
            int number = number_1.Count();

            for (int i = 0; i < number_1.Count; i++)
            {
                if (number_1[i] * number_2[0] + remainder < 10)
                {
                    numberResult.Add(number_1[i] * number_2[0] + remainder);
                    remainder = 0;
                }

                if (number_1[i] * number_2[0] + remainder > 9)
                {
                    numberResult.Add(((number_1[i] * number_2[0]) + remainder) % 10);

                    int remain = ((number_1[i] * number_2[0] + remainder)) / 10;
                    remainder = 0;
                    remainder += remain;

                    if (i == number_1.Count - 1 && remainder != 0)
                    {
                        numberResult.Add(remainder);
                        break;
                    }
                }
            }
            numberResult.Reverse();

            if (number_2[0] == 0)
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var item in numberResult)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

