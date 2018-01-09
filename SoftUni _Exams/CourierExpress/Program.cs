using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double cena = 0;
            double nadcenka = 0;

            

            double teglo = double.Parse(Console.ReadLine());
            string usluga = Console.ReadLine().ToLower();
            double razstoqnie = double.Parse(Console.ReadLine());

            

            if (usluga == "standard")
            {
                if (teglo < 1)
                {
                    cena = 0.03;
                }
                else if (teglo >= 1 && teglo <=10)
                {
                    cena = 0.05;
                }
                else if (teglo >= 11 && teglo <=40)
                {
                    cena = 0.10;
                }
                else if (teglo >=41 && teglo <=90)
                {
                    cena = 0.15;
                }
                else if (teglo >= 91 && teglo <= 150)
                {
                    cena = 0.20;
                }
               
            }

           else if (usluga == "express")
            {
                if (teglo < 1)
                {
                    nadcenka = 0.80;
                    cena = 0.03;
                }
                else if (teglo >= 1 && teglo <= 10)
                {
                    nadcenka = 0.40;
                    cena = 0.05;
                }
                else if (teglo >= 11 && teglo <= 40)
                {
                    nadcenka = 0.05;
                    cena = 0.10;
                }
                else if (teglo >= 41 && teglo <= 90)
                {
                    nadcenka = 0.02;
                    cena = 0.15;
                }
                else if (teglo >= 91 && teglo <= 150)
                {
                    nadcenka = 0.01;
                    cena = 0.20;
                }
            }

            double razhodi = cena * razstoqnie;
            double expresnaUsluga1 = nadcenka * cena;
            double expresnaUsluga2 = expresnaUsluga1 * teglo;
            double final = (expresnaUsluga2 * razstoqnie) + razhodi;

            
            Console.WriteLine("The delivery of your shipment with weight of {0} kg. would cost {1} lv.", teglo.ToString("N3"), final.ToString("N2"));

        }
    }
}
