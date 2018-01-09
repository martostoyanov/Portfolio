using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double visochina = double.Parse(Console.ReadLine());
            double dalzhina = double.Parse(Console.ReadLine());
            double pokriv = double.Parse(Console.ReadLine());

            double stranichniSteni = (2 * (visochina * dalzhina)) - (2 * (1.5 * 1.5));
            double zadnaPrednaStena = (2 * (visochina * visochina)) - (1.2 * 2);
            double obshtaPlosht = stranichniSteni + zadnaPrednaStena;

            double pokrivDalzhina = 2 * (visochina * dalzhina);
            double pokrivVisochina = 2 * (visochina * pokriv / 2);
            double obshtaPloshtPokriv = pokrivDalzhina + pokrivVisochina;

            double zelenaBoq = obshtaPlosht / 3.4;
            double chervenaBoq = obshtaPloshtPokriv / 4.3;

            Console.WriteLine($"{zelenaBoq:f2}");
            Console.WriteLine($"{chervenaBoq:f2}");
        }
    }
}
