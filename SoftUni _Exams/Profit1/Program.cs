using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit1
{
    class Program
    {
        static void Main(string[] args)
        {
            double rabotniDni = double.Parse(Console.ReadLine());
            double nadnik = double.Parse(Console.ReadLine());
            double kurs = double.Parse(Console.ReadLine());

            double zaplata = ((rabotniDni * nadnik) * 12) + ((rabotniDni * nadnik) * 2.5);
            double danuk = zaplata - (zaplata * 0.25);
            double dohod = danuk * kurs;
            double pechalbaDen = dohod / 365;

            Console.WriteLine($"{pechalbaDen:f2}");
        }
    }
}
