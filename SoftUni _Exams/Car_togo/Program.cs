using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_togo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();

            string klas = "";
            string kola = "";
            double cena = 0;

            if (budget <= 100)
            {
                klas = "Economy class";
                if (sezon == "Summer")
                {
                    kola = "Cabrio";
                    cena = budget * 0.35;
                }
                else if (sezon =="Winter")
                {
                    kola = "Jeep";
                    cena = budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                klas = "Compact class";
                if (sezon == "Summer")
                {
                    kola = "Cabrio";
                    cena = budget * 0.45;
                }
                else if (sezon == "Winter")
                {
                    kola = "Jeep";
                    cena = budget * 0.80;
                }
            }
            else if (budget > 500)
            {
                klas = "Luxury class";
                cena = budget * 0.90;
                kola = "Jeep"; 
            }

            Console.WriteLine(klas);
            Console.WriteLine("{0} - {1:f2}", kola, cena);
        }
    }
}
