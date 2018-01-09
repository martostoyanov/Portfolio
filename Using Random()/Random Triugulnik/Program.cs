using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Triugulnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] masiv = new int[100];

            int razmer = random.Next(masiv.Length);

            for (int i = 1; i <= razmer; i++)
            {
                for (int j = 1; j <= razmer - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
    }
}
