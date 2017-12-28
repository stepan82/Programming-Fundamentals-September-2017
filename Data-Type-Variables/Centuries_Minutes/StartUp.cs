using System;

namespace Centuries_Minutes
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());
            int years = centures * 100;
            int days = (int) (years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{centures} = {years} = {days} = {hours} = {minutes}");
        }
    }
}
