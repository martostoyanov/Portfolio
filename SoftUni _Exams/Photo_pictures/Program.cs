using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int snimki = int.Parse(Console.ReadLine());
            string vidSnimka = Console.ReadLine();
            string porachka = Console.ReadLine();

            double cena = 0;

            if (vidSnimka == "9X13")
            {
                cena = 0.16;
                if (snimki >=50)
                {
                    cena = cena - (cena * 0.05);
                }
            }
            else if (vidSnimka == "10X15")
            {
                cena = 0.16;
                if (snimki >= 80)
                {
                    cena = cena - (cena * 0.03);
                    
                }
            }
            else if (vidSnimka == "13X18")
            {
                cena = 0.38;
                if (snimki >= 50 && snimki <= 100)
                {
                    cena = cena - (cena * 0.03);
                }
                else if (snimki > 100)
                {
                    cena = cena - (cena * 0.05);
                }
            }
            else if (vidSnimka == "20X30")
            {
                cena = 2.90;
                if (snimki >= 10 && snimki < 50)
                {
                    cena = cena - (cena * 0.07);
                }
                else if (snimki > 50)
                {
                    cena = cena - (cena * 0.09);
                }
            }

            double finalCena = snimki * cena;
            if (porachka == "online")
            {
                finalCena = finalCena - (finalCena * 0.02);
                Console.WriteLine($"{finalCena:f2}BGN");
            }
            else if (porachka == "office")
            {
                Console.WriteLine($"{finalCena:f2}BGN");
            }


        }
    }
}
