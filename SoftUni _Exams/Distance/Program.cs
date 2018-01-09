using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double skorost = double.Parse(Console.ReadLine());
            double parvoVreme = double.Parse(Console.ReadLine()) / 60;
            double vtoroVreme = double.Parse(Console.ReadLine()) / 60;
            double tretoVreme = double.Parse(Console.ReadLine()) / 60;

            double parvSkorost = skorost * parvoVreme;

            double sledUv = skorost + (skorost * 0.10);
            double izmKm = sledUv * vtoroVreme;

            double sledNam = sledUv - (sledUv * 0.05);
            double izmKmnam = sledNam * tretoVreme;

            double obshtoRaz = parvSkorost + izmKm + izmKmnam;
            Console.WriteLine($"{obshtoRaz:f2}");

        }
    }
}
