﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BigInteger.Parse(Console.ReadLine()) * BigInteger.Parse(Console.ReadLine()));
        }
    }
}
