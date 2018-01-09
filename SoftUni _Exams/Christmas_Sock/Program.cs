using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Sock
{
    class Program
    {
        static void Main(string[] args)
        {
            int razmer = int.Parse(Console.ReadLine());

            for (int i = 0; i < razmer * 2; i++)
            {
                if (i == 1 || i == 3)
                {
                    Console.Write("|");
                    Console.Write("-", razmer * 2);
                    Console.WriteLine("|");
                }
                else if (i == 2)
                {
                    Console.Write("|");
                    Console.Write("*", razmer * 2);
                    Console.WriteLine("|");
                }
            }
        }
    }
}
