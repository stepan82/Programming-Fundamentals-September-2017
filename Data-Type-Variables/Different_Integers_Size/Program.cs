using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                long inputNumber = Convert.ToInt64(Convert.ToDecimal(input));
                //negative values
                if (inputNumber < 0 && inputNumber >= -128)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else if (inputNumber < -128 && inputNumber >= -32768)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else if (inputNumber < -32768 && inputNumber >= -2147483648)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else if (inputNumber < -2147483648 && inputNumber >= -9223372036854775808)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* long");
                }

                //positive values
                if (inputNumber > -1 && inputNumber <= 127)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (inputNumber > 127 && inputNumber <= 255)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (inputNumber > 255 && inputNumber <= 32767)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (inputNumber > 32767 && inputNumber <= 65535)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (inputNumber > 65535 && inputNumber <= 2147483647)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (inputNumber > 2147483647 && inputNumber <= 4294967295)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (inputNumber > 4294967295 && inputNumber <= 9223372036854775807)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
