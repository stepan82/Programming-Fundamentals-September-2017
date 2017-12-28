using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char bet in input)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)bet));
            }

            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();
        }
    }
}
