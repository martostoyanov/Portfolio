using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double rolkiHartiq = double.Parse(Console.ReadLine());
            double rolkiPlat = double.Parse(Console.ReadLine());
            double lepilo = double.Parse(Console.ReadLine());
            double namalenie = double.Parse(Console.ReadLine()) / 100;

            double opHartiq = 5.80;
            double plat = 7.20;
            double lepiloCena = 1.20;

            double smetka = (rolkiHartiq * opHartiq) + (rolkiPlat * plat) + (lepilo * lepiloCena);
            double krainaSmetka = smetka - (smetka * namalenie);

            Console.WriteLine($"{krainaSmetka:f3}");

        }
    }
}
