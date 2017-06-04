using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numOfLines = int.Parse(Console.ReadLine());

            string message = String.Empty;

            for (int i = 0; i < numOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                message += (char)(letter + key);
            }
            Console.WriteLine(message);
        }
    }
}
