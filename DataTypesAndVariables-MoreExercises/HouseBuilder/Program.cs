using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long sbytePrice = 0;
            long intPrice = 0;

            for (int i = 0; i < 2; i++)
            {
                int materialPrice = int.Parse(Console.ReadLine());

                if (materialPrice <= sbyte.MaxValue)
                {
                    sbytePrice = (long)4 * materialPrice;
                }
                else
                {
                    intPrice = (long)10 * materialPrice;
                } 
            }
            long totalPrice = sbytePrice + intPrice;
            Console.WriteLine(totalPrice);
        }
    }
}
