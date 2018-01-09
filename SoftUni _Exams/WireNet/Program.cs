using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double mqstoDalzhina = double.Parse(Console.ReadLine());
            double mqstoShirochina = double.Parse(Console.ReadLine());
            double visochinaMrezha = double.Parse(Console.ReadLine());
            double cenaM2 = double.Parse(Console.ReadLine());
            double teglo = double.Parse(Console.ReadLine());

            //kalkulirane
            double mrezhaObshto = (2 * mqstoDalzhina) + (2 * mqstoShirochina);
            double cenaMrezha = mrezhaObshto * cenaM2;
            double ploshtMrezha = mrezhaObshto * visochinaMrezha;
            double tegloMrezha = ploshtMrezha * teglo;

            //printirane na rezultatite
            Console.WriteLine(mrezhaObshto);
            Console.WriteLine($"{cenaMrezha:f2}");
            Console.WriteLine($"{tegloMrezha:f3}");
            //Console.WriteLine(cenaMrezha.ToString("N2"));
            //Console.WriteLine(tegloMrezha.ToString("N3"));


        }
    }
}
