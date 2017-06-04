using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTyping2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var combination = Console.ReadLine();
                var mainDigit = int.Parse(combination[0].ToString());

                var offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                var letterIndex = offset + combination.Length - 1;

                if (mainDigit == 0)
                {
                    text += " ";
                }
                else
                {
                    text += (char)(97 + letterIndex);
                }
            }
            Console.WriteLine(text);
        }
    }
}
