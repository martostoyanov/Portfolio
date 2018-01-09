using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double peika = m * o;
            double plosht = (n * n) - peika;
            double ploshtPlochki = w * l;

            double neobhodimiPlochki = plosht / ploshtPlochki;
            double neobhodimoVreme = neobhodimiPlochki * 0.2;

            Console.WriteLine($"{neobhodimiPlochki:f2}");
            Console.WriteLine($"{neobhodimoVreme:f2}");
        }
    }
}
