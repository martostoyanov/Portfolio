using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoded_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            string str = "";
            string otgovor = "";

            for (int i = 0; i < chislo; i++)
            {
                int chisla = int.Parse(Console.ReadLine());
                if (chisla % 4 == 0)
                {
                    otgovor = "a";
                    a++;
                }
                else if (chisla % 4 == 1)
                {
                    otgovor = "b";
                    b++;
                }
                else if (chisla % 4 == 2)
                {
                    otgovor = "c";
                    c++;
                }
                else if (chisla % 4 == 3)
                {
                    otgovor = "d";
                    d++;
                }
                str = str + otgovor + ' ';
 
            }
            Console.WriteLine(str);
            Console.WriteLine("Answer A: {0}", a);
            Console.WriteLine("Answer B: {0}", b);
            Console.WriteLine("Answer C: {0}", c);
            Console.WriteLine("Answer D: {0}", d);
        }
    }
}
