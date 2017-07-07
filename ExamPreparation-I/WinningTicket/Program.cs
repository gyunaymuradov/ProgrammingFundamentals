using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A valid ticket should have exactly 20 characters. The winning symbols are '@', '#', '$' and '^'. 
             * But in order for a ticket to be a winner the symbol should uninterruptedly repeat for at least
             * 6 times in both the tickets left half and the tickets right half. 
             */

            var input = Console.ReadLine();

            var text = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var validTickets = new List<string>();

            foreach (var ticket in text)
            {
                if (ticket.Length == 20)
                {
                    var validLeft = false;
                    var validRight = false;
                    var counterLeft = 0;
                    var counterRight = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        if (ticket[i] == '@')
                        {
                            for (int j = i + 1; j < 10; j++)
                            {
                                if (ticket[j] == '@')
                                {
                                    counterLeft++;
                                }
                                else
                                {
                                    counterLeft = 0;
                                }
                            }
                            if (validLeft)
                            {

                            }
                            for (int j = 10; i < 20; i++)
                            {
                                if (ticket[j] == '@')
                                {

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
