using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfPeople = int.Parse(Console.ReadLine());
            var elevatorCapacity = int.Parse(Console.ReadLine());

            var courses = Math.Ceiling((double)numOfPeople / elevatorCapacity);

            Console.WriteLine(courses);
        }
    }
}
