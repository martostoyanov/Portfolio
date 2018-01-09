using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int chisla = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < chisla; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                if (chislo < 200)
                {
                    p1++;
                }
                else if (chislo >= 200 && chislo < 400)
                {
                    p2++;
                }
                else if (chislo >= 400 && chislo < 600)
                {
                    p3++;
                }
                else if (chislo >= 600 && chislo < 800)
                {
                    p4++;
                }
                else if (chislo >= 800)
                {
                    p5++;
                }
            }
            double suma = p1 + p2 + p3 + p4 + p5;
            p1 = (p1 / suma) * 100;
            p2 = (p2 / suma) * 100;
            p3 = (p3 / suma) * 100;
            p4 = (p4 / suma) * 100;
            p5 = (p5 / suma) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
