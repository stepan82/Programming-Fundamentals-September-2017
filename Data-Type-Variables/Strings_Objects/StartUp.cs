using System;

namespace Strings_Objects
{
   public class StartUp
    {
      public static void Main(string[] args)
        {
            string text1 = "Hello";
            string text2 = "World";
            object result = text1 +" "+text2;
            string finalResult = (string)result;
            Console.WriteLine(finalResult);
        }
    }
}
