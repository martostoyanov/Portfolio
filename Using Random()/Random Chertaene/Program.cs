using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Chertaene
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] razmer = new int[40];

            int x = random.Next(razmer.Length);
            int y = random.Next(razmer.Length);

            for (int i = 0; i <= x; i++)
            {
                Console.Write("#");

                for (int b = 0; b < y; b++)
                {
                    Console.Write("*");
                }
                for (int c = 0; c < x + y; c++)
                {
                    Console.Write("%");
                }
            }
            Console.WriteLine();
        }
    }
}
