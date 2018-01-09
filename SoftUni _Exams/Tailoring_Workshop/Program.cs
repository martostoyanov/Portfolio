using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход
            int broi_masi = int.Parse(Console.ReadLine());
            double dalzhina = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());

            //калкулиране
            double obshtaPlosht= broi_masi * (dalzhina + 2 * 0.30) * (shirochina + 2 * 0.30);
            double obshtaKareta = broi_masi * (dalzhina / 2) * (dalzhina / 2);
            double cenaDolari = obshtaPlosht * 7 + obshtaKareta * 9;
            double cenaLevove = cenaDolari * 1.85;

            //изход
            Console.WriteLine($"{cenaDolari:f2} USD");
            Console.WriteLine($"{cenaLevove:f2} BGN");
        }
    }
}
