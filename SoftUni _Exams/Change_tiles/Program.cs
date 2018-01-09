using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double pari = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double dalzhina = double.Parse(Console.ReadLine());
            double strTri = double.Parse(Console.ReadLine());
            double visTri = double.Parse(Console.ReadLine());
            double cenaPlochka = double.Parse(Console.ReadLine());
            double sumaMaistor = double.Parse(Console.ReadLine());

            double podPlosht = shirochina * dalzhina;
            double plockaPlosht = (strTri * visTri) / 2;
            double neobhPlochki = Math.Ceiling((podPlosht / plockaPlosht) + 5);
            double razhodi = (neobhPlochki * cenaPlochka) + sumaMaistor;

            if (pari >= razhodi)
            {
                double ostanaliPari = pari - razhodi;
                Console.WriteLine($"{ostanaliPari:f2} lv left.");
            }
            else if (razhodi > pari)
            {
                double morePari = razhodi - pari;
                Console.WriteLine($"You'll need {morePari:f2} lv more.");
            }

        }
    }
}
