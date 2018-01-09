using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaSkumriq = double.Parse(Console.ReadLine());
            double cenaCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            double kgMidi = double.Parse(Console.ReadLine());

            double cenaPalamud = (cenaSkumriq + (cenaSkumriq * 0.60)) * kgPalamud;
            double cenaSafrid = (cenaCaca + (cenaCaca * 0.80)) * kgSafrid;
            double cenaMidi = 7.50 * kgMidi;

            double smetka = cenaPalamud + cenaSafrid + cenaMidi;
            Console.WriteLine($"{smetka:f2}");

        }
    }
}
