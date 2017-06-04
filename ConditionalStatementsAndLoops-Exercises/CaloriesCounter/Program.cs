using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cheeseCalories = 500;
            var tomatoSauceCalories = 150;
            var salamiCalories = 600;
            var pepperCalories = 50;

            var totalCalories = 0;
            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    totalCalories += cheeseCalories;
                } 
                else if (ingredient == "tomato sauce")
                {
                    totalCalories += tomatoSauceCalories;
                }
                else if (ingredient == "salami")
                {
                    totalCalories += salamiCalories;
                }
                else if (ingredient == "pepper")
                {
                    totalCalories += pepperCalories;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
