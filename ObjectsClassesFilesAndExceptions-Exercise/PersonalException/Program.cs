using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    var num = int.Parse(Console.ReadLine());
                    if (num < 0)
                    {
                        throw new PersonalException();
                    }
                    Console.WriteLine(num);
                }
            }
            catch (PersonalException myException)
            {
                Console.WriteLine(myException.Message);
            }
        }
    }
}
