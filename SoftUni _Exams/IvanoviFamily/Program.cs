using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanoviFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double podarukEdno = double.Parse(Console.ReadLine());
            double podarukDve = double.Parse(Console.ReadLine());
            double podarukTri = double.Parse(Console.ReadLine());

            double obshtasuma = podarukEdno + podarukDve + podarukTri;
            double darenie = (budget - obshtasuma) - ((budget - obshtasuma) * 0.10);

            Console.WriteLine($"{darenie:f2}");

        }
    }
}
