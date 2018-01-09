using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwarf_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int djudjeta = int.Parse(Console.ReadLine());
            int pari = int.Parse(Console.ReadLine());

            double cena = 0;

            for (int i = 0; i < djudjeta; i++)
            {
                string podaruk = Console.ReadLine();

                if (podaruk == "sand clock")
                {
                    cena += 2.20;
                }
                else if (podaruk == "magnet")
                {
                    cena += 1.50;

                }
                else if (podaruk == "cup")
                {
                    cena += 5.00;
                }
                 else if (podaruk == "t-shirt")
                {
                    cena += 10.00;
                }

             }

            double smetka = Math.Abs(pari - cena);

            if (cena <= pari)
            {
                 Console.WriteLine("Santa Claus has {0:f2} more leva left!", smetka);
            }
            else
            {
                 Console.WriteLine("Santa Claus will need {0:f2} more leva.", smetka);
            }
        }
    }
}
