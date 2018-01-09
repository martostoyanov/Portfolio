using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            int godini = int.Parse(Console.ReadLine());
            double cenaPeralnia = double.Parse(Console.ReadLine());
            double cenaIgrachki = double.Parse(Console.ReadLine());

            int pari = 10;
            int spesteni = 0;
            double suma = 0;

            int igrachki = 0;
            int pariBrat = 0;
            
            for (int i = 1; i <= godini; i++)
            {
                if (i % 2 == 0)
                {
                    spesteni += pari;
                    pari += 10;
                    pariBrat++;
                }
                else
                {
                    igrachki++;
                }
            }

            suma = (igrachki * cenaIgrachki) + (spesteni - pariBrat);
            double ostanaliPari = Math.Abs(suma - cenaPeralnia);

            if (suma >= cenaPeralnia)
            {
                Console.WriteLine($"Yes! {ostanaliPari:f2}");
            }
            else
            {
                Console.WriteLine($"No! {ostanaliPari:f2}");
            }
        }
    }
}
