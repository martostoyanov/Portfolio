using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            double hrana = double.Parse(Console.ReadLine());
            double elenEdno = double.Parse(Console.ReadLine());
            double elenDve = double.Parse(Console.ReadLine());
            double elenTri = double.Parse(Console.ReadLine());

            double hranaEdno = elenEdno * dni;
            double hranaDve = elenDve * dni;
            double hranaTri = elenTri * dni;

            double obshtoIzqdena = hranaEdno + hranaDve + hranaTri;

            if (hrana >= obshtoIzqdena)
            {
                hrana -= obshtoIzqdena;
                Console.WriteLine("{0} kilos of food left.", Math.Floor(hrana));
            }
            else
            {
                obshtoIzqdena -= hrana;
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(obshtoIzqdena));
            }
        }
    }
}
