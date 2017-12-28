
namespace Hotel
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            switch (month)
            {
                case "May":
                    if (nights <= 7)
                    {
                        Console.WriteLine($"Studio: {(50 * nights):F2} lv.");
                        Console.WriteLine($"Double: {(65 * nights):F2} lv.");
                        Console.WriteLine($"Suite: {(75 * nights):F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {((50 - (50 * 0.05)) * nights):F2} lv.");
                        Console.WriteLine($"Double: {(65 * nights):F2} lv.");
                        Console.WriteLine($"Suite: {(75 * nights):F2} lv.");
                    }
                    break;

                case "October":
                    if (nights <= 7)
                    {
                        Console.WriteLine($"Studio: {(50 * nights):F2} lv.");
                        Console.WriteLine($"Double: {(65 * nights):F2} lv.");
                        Console.WriteLine($"Suite: {(75 * nights):F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {((50-(50 * 0.05)) * (nights - 1)):F2} lv.");
                        Console.WriteLine($"Double: {(65 * nights):F2} lv.");
                        Console.WriteLine($"Suite: {(75 * nights):F2} lv.");
                    }
                    break;

                case "June":
                    if (nights <= 14)
                    {
                        Console.WriteLine($"Studio: {(60 * nights):F2} lv.");
                        Console.WriteLine($"Double: {(72 * nights):F2} lv.");
                        Console.WriteLine($"Suite: {(82 * nights):F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {60 * nights:F2} lv.");
                        Console.WriteLine($"Double: {((72 - (72 * 0.10)) * nights):F2} lv.");
                        Console.WriteLine($"Suite: {(82 * nights):F2} lv.");
                    }
                    break;

                case "September":
                    if (nights <= 7)
                    {
                        Console.WriteLine($"Studio: {(60 * nights):F2} lv.");
                        Console.WriteLine($"Double: {(72 * nights):F2} lv.");
                        Console.WriteLine($"Suite: {(82 * nights):F2} lv.");
                    }
                    else if (nights > 7 && nights <=14)
                    {
                        Console.WriteLine($"Studio: {60 * (nights - 1):F2} lv.");
                        Console.WriteLine($"Double: {(72 * nights):F2} lv.");
                        Console.WriteLine($"Suite: {(82 * nights):F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {60 * (nights - 1):F2} lv.");
                        Console.WriteLine($"Double: {((72 - (72 * 0.10)) * (nights - 1)):F2} lv.");
                        Console.WriteLine($"Suite: {(82 * nights):F2} lv.");
                    }
                    break;

                case "July":
                case "August":
                case "December":
                    if (nights <= 14)
                    {
                        Console.WriteLine($"Studio: {(68 * nights):F2} lv.");
                        Console.WriteLine($"Double: {(77 * nights):F2} lv.");
                        Console.WriteLine($"Suite: {(89 * nights):F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {68 * nights:F2} lv.");
                        Console.WriteLine($"Double: {(77 * nights):F2} lv.");
                        Console.WriteLine($"Suite: {((89 - (89 * 0.15)) * nights):F2} lv.");
                    }
                    break;
            }
        }
    }
}
