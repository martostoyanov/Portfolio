using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            double chisloEdno = double.Parse(Console.ReadLine());
            double chisloDve = double.Parse(Console.ReadLine());
            string operacia = Console.ReadLine();

            double rezultat = 0;

            if (operacia == "+")
            {
                rezultat = chisloEdno + chisloDve;
                if (rezultat % 2 == 0)
                {
                    Console.WriteLine($"{chisloEdno} + {chisloDve} = {rezultat} - even");
                }
                else
                {
                    Console.WriteLine($"{chisloEdno} + {chisloDve} = {rezultat} - odd");
                }
            }
            else if (operacia == "-")
            {
                rezultat = chisloEdno - chisloDve;
                if (rezultat % 2 == 0)
                {
                    Console.WriteLine($"{chisloEdno} - {chisloDve} = {rezultat} - even");
                }
                else
                {
                    Console.WriteLine($"{chisloEdno} - {chisloDve} = {rezultat} - odd");
                }
            }
            else if (operacia == "*")
            {
                rezultat = chisloEdno * chisloDve;
                if (rezultat % 2 == 0)
                {
                    Console.WriteLine($"{chisloEdno} * {chisloDve} = {rezultat} - even");
                }
                else
                {
                    Console.WriteLine($"{chisloEdno} * {chisloDve} = {rezultat} - odd");
                }
            }
            else if (operacia == "/")
            {
                rezultat = chisloEdno / chisloDve;
                if (chisloDve == 0)
                {
                    Console.WriteLine($"Cannot divide {chisloEdno} by zero");
                }
                else
                {
                    Console.WriteLine($"{chisloEdno} / {chisloDve} = {rezultat:f2}");
                }
            }
            else if (operacia == "%")
            {
                rezultat = chisloEdno % chisloDve;
                if (chisloDve == 0)
                {
                    Console.WriteLine($"Cannot divide {chisloEdno} by zero");
                }
                else
                {
                    Console.WriteLine($"{chisloEdno} % {chisloDve} = {rezultat}");
                }
            }
        }
    }
}
