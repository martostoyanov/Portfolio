using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezi_ili_tura
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] moneta = { "ЕЗИ", "ТУРА" };
            int hvurlyane = random.Next(moneta.Length);

            Console.Write("Напишете какво ще се падне ЕЗИ или ТУРА: ");
            string zalog = Console.ReadLine().ToUpper();

            if (moneta[hvurlyane] == zalog)
            {
                Console.WriteLine("Падна се: {0}", moneta[hvurlyane]);
                Console.WriteLine("Познахте!");
            }
            else
            {
                Console.WriteLine("Падна се: {0}", moneta[hvurlyane]);
                Console.WriteLine("Не познахте!");
            }
        }
    }
}
