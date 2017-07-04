using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(' ').ToList();
            var trackLayout = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < participants.Count; i++)
            {
                var fuel = (double)participants[i][0];
                var reached = 0;
                for (int j = 0; j < trackLayout.Count; j++)
                {
                    if (checkpoints.Contains(j))
                    {
                        fuel += trackLayout[j];
                        reached++;
                        continue;
                    }
                    else
                    {
                        fuel -= trackLayout[j];
                        if (fuel <= 0)
                        {
                            break;
                        }
                        else
                        {
                            reached++;
                        }
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{participants[i]} - fuel left {fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{participants[i]} - reached {reached}");
                }
            }
        }
    }
}
