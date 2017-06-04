using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes >= 60)
            {
                hours++;
                minutes = minutes % 60;
            }

            if (hours > 23)
            {
                hours -= 24;
            }
            Console.WriteLine(minutes > 9 ? $"{hours}:{minutes}" : $"{hours}:0{minutes}");
        }
    }
}
