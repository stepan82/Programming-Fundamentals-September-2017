using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').ToArray();

            var firstWord = tokens[0].ToCharArray();
            var secondWord = tokens[1].ToCharArray();

            int minNumber = Math.Min(firstWord.Length, secondWord.Length);

            int totalSum = 0;

            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    var result = Convert.ToInt32(firstWord[i]) * Convert.ToInt32(secondWord[i]);
                    totalSum += result;
                }
            }
            else
            {
                if (firstWord.Length == minNumber)
                {
                    for (int i = 0; i < firstWord.Length; i++)
                    {
                        var result = Convert.ToInt32(firstWord[i]) * Convert.ToInt32(secondWord[i]);
                        totalSum += result;
                    }
                    for (int i = minNumber; i < secondWord.Length; i++)
                    {
                        totalSum += secondWord[i];
                    }
                }
                else
                {
                    for (int i = 0; i < secondWord.Length; i++)
                    {
                        var result = Convert.ToInt32(firstWord[i]) * Convert.ToInt32(secondWord[i]);
                        totalSum += result;
                    }
                    for (int i = minNumber; i < firstWord.Length; i++)
                    {
                        totalSum += firstWord[i];
                    }
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
