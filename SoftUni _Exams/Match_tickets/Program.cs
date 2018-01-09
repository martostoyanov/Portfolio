using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string kategoria = Console.ReadLine();
            double broiHora = double.Parse(Console.ReadLine());

            double cenaBilet = kategoria == "VIP" ? 499.99 : 249.99;

            double ostanaliPari = budget;
            if (broiHora < 5)
            {
                ostanaliPari = ostanaliPari - (budget * 0.75);
            }
            else if (broiHora >= 5 && broiHora < 10)
            {
                ostanaliPari = ostanaliPari - (budget * 0.60);
            }
            else if (broiHora >= 10 && broiHora < 25)
            {
                ostanaliPari = ostanaliPari - (budget * 0.50);
            }
            else if (broiHora >= 25 && broiHora < 50)
            {
                ostanaliPari = ostanaliPari - (budget * 0.40);
            }
            else
            {
                ostanaliPari = ostanaliPari - (budget * 0.25);
            }

            double obshtaSuma = broiHora * cenaBilet;

            if (obshtaSuma > ostanaliPari)
            {
                obshtaSuma = obshtaSuma - ostanaliPari;
                Console.WriteLine($"Not enough money! You need {obshtaSuma:f2} leva.");
            }
            else
            {
                ostanaliPari = ostanaliPari - obshtaSuma;
                Console.WriteLine($"Yes! You have {ostanaliPari:f2} leva left.");
            }
        }
    }
}
