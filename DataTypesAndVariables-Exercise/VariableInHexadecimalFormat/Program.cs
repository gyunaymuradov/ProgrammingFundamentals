using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string numInHex = Console.ReadLine();

            int numInDec = Convert.ToInt32(numInHex, 16);

            Console.WriteLine(numInDec);
        }
    }
}
