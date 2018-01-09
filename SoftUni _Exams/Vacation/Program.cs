using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();

            string nastanqvane = "";
            string lokacia = "";
            double cena = 0;

            if (budget <= 1000 )
            {
                nastanqvane = "Camp";

                if (sezon == "Winter")
                {
                    lokacia = "Morocco";
                    cena = budget * 0.45;
                }
                else if (sezon == "Summer")
                {
                    lokacia = "Alaska";
                    cena = budget * 0.65;
                }
            }

            else if (budget > 1000 && budget <=3000)
            {
                nastanqvane = "Hut";

                if (sezon == "Winter")
                {
                    lokacia = "Morocco";
                    cena = budget * 0.60;
                }
                else if (sezon == "Summer")
                {
                    lokacia = "Alaska";
                    cena = budget * 0.80;
                }
            }

            else if (budget > 3000)
            {
                nastanqvane = "Hotel";
                cena = budget * 0.90;

                if (sezon == "Winter")
                {
                    lokacia = "Morocco";
                }
                else if (sezon == "Summer")
                {
                    lokacia = "Alaska";
                }
            }

            Console.WriteLine("{0} - {1} - {2:f2}", lokacia, nastanqvane, cena);
        }
    }
}
