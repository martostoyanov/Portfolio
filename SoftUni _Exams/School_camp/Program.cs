using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sezon = Console.ReadLine();
            string grupa = Console.ReadLine();
            double broiUchenici = double.Parse(Console.ReadLine());
            double broiNoshtuvki = double.Parse(Console.ReadLine());

            string sport = "";
            double cenaHotel = 0;

            if (sezon == "Spring")
            {
                if (grupa == "girls")
                {
                    cenaHotel = 7.20;
                    sport = "Athletics";
                }
                else if (grupa == "boys")
                {
                    cenaHotel = 7.20;
                    sport = "Tennis";
                }
                else if (grupa == "mixed")
                {
                    cenaHotel = 9.50;
                    sport = "Cycling";
                }
            }

            else if (sezon == "Winter")
            {
                if (grupa == "girls")
                {
                    cenaHotel = 9.60;
                    sport = "Gymnastics";
                }
                else if (grupa == "boys")
                {
                    cenaHotel = 9.60;
                    sport = "Judo";
                }
                else if (grupa == "mixed")
                {
                    cenaHotel = 10;
                    sport = "Ski";
                }
            }

            else if (sezon == "Summer")
            {
                if (grupa == "girls")
                {
                    cenaHotel = 15;
                    sport = "Volleyball";
                }
                else if (grupa == "boys")
                {
                    cenaHotel = 15;
                    sport = "Football";
                }
                else if (grupa == "mixed")
                {
                    cenaHotel = 20;
                    sport = "Swimming";
                }
            }

            double cenaNoshtuvki = cenaHotel * broiNoshtuvki * broiUchenici;

            if (broiUchenici >= 10 && broiUchenici < 20)
            {
                cenaNoshtuvki = cenaNoshtuvki - (cenaNoshtuvki * 0.05);
            }

            else if (broiUchenici >= 20 && broiUchenici < 50)
            {
                cenaNoshtuvki = cenaNoshtuvki - (cenaNoshtuvki * 0.15);
            }
            else if (broiUchenici >=50)
            {
                cenaNoshtuvki = cenaNoshtuvki - (cenaNoshtuvki * 0.50);
            }

            Console.WriteLine("{0} {1:f2} lv.", sport, cenaNoshtuvki);
        }
    }
}
