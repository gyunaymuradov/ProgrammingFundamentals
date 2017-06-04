using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bpm = int.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());

            var bars = Math.Round(numberOfBeats / 4,1);
            var time = numberOfBeats / bpm * 60;
            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            var seconds = (int)time % 60;
            int minutes = (int)time / 60;

            Console.WriteLine($"{bars} bars - {timeSpan.Minutes}m {timeSpan.Seconds}s");
        }
    }
}
