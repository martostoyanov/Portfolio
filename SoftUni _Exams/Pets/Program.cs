using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double dni = double.Parse(Console.ReadLine());
            double ostavenaHrana = double.Parse(Console.ReadLine());
            double hranaKuche = double.Parse(Console.ReadLine());
            double hranaKotka = double.Parse(Console.ReadLine());
            double hranaKostenurka = double.Parse(Console.ReadLine());

            double obshtoHrana = (dni * hranaKuche) + (dni * hranaKotka) + (dni * hranaKostenurka / 1000);
            if (obshtoHrana <= ostavenaHrana)
            {
                double ostanalaHrana = ostavenaHrana - obshtoHrana;
                Console.WriteLine("{0} kilos of food left.", Math.Floor(ostanalaHrana));
            }
            else if (ostavenaHrana < obshtoHrana)
            {
                double ostanalaHrana = obshtoHrana - ostavenaHrana;
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(ostanalaHrana));
            }
        }
    }
}
