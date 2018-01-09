using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double magnolii = double.Parse(Console.ReadLine()) * 3.25;
            double zumbuli = double.Parse(Console.ReadLine()) * 4;
            double rozi = double.Parse(Console.ReadLine()) * 3.50;
            double kaktusi = double.Parse(Console.ReadLine()) * 8;
            double cenaPodaruk = double.Parse(Console.ReadLine());

            double oborot = (magnolii + zumbuli + rozi + kaktusi) - ((magnolii + zumbuli + rozi + kaktusi) * 0.05);

            if (oborot >= cenaPodaruk)
            {
                double ostanaliPari = oborot - cenaPodaruk;
                Console.WriteLine("She is left with {0} leva.", Math.Floor(ostanaliPari));
            }
            else if (cenaPodaruk > oborot)
            {
                double nujniPari = cenaPodaruk - oborot;
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(nujniPari));
            }
        }
    }
}
