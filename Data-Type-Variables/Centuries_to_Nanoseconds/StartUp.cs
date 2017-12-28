using System;
using System.Numerics;

namespace Centuries_to_Nanoseconds
{
  public  class StartUp
    {
       public static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int) (years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milisec = seconds * 1000;
            long microsec = milisec * 1000;
            decimal nanosecond = microsec * 1000M;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milisec} milliseconds = {microsec} microseconds = {nanosecond} nanoseconds");
        }
    }
}
