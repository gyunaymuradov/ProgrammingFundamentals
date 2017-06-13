using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> resultList = new List<string>();

            List<string> tokensList = Console.ReadLine().Split('|').ToList();

            tokensList.Reverse();

            foreach (var item in tokensList)
            {
                List<string> items = item.Split(' ').ToList();

                foreach (var currenItem in items)
                {
                    resultList.Add(currenItem);
                }
            }
            
            foreach (var num in resultList)
            {
                if (num != "")
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}