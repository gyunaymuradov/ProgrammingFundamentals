using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequence2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var matchSum = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        counter++;

                        if (i + j + k >= matchSum)
                        {
                            Console.Write("O" + ("" + i + j + k).Replace('1', 'A').Replace('2', 'C')
                                          .Replace('3', 'G').Replace('4', 'T') + "O ");
                        }
                        else
                        {
                            Console.Write("X" + ("" + i + j + k).Replace('1', 'A').Replace('2', 'C')
                                          .Replace('3', 'G').Replace('4', 'T') + "X ");
                        }
                        if (counter % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
