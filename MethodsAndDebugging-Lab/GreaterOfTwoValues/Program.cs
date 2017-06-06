using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                var input1 = int.Parse(Console.ReadLine());
                var input2 = int.Parse(Console.ReadLine());

                var bigger = GetMax(input1, input2);
                Console.WriteLine(bigger);
            }
            else if (type == "string")
            {
                var input1 = Console.ReadLine();
                var input2 = Console.ReadLine();

                var bigger = GetMax(input1, input2);
                Console.WriteLine(bigger);
            }
            else if (type == "char")
            {
                var input1 = char.Parse(Console.ReadLine());
                var input2 = char.Parse(Console.ReadLine());

                var bigger = GetMax(input1, input2);
                Console.WriteLine(bigger);
            }
        }

        static int GetMax(int input1, int input2)
        {
            if (input1 > input2)
            {
                return input1;
            }
            return input2;
        }

        static string GetMax(string input1, string input2)
        {
            if (input1.CompareTo(input2) > 0)
            {
                return input1;
            }
            return input2;
        }

        static char GetMax(char input1, char input2)
        {
            if (input1 > input2)
            {
                return input1;
            }
            return input2;
        }
    }
}
