using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_name
{
    class Program
    {
        static void Main(string[] args)
        {
            //string glavna = Console.ReadLine().ToUpper();
            //string malka1 = Console.ReadLine().ToLower();
            //string malka2 = Console.ReadLine().ToLower();
            //string malka3 = Console.ReadLine().ToLower();

            char glavna = char.Parse(Console.ReadLine().ToUpper());
            char malka1 = char.Parse(Console.ReadLine().ToLower());
            char malka2 = char.Parse(Console.ReadLine().ToLower());
            char malka3 = char.Parse(Console.ReadLine().ToLower());

            int chislo = int.Parse(Console.ReadLine());

            int broqch = -1;

            for (char i = 'A'; i <= glavna; i++)
            {
                for (char j = 'a'; j <= malka1; j++)
                {
                    for (char k = 'a'; k <= malka2; k++)
                    {
                        for (char l = 'a'; l <= malka3; l++)
                        {
                            for (int m = 0; m <= chislo; m++)
                            {
                                broqch++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(broqch);

        }
    }
}
