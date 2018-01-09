using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            double meseci = double.Parse(Console.ReadLine());
            double smetkaTok = 0;

            for (int i = 0; i < meseci; i++)
            {
                double tok = double.Parse(Console.ReadLine());
                smetkaTok += tok;
            }
            double smetkaVoda = meseci * 20;
            double smetkaInternet = meseci * 15;
            double smetkaDrugi = smetkaTok + smetkaVoda + smetkaInternet;
            smetkaDrugi = smetkaDrugi + (smetkaDrugi * 0.20);
            double srednoMesec = (smetkaTok + smetkaVoda + smetkaInternet + smetkaDrugi) / meseci;

            Console.WriteLine($"Electricity: {smetkaTok:f2} lv");
            Console.WriteLine($"Water: {smetkaVoda:f2} lv");
            Console.WriteLine($"Internet: {smetkaInternet:f2} lv");
            Console.WriteLine($"Other: {smetkaDrugi:f2} lv");
            Console.WriteLine($"Average: {srednoMesec:f2} lv");
        }
    }
}
