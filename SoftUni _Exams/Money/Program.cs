using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitkoini = double.Parse(Console.ReadLine());
            double yuana = double.Parse(Console.ReadLine());
            double komisionna = double.Parse(Console.ReadLine()) / 100.00;

            double bitkoiniKamleva = bitkoini * 1168.0;
            double yuanaKamdolari = yuana * 0.15;
            double dolaraKamleva = yuanaKamdolari * 1.76;

            double leva = bitkoiniKamleva + dolaraKamleva;
            double evro = leva / 1.95;
            evro = evro - (komisionna * evro);
            Console.WriteLine($"{evro:f2}");
        }
    }
}
