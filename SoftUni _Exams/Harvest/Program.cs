using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double loze = double.Parse(Console.ReadLine());
            double grozde = double.Parse(Console.ReadLine());
            double vino = double.Parse(Console.ReadLine());
            double rabotnici = double.Parse(Console.ReadLine());

            double obshtoGrozde = loze * grozde;
            double grozdeVino = (obshtoGrozde * 0.40) / 2.5;

            if (grozdeVino >= vino)
            {
                double ostanaloVino = grozdeVino - vino;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(grozdeVino));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(ostanaloVino), Math.Ceiling(ostanaloVino / rabotnici));
            }
            else if (vino > grozdeVino)
            {
                double nedostik = vino - grozdeVino;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(nedostik));
            }
        }
    }
}
