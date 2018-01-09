using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (sezon == "summer")
                {
                    budget *= 0.30;
                    Console.WriteLine($"Camp - {budget:f2}");
                }
                else 
                {
                    budget *= 0.70;
                    Console.WriteLine($"Hotel - {budget:f2}");
                }
            }
            if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (sezon == "summer")
                {
                    budget = budget * 0.40;
                    Console.WriteLine($"Camp - {budget:f2}");
                }
                else
                {
                    budget = budget * 0.80;
                    Console.WriteLine($"Hotel - {budget:f2}");
                }
            }
            if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                budget *= 0.90;
                Console.WriteLine($"Hotel - {budget:f2}");
            }
        }
    }
}
