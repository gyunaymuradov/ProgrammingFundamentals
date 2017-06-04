using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoNum = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSize = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var convertedPhotoSize = string.Empty;
            var orientation = string.Empty;

            if (photoSize < 1000)
            {
                convertedPhotoSize = $"{photoSize}B";
            } 
            else if (photoSize > 1000 && photoSize < 1000000)
            {
                photoSize /= 1000;
                convertedPhotoSize = $"{photoSize}KB";
            }
            else
            {
                photoSize /= 1000000;
                convertedPhotoSize = $"{photoSize}MB";
            }
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width == height)
            {
                orientation = "square";
            }
            else
            {
                orientation = "portrait";
            }
            Console.WriteLine($"Name: DSC_{photoNum:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {convertedPhotoSize}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
