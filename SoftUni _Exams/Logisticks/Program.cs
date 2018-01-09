using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logisticks
{
    class Program
    {
        static void Main(string[] args)
        {
            double tovari = double.Parse(Console.ReadLine());

            double bus = 0;
            double kamion = 0;
            double vlak = 0;

            double cena = 0;
            double tonaj = 0;
            double tonove = 0;


            for (int i = 0; i < tovari; i++)
            {
                tonove = double.Parse(Console.ReadLine());
                if (tonove <= 3)
                {
                    bus += tonove;
                    cena += tonove * 200;
                }
                if (tonove >= 4 && tonove <= 11)
                {
                    kamion += tonove;
                    cena += tonove * 175;
                }
                if (tonove >= 12)
                {
                    vlak += tonove;
                    cena += tonove * 120;
                }
                tonaj += tonove;
            }

            double average = cena / tonaj;
            double busove = bus / tonaj * 100;
            double kamioni = kamion / tonaj * 100;
            double vlakove = vlak / tonaj * 100;
           
            Console.WriteLine($"{average:f2}");
            Console.WriteLine($"{busove:f2}%");
            Console.WriteLine($"{kamioni:f2}%");
            Console.WriteLine($"{vlakove:f2}%");

        }
    }
}
