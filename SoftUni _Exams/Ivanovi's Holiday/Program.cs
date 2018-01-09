using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanovi_s_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int noshtuvki = int.Parse(Console.ReadLine());
            string destinacia = Console.ReadLine();
            string transport = Console.ReadLine();

            double cena = 0;
            double razhodTransport = 0;

            if (destinacia == "Miami")
            {
                if (noshtuvki >= 1 && noshtuvki <=10)
                {
                    cena = noshtuvki * ((2 * 24.99) + (3 * 14.99));
                }
                else if (noshtuvki >= 11 && noshtuvki <=15)
                {
                    cena = noshtuvki * ((2 * 22.99) + (3 * 11.99));
                }
                else if (noshtuvki >= 16)
                {
                    cena = noshtuvki * ((2 * 20.00) + (3 * 10.00));
                }
            }
            else if (destinacia == "Canary Islands")
            {
                if (noshtuvki >= 1 && noshtuvki <= 10)
                {
                    cena = noshtuvki * ((2 * 32.50) + (3 * 28.50));
                }
                else if (noshtuvki >= 11 && noshtuvki <= 15)
                {
                    cena = noshtuvki * ((2 * 30.50) + (3 * 25.60));
                }
                else if (noshtuvki >= 16)
                {
                    cena = noshtuvki * ((2 * 28.00) + (3 * 22.00));
                }
            }
            else if (destinacia == "Philippines")
            {
                if (noshtuvki >= 1 && noshtuvki <= 10)
                {
                    cena = noshtuvki * ((2 * 42.99) + (3 * 39.99));
                }
                else if (noshtuvki >= 11 && noshtuvki <= 15)
                {
                    cena = noshtuvki * ((2 * 41.00) + (3 * 36.00));
                }
                else if (noshtuvki >= 16)
                {
                    cena = noshtuvki * ((2 * 38.50) + (3 * 32.40));
                }
            }

            if (transport == "airplane")
            {
                razhodTransport = (2 * 90) + (3 * 68.50);
            }
            else if (transport == "train")
            {
                razhodTransport = (2 * 22.30) + (3 * 12.50);
            }
            else if (transport == "bus")
            {
                razhodTransport = (2 * 45.00) + (3 * 37.00);
            }

            double prestoi = cena + (cena * 0.25);
            double pochivka = prestoi + razhodTransport;
            Console.WriteLine($"{pochivka:f3}");
        }
    }
}
