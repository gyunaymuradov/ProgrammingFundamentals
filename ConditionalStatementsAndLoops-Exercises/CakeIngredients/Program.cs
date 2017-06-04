using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;

            for (int i = 0; i <= 20; i++)
            {
                var ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    counter++;

                }
                else
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    return;
                }
            }
        }
    }
}
