using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            bool isBalanced = false;
            char lastBracket = ' ';
            int bracketCounter = 0;

            for (int i = 0; i < n; i++)
            {
                try
                {
                    char currentBracket = char.Parse(Console.ReadLine());
                    bracketCounter++;

                    if (currentBracket == '(')
                    {
                        if (lastBracket == ')')
                        {
                            isBalanced = true;
                        }
                        lastBracket = currentBracket;
                    }
                    if (currentBracket == ')')
                    {
                        if (lastBracket == '(')
                        {
                            isBalanced = true;
                        }
                    }
                }
                catch
                {
                    continue;
                }
            }
            if (bracketCounter % 2 != 0)
            {
                isBalanced = false;
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}