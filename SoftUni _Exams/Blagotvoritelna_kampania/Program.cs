using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagotvoritelna_kampania
{
    class Program
    {
        static void Main(string[] args)
        {
            double dni = double.Parse(Console.ReadLine());
            double sladkari = double.Parse(Console.ReadLine());
            double torti = double.Parse(Console.ReadLine());
            double gofreti = double.Parse(Console.ReadLine());
            double palachinki = double.Parse(Console.ReadLine());

            double sumaTorti = torti * 45;
            double sumaGofreti = gofreti * 5.80;
            double sumaPalachinki = palachinki * 3.20;

            double subranaSuma = (sumaTorti + sumaGofreti + sumaPalachinki) * sladkari;
            double sumaKampania = subranaSuma * dni;

            double pechalba = sumaKampania - (0.125 * sumaKampania);

            Console.WriteLine($"{pechalba:f2}");
        }
    }
}
