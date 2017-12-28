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
            var input_2 = Console.ReadLine().TrimStart(new char[] { '0' }).ToCharArray().Reverse();

            List<int> number_1 = input_1.Select(c => Convert.ToInt32(c.ToString())).ToList();
            List<int> number_2 = input_2.Select(c => Convert.ToInt32(c.ToString())).ToList();

            List<int> numberResult = new List<int>();

            int ostatak = 0;
            int number = number_1.Count();
            int numberR = number_2.Count();

            if (number_1.Count > number_2.Count)
            {
                for (int i = 0; i < number - numberR; i++)
                {
                    number_2.Add(0);
                }
            }

            else if (number_2.Count > number_1.Count)
            {
                for (int i = 0; i < numberR - number; i++)
                {
                    number_1.Add(0);
                }
            }

            for (int i = 0; i < number_1.Count; i++)
            {
                if (number_1[i] + number_2[i] + ostatak < 10)
                {
                    numberResult.Add(number_1[i] + number_2[i] + ostatak);
                    ostatak = 0;
                }

                if (number_1[i] + number_2[i] + ostatak > 9)

                {
                    numberResult.Add((number_1[i] + number_2[i] + ostatak) % 10);
                    ostatak = 0;
                    ostatak++;

                    if (i == number_1.Count - 1 && ostatak != 0)
                    {
                        numberResult.Add(ostatak);
                        break;
                    }
                }
            }

            numberResult.Reverse();

            foreach (var item in numberResult)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

