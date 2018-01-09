using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_house
{
    class Program
    {
        static void Main(string[] args)
        {
            double dalzhina = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());

            double strani = dalzhina * (dalzhina / 2) * 2;
            double zadnaStena = ((dalzhina / 2) * (dalzhina / 2)) + ((dalzhina / 2 * (visochina - dalzhina / 2)) / 2);
            double prednaStena = zadnaStena - ((dalzhina / 5) * (dalzhina / 5));
            double obshtaPloshtSteni = strani + zadnaStena + prednaStena;
            double pokriv = dalzhina * (dalzhina / 2) * 2;

            double zelenaBoq = obshtaPloshtSteni / 3;
            double chervenaBoq = pokriv / 5;

            Console.WriteLine($"{zelenaBoq:f2}");
            Console.WriteLine($"{chervenaBoq:f2}");
        }
    }
}
