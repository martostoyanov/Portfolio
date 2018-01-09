using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hungry_Garfield
{
    class Program
    {
        static void Main(string[] args)
        {
            double pari = double.Parse(Console.ReadLine());
            double valKurs = double.Parse(Console.ReadLine());
            double cenaPica = double.Parse(Console.ReadLine());
            double cenaLasania = double.Parse(Console.ReadLine());
            double cenaSandvich = double.Parse(Console.ReadLine());
            double kolPica = double.Parse(Console.ReadLine());
            double kolLasania = double.Parse(Console.ReadLine());
            double kolSandvich = double.Parse(Console.ReadLine());

            double poharcheniPica = (cenaPica / valKurs) * kolPica;
            double poharcheniLasania = (cenaLasania / valKurs) * kolLasania;
            double poharcheniSandvich = (cenaSandvich / valKurs) * kolSandvich;
            double obshtoPari = poharcheniPica + poharcheniLasania + poharcheniSandvich;
            double izhod = pari - obshtoPari;

            if (izhod >= 0)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", izhod);

            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", Math.Abs(izhod));
            }
        }
    }
}
