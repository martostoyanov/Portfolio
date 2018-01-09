using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            int pochivnDni = int.Parse(Console.ReadLine());
            int normaTom = 30000;

            int rabotniDni = 365 - pochivnDni;

            int vremeIgra = (rabotniDni * 63) + (pochivnDni * 127);

            int ostanaloVreme = normaTom - vremeIgra;
            int chashove = Math.Abs(ostanaloVreme / 60);
            int minuti = Math.Abs(ostanaloVreme % 60);

            if (normaTom > vremeIgra)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{chashove} hours and {minuti} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{chashove} hours and {minuti} minutes more for play");
            }
        }
    }
}
