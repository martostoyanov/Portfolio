using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lutenica
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double kgDomati = double.Parse(Console.ReadLine());
            double broiKasetki = double.Parse(Console.ReadLine());
            double broiBurkani = double.Parse(Console.ReadLine());

            //kalkulacia
            double kgLutenica = kgDomati / 5;
            double burkani = kgLutenica / 0.535;
            double kasetki = burkani / broiBurkani;

            //izhod sas proverka
            if (kasetki >= broiKasetki)
            {
                double ostanaliKasetki = kasetki - broiKasetki;
                double ostanaliBurkana = burkani - (broiKasetki * broiBurkani);
                Console.WriteLine("Total lutenica: {0} kilograms.",Math.Floor(kgLutenica));
                Console.WriteLine("{0} boxes left.", Math.Floor(ostanaliKasetki));
                Console.WriteLine("{0} jars left.", Math.Floor(ostanaliBurkana));
            }
            else if (broiKasetki > kasetki)
            {
                double ostanaliKasetki = broiKasetki - kasetki;
                double ostanaliBurkana = (broiKasetki * broiBurkani) - burkani;
                Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(kgLutenica));
                Console.WriteLine("{0} more boxes needed.", Math.Floor(ostanaliKasetki));
                Console.WriteLine("{0} more jars needed.", Math.Floor(ostanaliBurkana));
            }
        }
    }
}
