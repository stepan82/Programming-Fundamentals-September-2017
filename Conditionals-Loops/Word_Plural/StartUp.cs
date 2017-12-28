namespace Word_Plural
{
    using System;
    public class StartUp
    {
       public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.EndsWith("y") == true)
            {
               var output = input.Remove(input.Length - 1);
                Console.WriteLine($"{output}ies");
            }

            else if 
                (input.EndsWith("o") == true || input.EndsWith("ch") == true || input.EndsWith("s") == true
                || input.EndsWith("sh") == true || input.EndsWith("x") == true || input.EndsWith("z") == true)
            {           
                Console.WriteLine($"{input}es");
            }
            else
            {
                Console.WriteLine($"{input}s");
            }
        }
    }
}
