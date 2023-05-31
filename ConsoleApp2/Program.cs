using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            try
            {
                int nSequence = int.Parse(Console.ReadLine());
                NumberSequence.PrintSequence(nSequence);
            }
            catch { Console.WriteLine("Возникло исключение!"); }


            Console.WriteLine("\n\nВведите нечетное число больше 3:");
            try
            {
                int nSquare = int.Parse(Console.ReadLine());
                string result = Square.SquareWithHole(nSquare);
                Console.WriteLine(result);
            }
            catch { Console.WriteLine("Возникло исключение!"); }

            Console.ReadLine();
        }
    }
}
