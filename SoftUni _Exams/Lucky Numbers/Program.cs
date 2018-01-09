using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if ((i + j) == (k + l))
                            {
                                int suma = i + j;

                                var shtastlivoChislo = ($"{i}{j}{k}{l}");
                                if (chislo % suma == 0)
                                {
                                    Console.Write(shtastlivoChislo + " ");
                                }

                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
