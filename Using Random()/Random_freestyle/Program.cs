using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_imena
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string [] mIme = {"Asen", "Petar", "Ivan", "Dimitar", "Aleksandar", "Jivko", "Georgi", "Todor"};
            string [] mFamilia = {"Ivanov", "Stoyanov", "Georgiev", "Gospodinov", "Todorov", "Petrov"};

            int majkoIme = random.Next(mIme.Length);
            int majkaFamilia = random.Next(mFamilia.Length);
           
            Console.WriteLine("Ime: {0}", mIme[majkoIme]);
            Console.WriteLine("Familia: {0}", mFamilia[majkaFamilia]);

        }
    }
}
