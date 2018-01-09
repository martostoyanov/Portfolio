using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_two_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nachalo = int.Parse(Console.ReadLine());
            int krai = int.Parse(Console.ReadLine());
            int magicChislo = int.Parse(Console.ReadLine());

            int broqch = 0;

            for (int i = nachalo; i <= krai; i++)
            {
                for (int j = nachalo; j <= krai; j++)
                {
                    broqch++;
                    if (i + j == magicChislo)
                    {
                        Console.WriteLine($"Combination N:{broqch} ({i} + {j} = {magicChislo})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{broqch} combinations - neither equals {magicChislo}");
        }
    }
}
