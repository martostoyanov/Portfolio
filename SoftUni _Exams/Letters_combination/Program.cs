using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_combination
{
    class Program
    {
        static void Main(string[] args)
        {
            char pb = char.Parse(Console.ReadLine());
            char vb = char.Parse(Console.ReadLine());
            char tb = char.Parse(Console.ReadLine());

            int broqch = 0;

            for (char i = pb; i <= vb; i++)
            {
                for (char j = pb; j <= vb; j++)
                {
                    for (char k = pb; k <= vb; k++)
                    {
                        if (i == tb || j == tb || k == tb)
                        {
                            continue;
                        }

                        broqch++;
                        Console.Write($"{i}{j}{k} ");
                        
                    }
                }
            }
            Console.WriteLine(broqch);
        }
    }
}
