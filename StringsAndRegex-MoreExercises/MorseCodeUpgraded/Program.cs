using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MorseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split('|').ToArray();
            var result = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                var num = line[i];
                var sum = 0;
                var bonusSum = 0;
                var lastIndex = 0;
                for (int j = 0; j < num.Length; j++)
                {
                    var extra = 1;
                    for (int k = j + 1; k < num.Length; k++)
                    {
                        if (num[j] == num[k])
                        {
                            extra++;
                            lastIndex = k;
                        }
                        else
                        {
                            lastIndex = k;
                            break;
                        }
                    }
                    if (extra > 1)
                    {
                        bonusSum += extra;
                    }
                    if (lastIndex == num.Length - 1)
                    {
                        break;
                    }
                    j = lastIndex - 1;

                }
                if (bonusSum > 1)
                {
                    sum += bonusSum;
                }

                for (int j = 0; j < num.Length; j++)
                {
                    if (num[j] == '0')
                    {
                        sum += 3;
                    }
                    else
                    {
                        sum += 5;
                    }
                }

                result.Append((char)sum);
            }

            Console.WriteLine(result);
        }
    }
}
