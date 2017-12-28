using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Split_Word_Casing
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')'
                 ,'"', '\\', '/', '[', ']', '\'', ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixed = new List<string>();

            for (int i = 0; i < inputNums.Count; i++)
            {
                if (inputNums[i].All(char.IsUpper))
                {
                    upperCase.Add(inputNums[i]);
                }

                else if (inputNums[i].All(char.IsLower))
                {
                    lowerCase.Add(inputNums[i]);
                }
                else
                {
                    mixed.Add(inputNums[i]);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixed));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
