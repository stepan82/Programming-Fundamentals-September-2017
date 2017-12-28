using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedList = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var text = Console.ReadLine();

            foreach (var item in bannedList)
            {
                if (text.Contains(item))
                {
                    text = text.Replace(item, new string('*', item.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
