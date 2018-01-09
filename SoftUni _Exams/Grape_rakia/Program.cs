using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grape_rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double plosht = double.Parse(Console.ReadLine());
            double kgM2 = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());

            double ostanaloGrozde = (plosht * kgM2) - brak;
            double rakiaLitra = (ostanaloGrozde * 0.45) / 7.50;
            double prihodRakia = rakiaLitra * 9.80;
            double prihodGrozde = (ostanaloGrozde * 0.55) * 1.50;

            Console.WriteLine($"{prihodRakia:f2}");
            Console.WriteLine($"{prihodGrozde:f2}");
        }
    }
}
