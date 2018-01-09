using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlodoviKokteili
{
    class Program
    {
        static void Main(string[] args)
        {
            string plod = Console.ReadLine();
            string razmer = Console.ReadLine();
            int pitieta = int.Parse(Console.ReadLine());

            double cena = 0;

            if (razmer == "big")
            {
                if (plod == "Watermelon")
                {
                    cena = 5 * 28.70;
                }
                else if (plod == "Mango")
                {
                    cena = 5 * 19.60;
                }
                else if (plod == "Pineapple")
                {
                    cena = 5 * 24.80;
                }
                else if (plod == "Raspberry")
                {
                    cena = 5 * 15.20;
                }
            }
            else if (razmer == "small")
            {
                if (plod == "Watermelon")
                {
                    cena = 2 * 56;
                }
                else if (plod == "Mango")
                {
                    cena = 2 * 36.66;
                }
                else if (plod == "Pineapple")
                {
                    cena = 2 * 42.10;
                }
                else if (plod == "Raspberry")
                {
                    cena = 2 * 20;
                }
            }
            double smetka = pitieta * cena;
            if (smetka >= 400 && smetka <= 1000)
            {
                smetka = smetka - (smetka * 0.15);
                Console.WriteLine($"{smetka:f2} lv.");
            }
            else if (smetka > 1000)
            {
                smetka = smetka - (smetka * 0.50);
                Console.WriteLine($"{smetka:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{smetka:f2} lv.");
            }
        }
    }
}
