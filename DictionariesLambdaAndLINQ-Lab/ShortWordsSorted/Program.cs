using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = { ',', ' ', ':', ';', '(', ')', '[', ']', '"', '.', '\\', '/', '!', '?' };
            var list = Console.ReadLine().ToLower().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            var resultList = list.Distinct().Where(x => x.Length < 5).OrderBy(x => x);

            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}