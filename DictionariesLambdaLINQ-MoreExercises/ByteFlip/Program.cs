using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Where(x => x.Length == 2).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                input[i] = Reverse(input[i]);
            }
            input.Reverse();

            foreach (var hex in input)
            {
                Console.Write((char)Convert.ToInt64(hex, 16));
            }
        }

         static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}