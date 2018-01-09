using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string sezon = Console.ReadLine();
            double kilometri = double.Parse(Console.ReadLine());

            double zaplataKM = 0;

            if (sezon == "Spring" || sezon == "Autumn")
            {
                if (kilometri <=5000)
                {
                    zaplataKM = 0.75;
                }
                else if (kilometri > 5000 && kilometri <= 10000)
                {
                    zaplataKM = 0.95;
                }
                else if (kilometri > 10000 && kilometri <= 20000)
                {
                    zaplataKM = 1.45;
                }
            }
            else if (sezon == "Summer")
            {
                if (kilometri <= 5000)
                {
                    zaplataKM = 0.90;
                }
                else if (kilometri > 5000 && kilometri <= 10000)
                {
                    zaplataKM = 1.10;
                }
                else if (kilometri > 10000 && kilometri <= 20000)
                {
                    zaplataKM = 1.45;
                }
            }
            else if (sezon == "Winter")
            {
                if (kilometri <= 5000)
                {
                    zaplataKM = 1.05;
                }
                else if (kilometri > 5000 && kilometri <= 10000)
                {
                    zaplataKM = 1.25;
                }
                else if (kilometri > 10000 && kilometri <= 20000)
                {
                    zaplataKM = 1.45;
                }
            }
            double zaplata = (kilometri * zaplataKM) * 4;
            zaplata = zaplata - (zaplata * 0.10);
            Console.WriteLine($"{zaplata:f2}");
        }
    }
}
