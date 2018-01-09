using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime = Console.ReadLine();
            string familia = Console.ReadLine();
            int id = int.Parse(Console.ReadLine());
            double balans = double.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {ime} {familia}");
            Console.WriteLine($"Client id: {id}");
            Console.WriteLine($"Total balance: {balans:f2}");

            if (balans >= 0)
            {
                Console.WriteLine("Active: yes");
            }
            else
            {
                Console.WriteLine("Active: no");
            }
        }
    }
}
