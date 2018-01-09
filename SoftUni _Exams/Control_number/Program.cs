using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int kontrolnoChislo = int.Parse(Console.ReadLine());

            int broqch = 0;
            int smetka = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    broqch++;
                    smetka +=  i * 2 + j * 3;
                    if (smetka >= kontrolnoChislo)
                    {
                        break;
                    }
                }
                if (smetka >= kontrolnoChislo)
                {
                    break;
                }
            }
            if (smetka >= kontrolnoChislo)
            {
                Console.WriteLine("{0} moves", broqch);
                Console.WriteLine("Score: {0} >= {1}", smetka, kontrolnoChislo);
            }
            else if (smetka < kontrolnoChislo)
            {
                Console.WriteLine("{0} moves", broqch);
            }
        }
    }
}
