using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Square
    {
        public static string SquareWithHole(int n)
        {
            if (n % 2 == 0 || n < 3)
            {
                return "Ошибка! Введено некорректное число.";
            }

            string result = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n / 2 && j == n / 2)
                    {
                        result += " ";
                    }
                    else
                    {
                        result += "#";
                    }
                }
                result += "\n";
            }

            return result;
        }
    }
}
