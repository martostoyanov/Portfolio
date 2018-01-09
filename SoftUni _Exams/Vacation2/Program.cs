using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation2
{
    class Program
    {
        static void Main(string[] args)
        {
            double stari = double.Parse(Console.ReadLine());
            double mladi = double.Parse(Console.ReadLine());
            double noshtuvki = double.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double cenaStari = 0;
            double cenaMladi = 0;

            if (transport == "airplane")
            {
                cenaStari = 70.00;
                cenaMladi = 50.00;
            }
            else if (transport == "train")
            {
                cenaStari = 24.99;
                cenaMladi = 14.99;
                if (mladi + stari >= 50)
                {
                    cenaStari = 24.99 * 0.50;
                    cenaMladi = 14.99 * 0.50;
                }
            }
            else if (transport == "boat")
            {
                cenaStari = 42.99;
                cenaMladi = 39.99;
            }
            else if (transport == "bus")
            {
                cenaStari = 32.50;
                cenaMladi = 28.50;
            }

            double razhodTransport = ( (stari * cenaStari) + (mladi * cenaMladi) ) * 2;
            double hotel = noshtuvki * 82.99;
            double komisionna = (razhodTransport + hotel) * 0.10;
            double cqlaSuma = razhodTransport + hotel + komisionna;

            Console.WriteLine($"{cqlaSuma:f2}");

        }
    }
}
