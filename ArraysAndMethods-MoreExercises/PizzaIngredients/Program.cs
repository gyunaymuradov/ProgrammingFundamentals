using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split().ToArray();
            var lengthOfIngredient = int.Parse(Console.ReadLine());
            var maxIngredients = 10;
            var counter = 0;

            List<string> list = new List<string>();

            foreach (var currentIngredient in ingredients)
            {
                if (currentIngredient.Length == lengthOfIngredient)
                {
                    Console.WriteLine($"Adding {currentIngredient}.");
                    maxIngredients--;
                    counter++;
                    list.Add(currentIngredient);
                }
                if (maxIngredients == 0)
                {
                    Console.WriteLine($"Made pizza with total of {counter} ingredients.");
                    Console.WriteLine($"The ingredients are: {string.Join(", ", list)}.");
                    return;
                }
            }
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", list)}.");
        }
    }
}