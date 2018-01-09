using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double ekskurziq = double.Parse(Console.ReadLine());
            double broiPuzeli = double.Parse(Console.ReadLine());
            double broiKukli = double.Parse(Console.ReadLine());
            double broiMecheta = double.Parse(Console.ReadLine());
            double broiMinioni = double.Parse(Console.ReadLine());
            double broiKamioncheta = double.Parse(Console.ReadLine());

            double cenaPuzel = 2.60;
            double cenaKukli = 3;
            double cenaMecheta = 4.10;
            double cenaMinioni = 8.20;
            double cenaKamioncheta = 2;

            double smetka = (broiPuzeli * cenaPuzel) + (broiKukli * cenaKukli) + (cenaMecheta * broiMecheta) + (broiMinioni * cenaMinioni) + (broiKamioncheta * cenaKamioncheta);
            double broiIgrachki = broiPuzeli + broiKukli + broiMecheta + broiMinioni + broiKamioncheta;

            if (broiIgrachki >= 50)
            {
                double namalenie = smetka * 0.25;
                double krainaCena = smetka - namalenie;
                double ostanaliPari = krainaCena - (krainaCena * 0.10);
                if (ekskurziq <= ostanaliPari)
                {
                    double pari = ostanaliPari - ekskurziq;
                    Console.WriteLine($"Yes! {pari:f2} lv left.");
                }
                else if (ostanaliPari < ekskurziq)
                {
                    double pari = ekskurziq - ostanaliPari;
                    Console.WriteLine($"Not enough money! {pari:f2} lv needed.");
                }
            }
            else if (broiIgrachki < 50)
            {
                double ostanaliPari = smetka - (smetka * 0.10);
                if (ekskurziq <= ostanaliPari)
                {
                    double pari = ostanaliPari - ekskurziq;
                    Console.WriteLine($"Yes! {pari:f2} lv left.");
                }
                else if (ostanaliPari < ekskurziq)
                {
                    double pari = ekskurziq - ostanaliPari;
                    Console.WriteLine($"Not enough money! {pari:f2} lv needed.");
                }
            }

        }
    }
}
