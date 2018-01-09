using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaZelenchuci = double.Parse(Console.ReadLine());
            double cenaPlodove = double.Parse(Console.ReadLine());
            double kgZelenchuci = double.Parse(Console.ReadLine());
            double kgPlodove = double.Parse(Console.ReadLine());

            double evro = 1.94;

            double suma = ((cenaZelenchuci * kgZelenchuci) + (cenaPlodove * kgPlodove)) / evro;

            Console.WriteLine(suma);
        }
    }
}
