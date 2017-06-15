using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOcurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().ToLower().Split().ToList();
            var dict = new Dictionary<string, int>();

            foreach (var word in list)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
            }

            var resultList = new List<string>();

            foreach (var key in dict)
            {
                if (key.Value % 2 == 1)
                {
                    resultList.Add(key.Key);
                }
            }
            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}