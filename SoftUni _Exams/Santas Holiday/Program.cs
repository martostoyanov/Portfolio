using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int prestoi = int.Parse(Console.ReadLine()) - 1;
            string staq = Console.ReadLine();
            string ocenka = Console.ReadLine();

            double cena = 0;
            double namalenie = 0;

            if (staq == "room for one person")
            {
                cena = 18.00;
            }
            if (staq == "apartment")
            {
                cena = 25.00;
                if (prestoi < 10)
                {
                    namalenie = 0.30;
                }
                else if (prestoi >= 10 && prestoi < 15)
                {
                    namalenie = 0.35;
                }
                else if (prestoi > 15)
                {
                    namalenie = 0.50;
                }
            }
            if (staq == "president apartment")
            {
                cena = 35.00;
                if (prestoi < 10)
                {
                    namalenie = 0.10;
                }
                else if (prestoi >= 10 && prestoi < 15)
                {
                    namalenie = 0.15;
                }
                else if (prestoi > 15)
                {
                    namalenie = 0.20;
                }
            }

            if (ocenka == "positive")
            {
                double smetka = (prestoi * cena) - ((prestoi * cena) * namalenie);
                double positive = smetka + (smetka * 0.25);
                Console.WriteLine($"{positive:f2}");
            }
            else if (ocenka == "negative")
            {
                double smetka = (prestoi * cena) - ((prestoi * cena) * namalenie);
                double negative = smetka - (smetka * 0.10);
                Console.WriteLine($"{negative:f2}");
            }
        }
    }
}
