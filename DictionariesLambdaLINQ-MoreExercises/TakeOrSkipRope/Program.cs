using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeOrSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] charArr = input.ToCharArray();
            var numbersList = new List<int>();
            var nonnumericList = new List<char>();

            foreach (var symbol in charArr)
            {
                if (char.IsDigit(symbol))
                {
                    var num = int.Parse(symbol.ToString());
                    numbersList.Add(num);
                }
                else
                {
                    nonnumericList.Add(symbol);
                }
            }
            var takeList = new List<int>();
            var skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }
            var resultString = string.Empty;
            var totalSkipCount = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                var skipCount = skipList[i];
                var takeCount = takeList[i];
                resultString += new string(nonnumericList.Skip(totalSkipCount).Take(takeCount).ToArray());
                totalSkipCount += skipCount + takeCount;
            }
            Console.WriteLine(resultString);
        }
    }
}
