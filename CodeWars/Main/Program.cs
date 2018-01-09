using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            is_valid_IP(str);
        }

        public static bool is_valid_IP(string IpAddres)
        {
            string[] ip = IpAddres.Split('.');
            if (ip.Length != 4)
            {
                Console.WriteLine("Nevalidno IP");
                return false;
            }
            foreach (var adres in ip)
            {
                int stoinost;
                if (adres.StartsWith("0"))
                {
                    Console.WriteLine("Nevalidno IP");
                    return false;
                }
                if (adres.StartsWith(" "))
                {
                    Console.WriteLine("Nevalidno IP");
                    return false;
                }
                if (adres.EndsWith(" "))
                {
                    Console.WriteLine("Nevalidno IP");
                    return false;
                }
                if (Int32.TryParse(adres, out stoinost)==false)
                {
                    Console.WriteLine("Nevalidno IP");
                    return false;
                }
                if (stoinost < 0 || stoinost > 255)
                {
                    Console.WriteLine("Nevalidno IP");
                    return false;
                }
            }
            Console.WriteLine("Validno IP");
            return true;
        }
    }
}
