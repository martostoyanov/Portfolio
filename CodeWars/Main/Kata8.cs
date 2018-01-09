using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Kata8
    {
        public static string SayHello(string[] name, string city, string state)
        {
            string ime = string.Join(" ", name);
            return "Hello," + " " + ime + "!" + " " + "Welcome" + " " + "to" + " " + city + "," + " " + state + "!";
        }
        public static string GetPlanetName(int id)
        {
            string name = null;
            switch (id)
            {
                case 1:
                    name = "Mercury";
                    break;
                case 2:
                    name = "Venus";
                    break;
                case 3:
                    name = "Earth";
                    break;
                case 4:
                    name = "Mars";
                    break;
                case 5:
                    name = "Jupiter";
                    break;
                case 6:
                    name = "Saturn";
                    break;
                case 7:
                    name = "Uranus";
                    break;
                case 8:
                    name = "Neptune";
                    break;
            }

            return name;
        }
        public static int SquareSum(int[] n)
        {
            int suma = 0;
            for (int i = 0; i < n.Length; i++)
            {
                suma += (int)Math.Pow(n[i], 2);
            }
            return suma;
        }
    }
}
