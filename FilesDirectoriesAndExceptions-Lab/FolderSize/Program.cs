using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = Directory.GetFiles("TestFolder");
            double sum = 0;

             foreach (var currentFile in file)
            {
                FileInfo info = new FileInfo(currentFile);
                sum += info.Length;
            }
            var sumInMb = sum / 1024 / 1024;

            Console.WriteLine(sumInMb);
        }
    }
}
