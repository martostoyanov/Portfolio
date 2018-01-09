using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirochina = int.Parse(Console.ReadLine());
            int dalzhina = int.Parse(Console.ReadLine());
            int torta = shirochina * dalzhina;

            while (torta >= 0)
            {
                string stop = Console.ReadLine().ToLower();
                if (stop == "stop")
                {
                    break;
                }
                torta = torta - int.Parse(stop);
            }

            if (torta >= 0)
            {
                Console.WriteLine("{0} pieces are left.", torta);
            }
            else
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(torta));
            }
        }
    }
}
