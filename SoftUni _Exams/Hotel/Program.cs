using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesec = Console.ReadLine();
            int noshtuvki = int.Parse(Console.ReadLine());

            double cenaStudio = 0;
            double cenaApartament = 0;

            if (mesec == "May" || mesec == "October")
            {
                cenaStudio = 50;
                cenaApartament = 65;
                if (noshtuvki > 7 && noshtuvki < 14)
                {
                    cenaStudio = 50 - (50 * 0.05);
                }
                if (noshtuvki > 14)
                {
                    cenaStudio = 50 - (50 * 0.30);
                    cenaApartament = 65 - (65 * 0.10);
                }
                double prestoiStudio = cenaStudio * noshtuvki;
                double prestoiApartament = cenaApartament * noshtuvki;
                Console.WriteLine("Apartment: {0:f2} lv.", prestoiApartament);
                Console.WriteLine("Studio: {0:f2} lv.", prestoiStudio);
            }
            else if (mesec == "June" || mesec == "September")
            {
                cenaStudio = 75.20;
                cenaApartament = 68.70;
                if (noshtuvki > 14)
                {
                    cenaStudio = 75.20 - (75.20 * 0.20);
                    cenaApartament = 68.70 - (68.70 * 0.10);
                }
                double prestoiStudio = cenaStudio * noshtuvki;
                double prestoiApartament = cenaApartament * noshtuvki;
                Console.WriteLine("Apartment: {0:f2} lv.", prestoiApartament);
                Console.WriteLine("Studio: {0:f2} lv.", prestoiStudio);
            }
            else if (mesec == "July" || mesec == "August")
            {
                cenaStudio = 76;
                cenaApartament = 77;
                if (noshtuvki > 14)
                {
                    cenaApartament = 77 - (77 * 0.10);
                }
                double prestoiStudio = cenaStudio * noshtuvki;
                double prestoiApartament = cenaApartament * noshtuvki;
                Console.WriteLine("Apartment: {0:f2} lv.", prestoiApartament);
                Console.WriteLine("Studio: {0:f2} lv.", prestoiStudio);
            }
        }
    }
}
