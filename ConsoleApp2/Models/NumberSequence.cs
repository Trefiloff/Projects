using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class NumberSequence
    {
        public static void PrintSequence(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i != n)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
