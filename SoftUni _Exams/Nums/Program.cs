using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo1 = int.Parse(Console.ReadLine());
            int chislo2 = int.Parse(Console.ReadLine());

            for (int i = chislo1; i <= chislo2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0:f3}", Math.Sqrt(i)); 
                }
                else
                {
                    Console.WriteLine("{0:f3}", i * i);
                }
            }
        }
    }
}
