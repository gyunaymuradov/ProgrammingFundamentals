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
            string lastBracket = string.Empty;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string currentBracket = Console.ReadLine();

                    if (currentBracket == ")")
                    {
                        counter++;
                        if (lastBracket == "(")
                        {
                            isBalanced = true;
                        }
                        lastBracket = currentBracket;
                    }
                    else if (currentBracket == "(")
                    {
                        counter++;
                        if (lastBracket == ")")
                        {
                            isBalanced = false;
                        }
                        lastBracket = currentBracket;
                    }
                    if (counter == 1)
                    {
                        if (currentBracket == ")")
                        {
                            isBalanced = false;
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                    }
                }
                catch
                {
                    continue;
                }
            }
            if (counter % 2 == 1)
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