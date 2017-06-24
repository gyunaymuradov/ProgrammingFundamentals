using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("input.txt");
            char[] symbols = new[] { '.', ',', '!', '?', ':', ' ', '\t','\n'};

            var words = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            var output = string.Join(" ", words);

            File.WriteAllText("output.txt", output);
        }
    }
}
