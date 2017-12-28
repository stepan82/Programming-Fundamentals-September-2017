using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo = "Stepan";
            char[] toChararray = demo.ToCharArray();
            toChararray[0] = 't';
            Console.WriteLine(string.Join(", ", toChararray));
        }
    }
}
