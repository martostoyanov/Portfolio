using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParichnaNagrada
{
    class Program
    {
        static void Main(string[] args)
        {
            int chasti = int.Parse(Console.ReadLine());
            double nagradaTochka = double.Parse(Console.ReadLine());

            double suma = 0;

            for (int i = 1; i <= chasti; i++)
            {
                int tochki = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    tochki = tochki * 2;
                }
                suma = suma + tochki;
            }

            double krainaNagrada = nagradaTochka * suma;
            Console.WriteLine($"The project prize was {krainaNagrada:f2} lv.");
        }
    }
}
