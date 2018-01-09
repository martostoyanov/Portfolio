using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            string chislo = Console.ReadLine();

            for (int i = 1; i <= int.Parse(chislo[2].ToString()); i++)
            {
                for (int j = 1; j <= int.Parse(chislo[1].ToString()); j++)
                {
                    for (int k = 1; k <= int.Parse(chislo[0].ToString()); k++)
                    {
                        int sum = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {sum};");
                    }
                }
            }
        }
    }
}
