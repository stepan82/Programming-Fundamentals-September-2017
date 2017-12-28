using System;

namespace Convert_Speed_Units
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int timeInSeconds = (hours * 3600) + (minutes * 60) + seconds;
            float timeInHours = timeInSeconds / 3600f;
            int kilometres = distanceMeters / 1000;
            float miles = distanceMeters / 1609F;
            Console.WriteLine($"{(float)distanceMeters / timeInSeconds}");
            Console.WriteLine($"{kilometres / timeInHours}");
            Console.WriteLine($"{miles/timeInHours}");

        }
    }
}
