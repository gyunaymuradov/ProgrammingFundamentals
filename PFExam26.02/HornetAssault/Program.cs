using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                long hornetsPower = hornets.Sum();
                if (beehives[i] < hornetsPower)
                {
                    beehives[i] = 0;
                }
                else if (beehives[i] - hornetsPower >= 0)
                {

                    long beehivesLeft = beehives[i] - hornetsPower;
                    beehives[i] = beehivesLeft;
                    hornets.RemoveAt(0);
                }
                if (hornets.Count == 0)
                {
                    break;
                }
            }
            if (beehives.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(a => a > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
