using System;

namespace Boolean_Variable
{
   public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool output = Convert.ToBoolean(input);
            if (output)
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
