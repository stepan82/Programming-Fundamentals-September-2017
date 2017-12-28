using System;

namespace Vowel_or_Digit
{
    class StartUp
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            bool isVowel = "aoieu".IndexOf(input) > -1;
            bool isDigit = "0123456789".IndexOf(input) >= 0;
            if (isVowel)
            {
                Console.WriteLine("vowel");
            }
            else if (isDigit)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
