using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_price
{
    class Program
    {
        static void Main(string[] args)
        {
            double malkaStaq = double.Parse(Console.ReadLine());
            double kuhnq = double.Parse(Console.ReadLine());
            double cenaM2 = double.Parse(Console.ReadLine());

            double banq = malkaStaq / 2;
            double vtoraStaq = malkaStaq + (malkaStaq * 0.10);
            double tretaStaq = vtoraStaq + (vtoraStaq * 0.10);
            double obshtaPlosht = (malkaStaq + kuhnq + banq + vtoraStaq + tretaStaq) + ((malkaStaq + kuhnq + banq + vtoraStaq + tretaStaq) * 0.05);

            double cena = obshtaPlosht * cenaM2;

            Console.WriteLine($"{cena:f2}");
        }
    }
}
