using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var strToSearch = Console.ReadLine();

            var counter = 0;
            int index = text.IndexOf(strToSearch);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(strToSearch, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
