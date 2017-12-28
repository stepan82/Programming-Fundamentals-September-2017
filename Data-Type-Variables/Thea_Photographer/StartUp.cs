using System;

namespace Thea_Photographer
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            ulong numberOfPictures = ulong.Parse(Console.ReadLine());
            ulong timeForOnePicture = ulong.Parse(Console.ReadLine());
            ulong percentOfGoodPictures = ulong.Parse(Console.ReadLine());
            ulong timeForOneGoodPicture = ulong.Parse(Console.ReadLine());
            double percentage = percentOfGoodPictures / 100.0;
            double goodPictures = Math.Ceiling(numberOfPictures * percentage);
            ulong timeForObserving = timeForOnePicture * numberOfPictures;
            ulong timeForUpload = (ulong)(goodPictures * timeForOneGoodPicture);
            ulong totalTime = timeForObserving + timeForUpload;
            var ts = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine(string.Format($"{ts.Days}:{ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}"));
        }
    }
}
