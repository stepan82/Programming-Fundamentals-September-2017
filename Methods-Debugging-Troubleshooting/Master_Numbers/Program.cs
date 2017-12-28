using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (IsPalindrome(i.ToString()) && SumOfDigits_Divisible_7(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool SumOfDigits_Divisible_7(int number)
        {
            int sum = 0;
            int even = 0;
            int currentnumber = number;
            while (currentnumber > 0)
            {
                sum += currentnumber % 10;
                if (currentnumber % 2 == 0)
                {
                    even++;
                }
                currentnumber = currentnumber / 10;
            }

            if (sum % 7 == 0 && even > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool IsPalindrome(string number)
        {
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
