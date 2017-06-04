using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            sbyte numberOfLines = sbyte.Parse(Console.ReadLine());
            string strToPrint = string.Empty;

            for (int i = 1; i <= numberOfLines; i++)
            {
                string word = Console.ReadLine();

                if (evenOrOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        strToPrint += word + delimiter;
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        strToPrint += word + delimiter;
                    }
                }
            }
            Console.WriteLine(strToPrint.Remove(strToPrint.Length - 1));
        }
    }
}
