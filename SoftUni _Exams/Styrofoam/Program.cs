using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double plosht = double.Parse(Console.ReadLine());
            double prozorci = double.Parse(Console.ReadLine());
            double paketM2 = double.Parse(Console.ReadLine());
            double cenaPaket = double.Parse(Console.ReadLine());

            double chistaPlosht = plosht - (prozorci * 2.4);
            double chistaFir = chistaPlosht + (chistaPlosht * 0.10);
            double razhod = Math.Ceiling(chistaFir / paketM2) * cenaPaket;

            if (budjet >=razhod)
            {
                Console.WriteLine($"Spent: {razhod:f2}");
                Console.WriteLine("Left: {0:f2}", budjet - razhod);
            }
            else if (razhod > budjet)
            {
                Console.WriteLine("Need more: {0:f2}", Math.Abs(razhod - budjet));
            }
        }
    }
}
