using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numOfPhotos = long.Parse(Console.ReadLine());
            long filterTimeInSecondsPer1Photo = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long timeNeededToUpload = long.Parse(Console.ReadLine());

            double totalFilterTimeInSeconds = numOfPhotos * filterTimeInSecondsPer1Photo;
            double amountOfGoodPhotos = Math.Ceiling(numOfPhotos * (double)filterFactor / 100);
            double totalTimeInSeconds = totalFilterTimeInSeconds + (amountOfGoodPhotos * timeNeededToUpload);

            TimeSpan timeSpan = TimeSpan.FromSeconds(totalTimeInSeconds);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                timeSpan.Days, timeSpan.Hours, 
                timeSpan.Minutes, timeSpan.Seconds);
        }
    }
}
