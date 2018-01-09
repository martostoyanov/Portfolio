using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol_market
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaWhiskey = double.Parse(Console.ReadLine());
            double biraLitri = double.Parse(Console.ReadLine());
            double vinoLitri = double.Parse(Console.ReadLine());
            double rakiqLitri = double.Parse(Console.ReadLine());
            double whiskeyLitri = double.Parse(Console.ReadLine());

            double cenaRakiq = cenaWhiskey - (cenaWhiskey * 0.5);
            double cenaVino = cenaRakiq - (cenaRakiq * 0.4);
            double cenaBira = cenaRakiq - (cenaRakiq * 0.8);

            double sumaRakiq = cenaRakiq * rakiqLitri;
            double sumaVino = cenaVino * vinoLitri;
            double sumaBira = cenaBira * biraLitri;
            double sumaWhiskey = cenaWhiskey * whiskeyLitri;


            double smetka = sumaRakiq + sumaVino + sumaBira + sumaWhiskey;
            Console.WriteLine($"{smetka:f2}");
        }
    }
}
