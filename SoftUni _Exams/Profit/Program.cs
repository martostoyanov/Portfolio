using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int edinLev = int.Parse(Console.ReadLine());
            int dvaLeva = int.Parse(Console.ReadLine());
            int petLeva = int.Parse(Console.ReadLine());
            int suma = int.Parse(Console.ReadLine());

            for (int i = 0; i <= edinLev; i++)
            {
                for (int j = 0; j <= dvaLeva; j++)
                {
                    for (int k = 0; k <= petLeva; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == suma)
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", i, j, k, suma);
                        }
                    }
                }
            }
        }
    }
}
