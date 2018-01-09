using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            string tarifa = Console.ReadLine();

            double suma = 0;

            if (km < 20)
            {
                if (tarifa == "day")
                {
                    suma = (km * 0.79) + 0.70;
                }
                else
                {
                    suma = (km * 0.90) + 0.70;
                }
            }
            else if (km >= 20 && km < 100)
            {
                suma = km * 0.09;
            }
            else if (km >= 100)
            {
                suma = km * 0.06;
            }

            Console.WriteLine(suma);
        }
    }
}
