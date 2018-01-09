using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            int obem = int.Parse(Console.ReadLine());
            int debitEdno = int.Parse(Console.ReadLine());
            int debitDve = int.Parse(Console.ReadLine());
            double chasove = double.Parse(Console.ReadLine());

            double trubaEdno = debitEdno * chasove;
            double trubaDve = debitDve * chasove;
            double sumaL = trubaEdno + trubaDve;

            if (obem >= sumaL)
            {
                double trubaProc = Math.Floor(debitEdno * chasove / sumaL * 100);
                double trubaProcent = Math.Floor(debitDve * chasove / sumaL * 100);
                double sumaLitri = sumaL / obem * 100;
                Console.WriteLine($"The pool is {sumaLitri}% full. Pipe 1: {trubaProc}%. Pipe 2: {trubaProcent}%.");
            }
            else
            {
                sumaL = sumaL - obem;
                Console.WriteLine($"For {chasove} hours the pool overflows with {sumaL:f1} liters.");
            }
        }
    }
}
