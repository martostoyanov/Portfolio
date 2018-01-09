using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbor_ili_proizvedenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());

            int broqch = 0;

            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    for (int k = 1; k <= 30 ; k++)
                    {
                        if (i * j * k == chislo)
                        {
                            if ((i > j) && (j > k))
                            {
                                Console.WriteLine($"{i} * {j} * {k} = {chislo}");
                                broqch++;
                            }
                        }
                        else if (i + j + k == chislo)
                        {
                            if ((i < j) && (j < k))
                            {
                                Console.WriteLine($"{i} + {j} + {k} = {chislo}");
                                broqch++;
                            }
                        }
                    }
                }
            }

            if (broqch == 0)
            {
                Console.WriteLine("No!");
            }

        }
    }
}
