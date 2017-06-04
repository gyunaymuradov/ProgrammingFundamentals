using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DNASequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());

            var counter = 0;
            var iValue = 0;
            var jValue = 0;
            var kValue = 0;
            var sumOfElements = 0;

            for (char i = 'A'; i <= 'T'; i++)
            {
                if (i == 'A' || i == 'C' || i == 'G' || i == 'T')
                {
                    switch (i)
                    {
                        case 'A':
                            iValue = 1;
                            break;
                        case 'C':
                            iValue = 2;
                            break;
                        case 'G':
                            iValue = 3;
                            break;
                        case 'T':
                            iValue = 4;
                            break;
                    }
                }
                else
                {
                    continue;
                }
                for (char j = 'A'; j <= 'T'; j++)
                {
                    if (j == 'A' || j == 'C' || j == 'G' || j == 'T')
                    {
                        switch (j)
                        {
                            case 'A':
                                jValue = 1;
                                break;
                            case 'C':
                                jValue = 2;
                                break;
                            case 'G':
                                jValue = 3;
                                break;
                            case 'T':
                                jValue = 4;
                                break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                    for (char k = 'A'; k <= 'T'; k++)
                    {
                        if (k == 'A' || k == 'C' || k == 'G' || k == 'T')
                        {
                            switch (k)
                            {
                                case 'A':
                                    kValue = 1;
                                    break;
                                case 'C':
                                    kValue = 2;
                                    break;
                                case 'G':
                                    kValue = 3;
                                    break;
                                case 'T':
                                    kValue = 4;
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }

                        counter++;
                        sumOfElements = iValue + kValue + jValue;

                        if (sumOfElements >= sum)
                        {
                            Console.Write("O" + i.ToString() + j.ToString() + k.ToString() + "O" + " ");
                        }
                        else
                        {
                            Console.Write("X" + i.ToString() + j.ToString() + k.ToString() + "X" + " ");
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
