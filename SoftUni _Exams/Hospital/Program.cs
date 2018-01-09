using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());

            int lekari = 7;
            int pregledaniPacienti = 0;
            int nepregledani = 0;

            for (int i = 1; i <= dni; i++)
            {
                int pacienti = int.Parse(Console.ReadLine());

                if ((i % 3 == 0) && (nepregledani > pregledaniPacienti))
                {
                    lekari++;
                }

                if (pacienti > lekari)
                {
                    pregledaniPacienti += lekari;
                    nepregledani += pacienti - lekari;
                }
                else
                {
                    pregledaniPacienti += pacienti;
                }
            }
            Console.WriteLine("Treated patients: {0}.", pregledaniPacienti);
            Console.WriteLine("Untreated patients: {0}.", nepregledani);
        }
    }
}
